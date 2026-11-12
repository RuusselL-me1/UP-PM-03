using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ApartmentRental_v1
{
    public partial class MainForm : Form
    {
        private bool _isInitializing = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFilterDistricts();
            cmbFilterRooms.SelectedIndex = 0;
            cmbFilterStatus.SelectedIndex = 0;

            _isInitializing = false;

            RefreshAll();
        }

        private void LoadFilterDistricts()
        {
            DataTable dt = DatabaseContext.ExecuteQuery("SELECT ID, DistrictName FROM Districts ORDER BY DistrictName");
            DataRow allRow = dt.NewRow();
            allRow["ID"] = 0;
            allRow["DistrictName"] = "Все районы";
            dt.Rows.InsertAt(allRow, 0);

            cmbFilterDistrict.DataSource = dt;
            cmbFilterDistrict.DisplayMember = "DistrictName";
            cmbFilterDistrict.ValueMember = "ID";
            cmbFilterDistrict.SelectedIndex = 0;
        }

        private void RefreshAll()
        {
            LoadApartments();
            LoadRentals();
            LoadSummary();
            UpdateMetricCards();
        }

        private void LoadApartments()
        {
            string sql = @"
                SELECT 
                    a.ID,
                    d.DistrictName AS [Район],
                    a.Address AS [Адрес],
                    a.RoomsCount AS [Комнат],
                    a.Floor AS [Этаж],
                    a.TotalArea AS [Площадь кв м],
                    a.PricePerMonth AS [Аренда в месяц],
                    a.PricePerDay AS [Аренда в сутки],
                    a.[Status] AS [Статус],
                    a.Description AS [Описание]
                FROM Apartments a
                LEFT JOIN Districts d ON a.DistrictID = d.ID
                WHERE 1 = 1
            ";

            if (cmbFilterDistrict.SelectedIndex > 0 && cmbFilterDistrict.SelectedValue != null)
            {
                int distId = Convert.ToInt32(cmbFilterDistrict.SelectedValue);
                sql += " AND a.DistrictID = " + distId;
            }

            if (cmbFilterRooms.SelectedIndex > 0)
            {
                int rIndex = cmbFilterRooms.SelectedIndex;
                if (rIndex <= 3)
                {
                    sql += " AND a.RoomsCount = " + rIndex;
                }
                else
                {
                    sql += " AND a.RoomsCount >= 4";
                }
            }

            if (cmbFilterStatus.SelectedIndex > 0)
            {
                string status = cmbFilterStatus.SelectedItem.ToString();
                sql += " AND a.[Status] = '" + status + "'";
            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.Trim().Replace("'", "''");
                sql += " AND a.Address LIKE '%" + search + "%'";
            }

            sql += " ORDER BY a.ID DESC";

            DataTable dt = DatabaseContext.ExecuteQuery(sql);
            dgvApartments.DataSource = dt;
        }

        private void LoadRentals()
        {
            string sql = @"
                SELECT 
                    r.ID AS [№ Договора],
                    a.Address AS [Квартира],
                    c.FullName AS [Арендатор],
                    c.Phone AS [Телефон],
                    r.StartDate AS [Заезд],
                    r.EndDate AS [Выезд],
                    r.RentType AS [Тип аренды],
                    r.TotalCost AS [Сумма, руб],
                    r.[Status] AS [Статус договора]
                FROM (Rentals r
                INNER JOIN Apartments a ON r.ApartmentID = a.ID)
                INNER JOIN Clients c ON r.ClientID = c.ID
                ORDER BY r.ID DESC
            ";

            DataTable dt = DatabaseContext.ExecuteQuery(sql);
            dgvRentals.DataSource = dt;
        }

        private void LoadSummary()
        {
            string sql = @"
                SELECT 
                    d.DistrictName AS [Район города],
                    d.CityZone AS [Зона],
                    COUNT(a.ID) AS [Всего квартир],
                    SUM(IIF(a.[Status] = 'Свободна', 1, 0)) AS [Свободно],
                    SUM(IIF(a.[Status] = 'Сдана', 1, 0)) AS [Сдано],
                    ROUND(AVG(a.TotalArea), 1) AS [Ср площадь],
                    ROUND(AVG(a.PricePerMonth), 0) AS [Ср цена в месяц],
                    ROUND(AVG(a.PricePerDay), 0) AS [Ср цена в сутки]
                FROM Districts d
                LEFT JOIN Apartments a ON d.ID = a.DistrictID
                GROUP BY d.DistrictName, d.CityZone
                ORDER BY d.DistrictName
            ";

            DataTable dt = DatabaseContext.ExecuteQuery(sql);
            dgvDistrictSummary.DataSource = dt;
        }

        private void UpdateMetricCards()
        {
            object objTotal = DatabaseContext.ExecuteScalar("SELECT COUNT(*) FROM Apartments");
            int total = objTotal != null && objTotal != DBNull.Value ? Convert.ToInt32(objTotal) : 0;

            object objFree = DatabaseContext.ExecuteScalar("SELECT COUNT(*) FROM Apartments WHERE [Status] = 'Свободна'");
            int free = objFree != null && objFree != DBNull.Value ? Convert.ToInt32(objFree) : 0;

            object objRented = DatabaseContext.ExecuteScalar("SELECT COUNT(*) FROM Apartments WHERE [Status] = 'Сдана'");
            int rented = objRented != null && objRented != DBNull.Value ? Convert.ToInt32(objRented) : 0;

            object objRevenue = DatabaseContext.ExecuteScalar("SELECT SUM(TotalCost) FROM Rentals WHERE [Status] = 'Активен'");
            double revenue = objRevenue != null && objRevenue != DBNull.Value ? Convert.ToDouble(objRevenue) : 0.0;

            lblCardTotal.Text = "Всего объектов: " + total;
            lblCardFree.Text = "Свободно: " + free + " шт.";
            lblCardRented.Text = "Сдано: " + rented + " шт.";
            lblCardRevenue.Text = "Выручка от договоров: " + revenue.ToString("N0") + " руб.";
        }

        private void OnFilterChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;
            LoadApartments();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            _isInitializing = true;
            cmbFilterDistrict.SelectedIndex = 0;
            cmbFilterRooms.SelectedIndex = 0;
            cmbFilterStatus.SelectedIndex = 0;
            txtSearch.Clear();
            _isInitializing = false;
            LoadApartments();
        }

        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            using (ApartmentEditorForm form = new ApartmentEditorForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshAll();
                }
            }
        }

        private void btnEditApartment_Click(object sender, EventArgs e)
        {
            if (dgvApartments.CurrentRow == null)
            {
                MessageBox.Show("Выберите квартиру для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvApartments.CurrentRow.Cells["ID"].Value);
            using (ApartmentEditorForm form = new ApartmentEditorForm(id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshAll();
                }
            }
        }

        private void btnDeleteApartment_Click(object sender, EventArgs e)
        {
            if (dgvApartments.CurrentRow == null)
            {
                MessageBox.Show("Выберите объект для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvApartments.CurrentRow.Cells["ID"].Value);
            string address = dgvApartments.CurrentRow.Cells["Адрес"].Value.ToString();

            object countRentals = DatabaseContext.ExecuteScalar("SELECT COUNT(*) FROM Rentals WHERE ApartmentID = ?", new OleDbParameter("?", id));
            int rentalsCount = countRentals != null && countRentals != DBNull.Value ? Convert.ToInt32(countRentals) : 0;
            if (rentalsCount > 0)
            {
                MessageBox.Show("Нельзя удалить объект \"" + address + "\", так как по нему уже зарегистрировано " + rentalsCount + " договоров аренды.", "Ограничение целостности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить квартиру:\n" + address + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DatabaseContext.ExecuteNonQuery("DELETE FROM Apartments WHERE ID = ?", new OleDbParameter("?", id));
                RefreshAll();
            }
        }

        private void btnRentApartment_Click(object sender, EventArgs e)
        {
            using (RentalAgreementForm form = new RentalAgreementForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshAll();
                }
            }
        }

        private void btnCloseRental_Click(object sender, EventArgs e)
        {
            if (dgvRentals.CurrentRow == null)
            {
                MessageBox.Show("Выберите договор для завершения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rentalId = Convert.ToInt32(dgvRentals.CurrentRow.Cells["№ Договора"].Value);
            string status = dgvRentals.CurrentRow.Cells["Статус договора"].Value.ToString();

            if (status == "Завершен")
            {
                MessageBox.Show("Этот договор уже завершен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Завершить аренду по договору №" + rentalId + " и перевести квартиру в статус 'Свободна'?", "Завершение договора", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                object aptObj = DatabaseContext.ExecuteScalar("SELECT ApartmentID FROM Rentals WHERE ID = ?", new OleDbParameter("?", rentalId));
                if (aptObj != null && aptObj != DBNull.Value)
                {
                    int aptId = Convert.ToInt32(aptObj);
                    DatabaseContext.ExecuteNonQuery("UPDATE Apartments SET [Status] = 'Свободна' WHERE ID = ?", new OleDbParameter("?", aptId));
                }

                DatabaseContext.ExecuteNonQuery("UPDATE Rentals SET [Status] = 'Завершен' WHERE ID = ?", new OleDbParameter("?", rentalId));
                RefreshAll();
            }
        }

        private void btnDeleteRental_Click(object sender, EventArgs e)
        {
            if (dgvRentals.CurrentRow == null)
            {
                MessageBox.Show("Выберите договор для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rentalId = Convert.ToInt32(dgvRentals.CurrentRow.Cells["№ Договора"].Value);
            if (MessageBox.Show("Удалить запись о договоре №" + rentalId + "?", "Удаление договора", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DatabaseContext.ExecuteNonQuery("DELETE FROM Rentals WHERE ID = ?", new OleDbParameter("?", rentalId));
                RefreshAll();
            }
        }

        private void tabContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabContent.SelectedTab == tabSummary)
            {
                LoadSummary();
            }
            else if (tabContent.SelectedTab == tabRentals)
            {
                LoadRentals();
            }
            else if (tabContent.SelectedTab == tabApartments)
            {
                LoadApartments();
            }
        }
    }
}
