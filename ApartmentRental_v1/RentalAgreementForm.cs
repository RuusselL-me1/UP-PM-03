using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ApartmentRental_v1
{
    public partial class RentalAgreementForm : Form
    {
        private DataTable _apartmentsTable;
        private double _currentCalculatedCost = 0.0;

        public RentalAgreementForm()
        {
            InitializeComponent();
        }

        private void RentalAgreementForm_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today.AddDays(7);
            cmbRentType.SelectedIndex = 0;

            LoadClients();
            LoadAvailableApartments();
            RecalculateCost(null, null);
        }

        private void LoadClients()
        {
            DataTable dt = DatabaseContext.ExecuteQuery("SELECT ID, FullName FROM Clients ORDER BY FullName");
            cmbClient.DataSource = dt;
            cmbClient.DisplayMember = "FullName";
            cmbClient.ValueMember = "ID";
        }

        private void LoadAvailableApartments()
        {
            string sql = "SELECT ID, (Address & ' (' & TotalArea & ' кв.м, ' & PricePerDay & ' руб/сут)') AS DisplayInfo, PricePerMonth, PricePerDay FROM Apartments WHERE [Status] = 'Свободна' ORDER BY Address";
            _apartmentsTable = DatabaseContext.ExecuteQuery(sql);
            cmbApartment.DataSource = _apartmentsTable;
            cmbApartment.DisplayMember = "DisplayInfo";
            cmbApartment.ValueMember = "ID";
        }

        private void RecalculateCost(object sender, EventArgs e)
        {
            if (cmbApartment.SelectedValue == null || _apartmentsTable == null || _apartmentsTable.Rows.Count == 0)
            {
                txtDuration.Text = "-";
                txtTotalCost.Text = "0 руб.";
                _currentCalculatedCost = 0.0;
                return;
            }

            int aptId;
            if (!int.TryParse(cmbApartment.SelectedValue.ToString(), out aptId))
            {
                return;
            }

            DataRow[] rows = _apartmentsTable.Select("ID = " + aptId);
            if (rows.Length == 0)
            {
                return;
            }

            double pMonth = Convert.ToDouble(rows[0]["PricePerMonth"]);
            double pDay = Convert.ToDouble(rows[0]["PricePerDay"]);

            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;

            if (end <= start)
            {
                txtDuration.Text = "Некорректные даты";
                txtTotalCost.Text = "0 руб.";
                _currentCalculatedCost = 0.0;
                return;
            }

            TimeSpan diff = end - start;
            int days = (int)diff.TotalDays;

            if (cmbRentType.SelectedIndex == 0)
            {
                _currentCalculatedCost = days * pDay;
                txtDuration.Text = days + " сут.";
            }
            else
            {
                double months = days / 30.0;
                if (months < 1.0) months = 1.0;
                _currentCalculatedCost = Math.Round(months * pMonth, 2);
                txtDuration.Text = days + " дн. (~" + Math.Round(months, 1) + " мес.)";
            }

            txtTotalCost.Text = _currentCalculatedCost.ToString("N0") + " руб.";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbApartment.SelectedValue == null)
            {
                MessageBox.Show("Выберите свободную квартиру для оформления договора.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента из списка.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;

            if (end <= start)
            {
                MessageBox.Show("Дата выезда должна быть позже даты заезда.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int aptId = Convert.ToInt32(cmbApartment.SelectedValue);
            int clientId = Convert.ToInt32(cmbClient.SelectedValue);
            string rentType = cmbRentType.SelectedItem.ToString();

            string insertSql = "INSERT INTO Rentals (ApartmentID, ClientID, StartDate, EndDate, RentType, TotalCost, [Status]) VALUES (?, ?, ?, ?, ?, ?, ?)";
            DatabaseContext.ExecuteNonQuery(insertSql,
                new OleDbParameter("?", aptId),
                new OleDbParameter("?", clientId),
                new OleDbParameter("?", start),
                new OleDbParameter("?", end),
                new OleDbParameter("?", rentType),
                new OleDbParameter("?", _currentCalculatedCost),
                new OleDbParameter("?", "Активен")
            );

            string updateSql = "UPDATE Apartments SET [Status] = 'Сдана' WHERE ID = ?";
            DatabaseContext.ExecuteNonQuery(updateSql, new OleDbParameter("?", aptId));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
