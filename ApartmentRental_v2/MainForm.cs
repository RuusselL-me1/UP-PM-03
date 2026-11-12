using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ApartmentRental_v2
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
            ApplyUserRole();

            LoadFilterDistricts();
            cmbFilterRooms.SelectedIndex = 0;
            cmbFilterStatus.SelectedIndex = 0;
            cmbExpPeriod.SelectedIndex = 0;

            _isInitializing = false;

            RefreshAll();
            RunExperiment();
        }

        private void ApplyUserRole()
        {
            lblUserInfo.Text = string.Format("Пользователь: {0} | Роль: {1}", CurrentSession.FullName, CurrentSession.Role);

            if (CurrentSession.IsClient)
            {
                btnAddApt.Visible = false;
                btnEditApt.Visible = false;
                btnDeleteApt.Visible = false;
                btnRentApt.Text = "Подать заявку";

                tabMain.TabPages.Remove(tabClients);
                btnDeleteRental.Visible = false;
                btnCloseRental.Visible = false;
            }
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
            if (CurrentSession.IsRealtor)
            {
                LoadClients();
            }
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
                    IIF(a.HasBalcony, 'Да', 'Нет') AS [Балкон],
                    IIF(a.HasFurniture, 'Да', 'Нет') AS [Мебель],
                    IIF(a.HasAppliances, 'Да', 'Нет') AS [Техника],
                    a.YearBuilt AS [Год],
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

            if (numFilterMaxPrice.Value > 0)
            {
                sql += " AND a.PricePerMonth <= " + (double)numFilterMaxPrice.Value;
            }

            if (chkFilterBalcony.Checked)
            {
                sql += " AND a.HasBalcony = True";
            }

            if (chkFilterFurniture.Checked)
            {
                sql += " AND a.HasFurniture = True";
            }

            if (chkFilterAppliances.Checked)
            {
                sql += " AND a.HasAppliances = True";
            }

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.Trim().Replace("'", "''");
                sql += " AND (a.Address LIKE '%" + search + "%' OR a.Description LIKE '%" + search + "%')";
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
                    r.RentType AS [Тип],
                    r.TotalCost AS [Сумма],
                    r.DepositAmount AS [Залог],
                    r.CommissionAmount AS [Комиссия],
                    r.PaymentStatus AS [Оплата],
                    r.[Status] AS [Статус договора],
                    r.Notes AS [Примечания]
                FROM (Rentals r
                INNER JOIN Apartments a ON r.ApartmentID = a.ID)
                INNER JOIN Clients c ON r.ClientID = c.ID
                ORDER BY r.ID DESC
            ";

            DataTable dt = DatabaseContext.ExecuteQuery(sql);
            dgvRentals.DataSource = dt;
        }

        private void LoadClients()
        {
            string sql = "SELECT ID, FullName AS [ФИО / Название], Passport AS [Паспорт / ИНН], Phone AS [Телефон], Email, ClientType AS [Категория] FROM Clients ORDER BY ID DESC";
            DataTable dt = DatabaseContext.ExecuteQuery(sql);
            dgvClients.DataSource = dt;
        }

        private void UpdateMetricCards()
        {
            object objTotal = DatabaseContext.ExecuteScalar("SELECT COUNT(*) FROM Apartments");
            int total = objTotal != null && objTotal != DBNull.Value ? Convert.ToInt32(objTotal) : 0;

            object objRented = DatabaseContext.ExecuteScalar("SELECT COUNT(*) FROM Apartments WHERE [Status] = 'Сдана'");
            int rented = objRented != null && objRented != DBNull.Value ? Convert.ToInt32(objRented) : 0;

            double occPercent = total > 0 ? (rented * 100.0 / total) : 0.0;

            object objRevenue = DatabaseContext.ExecuteScalar("SELECT SUM(TotalCost) FROM Rentals WHERE [Status] = 'Активен'");
            double revenue = objRevenue != null && objRevenue != DBNull.Value ? Convert.ToDouble(objRevenue) : 0.0;

            object objExtra = DatabaseContext.ExecuteScalar("SELECT SUM(DepositAmount + CommissionAmount) FROM Rentals WHERE [Status] = 'Активен'");
            double extra = objExtra != null && objExtra != DBNull.Value ? Convert.ToDouble(objExtra) : 0.0;

            lblCardTotal.Text = "Всего объектов: " + total;
            lblCardOccupancy.Text = "Занятость фонда: " + occPercent.ToString("F1") + "%";
            lblCardRevenue.Text = "Активная аренда: " + revenue.ToString("N0") + " руб.";
            lblCardCommissions.Text = "Комиссии и залоги: " + extra.ToString("N0") + " руб.";
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
            numFilterMaxPrice.Value = 0;
            chkFilterBalcony.Checked = false;
            chkFilterFurniture.Checked = false;
            chkFilterAppliances.Checked = false;
            txtSearch.Clear();
            _isInitializing = false;
            LoadApartments();
        }

        private void btnAddApt_Click(object sender, EventArgs e)
        {
            using (ApartmentEditorForm form = new ApartmentEditorForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshAll();
                }
            }
        }

        private void btnEditApt_Click(object sender, EventArgs e)
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

        private void btnDeleteApt_Click(object sender, EventArgs e)
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
                MessageBox.Show("Нельзя удалить объект \"" + address + "\", так как по нему числится " + rentalsCount + " договоров найма.", "Ограничение целостности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить объект:\n" + address + "?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DatabaseContext.ExecuteNonQuery("DELETE FROM Apartments WHERE ID = ?", new OleDbParameter("?", id));
                RefreshAll();
            }
        }

        private void btnRentApt_Click(object sender, EventArgs e)
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
                MessageBox.Show("Данный договор уже закрыт.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Завершить аренду по договору №" + rentalId + "?\nОбъект будет переведён в статус 'Свободна'.", "Завершение найма", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (ClientDirectoryForm form = new ClientDirectoryForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadClients();
                }
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Выберите клиента из списка.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["ID"].Value);
            using (ClientDirectoryForm form = new ClientDirectoryForm(id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadClients();
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Выберите клиента для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["ID"].Value);
            string name = dgvClients.CurrentRow.Cells["ФИО / Название"].Value.ToString();

            object countRentals = DatabaseContext.ExecuteScalar("SELECT COUNT(*) FROM Rentals WHERE ClientID = ?", new OleDbParameter("?", id));
            int rentalsCount = countRentals != null && countRentals != DBNull.Value ? Convert.ToInt32(countRentals) : 0;
            if (rentalsCount > 0)
            {
                MessageBox.Show("Нельзя удалить клиента \"" + name + "\", так как на него оформлено " + rentalsCount + " договоров.", "Ограничение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Удалить клиента:\n" + name + "?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DatabaseContext.ExecuteNonQuery("DELETE FROM Clients WHERE ID = ?", new OleDbParameter("?", id));
                LoadClients();
            }
        }

        private void btnExportApartments_Click(object sender, EventArgs e)
        {
            ExportGridToCsv(dgvApartments, "Каталог_квартир.csv");
        }

        private void btnExportRentals_Click(object sender, EventArgs e)
        {
            ExportGridToCsv(dgvRentals, "Журнал_договоров_аренды.csv");
        }

        private void ExportGridToCsv(DataGridView grid, string defaultFileName)
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                sfd.FileName = defaultFileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        sb.Append("\"" + grid.Columns[i].HeaderText.Replace("\"", "\"\"") + "\"");
                        if (i < grid.Columns.Count - 1) sb.Append(";");
                    }
                    sb.AppendLine();

                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        for (int i = 0; i < grid.Columns.Count; i++)
                        {
                            string val = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                            sb.Append("\"" + val.Replace("\"", "\"\"") + "\"");
                            if (i < grid.Columns.Count - 1) sb.Append(";");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Данные успешно выгружены в файл:\n" + sfd.FileName, "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRunExperiment_Click(object sender, EventArgs e)
        {
            RunExperiment();
        }

        private void RunExperiment()
        {
            int periodMonths = 1;
            if (cmbExpPeriod.SelectedIndex == 1) periodMonths = 3;
            else if (cmbExpPeriod.SelectedIndex == 2) periodMonths = 12;

            double expRate = (double)numExpExpenses.Value / 100.0;
            double taxRate = (double)numTaxRate.Value / 100.0;
            double sqMeterPurchase = (double)numSqMeterCost.Value;

            DataTable dtDistricts = DatabaseContext.ExecuteQuery("SELECT ID, DistrictName, CityZone FROM Districts ORDER BY DistrictName");
            DataTable dtApartments = DatabaseContext.ExecuteQuery("SELECT DistrictID, TotalArea, PricePerMonth, [Status] FROM Apartments");

            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Район города", typeof(string));
            resultTable.Columns.Add("Зона", typeof(string));
            resultTable.Columns.Add("Объектов", typeof(int));
            resultTable.Columns.Add("Сумм. площадь (м²)", typeof(double));
            resultTable.Columns.Add("Занятость (%)", typeof(string));
            resultTable.Columns.Add("Валовый доход (руб)", typeof(string));
            resultTable.Columns.Add("Расходы (руб)", typeof(string));
            resultTable.Columns.Add("Чистый доход NOI (руб)", typeof(string));
            resultTable.Columns.Add("Ставка/м² (руб)", typeof(string));
            resultTable.Columns.Add("Рентабельность ROI (%)", typeof(string));
            resultTable.Columns.Add("Инвестиционный вердикт", typeof(string));

            double totalGrossFund = 0.0;
            double totalNoiFund = 0.0;
            int totalApts = 0;
            int totalRentedApts = 0;
            string bestDistrict = "-";
            double maxRoi = -1.0;

            foreach (DataRow d in dtDistricts.Rows)
            {
                int distId = Convert.ToInt32(d["ID"]);
                string distName = d["DistrictName"].ToString();
                string cityZone = d["CityZone"].ToString();

                DataRow[] apts = dtApartments.Select("DistrictID = " + distId);
                int count = apts.Length;
                if (count == 0) continue;

                totalApts += count;
                double totalArea = 0.0;
                double monthlyPotential = 0.0;
                int rentedCount = 0;

                foreach (DataRow a in apts)
                {
                    totalArea += Convert.ToDouble(a["TotalArea"]);
                    monthlyPotential += Convert.ToDouble(a["PricePerMonth"]);
                    if (a["Status"].ToString() == "Сдана")
                    {
                        rentedCount++;
                    }
                }
                totalRentedApts += rentedCount;

                double occupancyRate = count > 0 ? (rentedCount * 100.0 / count) : 0.0;
                double grossRevenue = (monthlyPotential * (occupancyRate / 100.0)) * periodMonths;
                if (grossRevenue <= 0 && count > 0)
                {
                    grossRevenue = (monthlyPotential * 0.5) * periodMonths;
                }

                double expenses = grossRevenue * (expRate + taxRate);
                double noi = grossRevenue - expenses;

                totalGrossFund += grossRevenue;
                totalNoiFund += noi;

                double avgRatePerM2 = totalArea > 0 ? (monthlyPotential / totalArea) : 0.0;
                double estimatedAssetValue = totalArea * sqMeterPurchase;
                double annualizedNoi = noi * (12.0 / periodMonths);
                double roi = estimatedAssetValue > 0 ? (annualizedNoi / estimatedAssetValue) * 100.0 : 0.0;

                string verdict;
                if (roi >= 8.5)
                {
                    verdict = "Высокая рентабельность";
                }
                else if (roi >= 5.5)
                {
                    verdict = "Оптимальный доход";
                }
                else
                {
                    verdict = "Низкая окупаемость";
                }

                if (roi > maxRoi)
                {
                    maxRoi = roi;
                    bestDistrict = distName;
                }

                resultTable.Rows.Add(
                    distName,
                    cityZone,
                    count,
                    Math.Round(totalArea, 1),
                    occupancyRate.ToString("F1") + "%",
                    grossRevenue.ToString("N0"),
                    expenses.ToString("N0"),
                    noi.ToString("N0"),
                    Math.Round(avgRatePerM2, 0).ToString("N0"),
                    roi.ToString("F2") + "%",
                    verdict
                );
            }

            dgvExperiment.DataSource = resultTable;

            double overallOccupancy = totalApts > 0 ? (totalRentedApts * 100.0 / totalApts) : 0.0;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("ИТОГИ ЭКСПЕРИМЕНТАЛЬНОГО РАСЧЕТА (Период: {0}):", cmbExpPeriod.SelectedItem));
            sb.AppendLine(string.Format("1. Общий фонд жилья: {0} объектов. Средний коэффициент загрузки (Occupancy Rate): {1:F1}%.", totalApts, overallOccupancy));
            sb.AppendLine(string.Format("2. Валовый арендный доход по агентству: {0:N0} руб. Суммарный чистый операционный доход (NOI): {1:N0} руб.", totalGrossFund, totalNoiFund));
            sb.AppendLine(string.Format("3. Наиболее инвестиционно привлекательный район: «{0}» с максимальной доходностью ROI = {1:F2}% годовых.", bestDistrict, maxRoi));
            sb.AppendLine("4. Рекомендация аналитического отдела: Увеличить долю 1- и 2-комнатных квартир комфорт-класса в Центральном и Октябрьском районах с целью достижения среднегодовой рентабельности свыше 9.5%.");

            txtExpConclusion.Text = sb.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentSession.Clear();
            Hide();
            using (AuthForm auth = new AuthForm())
            {
                if (auth.ShowDialog() == DialogResult.OK)
                {
                    ApplyUserRole();
                    Show();
                    RefreshAll();
                    RunExperiment();
                }
                else
                {
                    Close();
                }
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabExperiment)
            {
                RunExperiment();
            }
            else if (tabMain.SelectedTab == tabRentals)
            {
                LoadRentals();
            }
            else if (tabMain.SelectedTab == tabApartments)
            {
                LoadApartments();
            }
            else if (tabMain.SelectedTab == tabClients && CurrentSession.IsRealtor)
            {
                LoadClients();
            }
        }
    }
}
