using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ApartmentRental_v2
{
    public partial class RentalAgreementForm : Form
    {
        private DataTable _apartmentsTable;
        private double _rentCost = 0.0;
        private double _totalAll = 0.0;

        public RentalAgreementForm()
        {
            InitializeComponent();
        }

        private void RentalAgreementForm_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today.AddDays(7);
            cmbRentType.SelectedIndex = 0;
            cmbPayment.SelectedIndex = 0;

            LoadClients();
            LoadAvailableApartments();
            RecalculateCost(null, null);
        }

        private void LoadClients()
        {
            DataTable dt = DatabaseContext.ExecuteQuery("SELECT ID, (FullName & ' (' & Phone & ')') AS DisplayInfo FROM Clients ORDER BY FullName");
            cmbClient.DataSource = dt;
            cmbClient.DisplayMember = "DisplayInfo";
            cmbClient.ValueMember = "ID";
        }

        private void LoadAvailableApartments()
        {
            string sql = "SELECT ID, (Address & ' [' & TotalArea & ' м², ' & PricePerDay & ' р/сут]') AS DisplayInfo, PricePerMonth, PricePerDay FROM Apartments WHERE [Status] = 'Свободна' ORDER BY Address";
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
                txtRentCost.Text = "0 руб.";
                txtTotalAll.Text = "0 руб.";
                _rentCost = 0.0;
                _totalAll = 0.0;
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
                txtDuration.Text = "Неверный интервал";
                txtRentCost.Text = "0 руб.";
                txtTotalAll.Text = "0 руб.";
                _rentCost = 0.0;
                _totalAll = 0.0;
                return;
            }

            TimeSpan diff = end - start;
            int days = (int)diff.TotalDays;

            if (cmbRentType.SelectedIndex == 0)
            {
                _rentCost = days * pDay;
                txtDuration.Text = days + " сут.";
            }
            else
            {
                double months = days / 30.0;
                if (months < 1.0) months = 1.0;
                _rentCost = Math.Round(months * pMonth, 2);
                txtDuration.Text = days + " дн. (~" + Math.Round(months, 1) + " мес.)";
            }

            double deposit = (double)numDeposit.Value;
            double commission = (double)numCommission.Value;
            _totalAll = _rentCost + deposit + commission;

            txtRentCost.Text = _rentCost.ToString("N0") + " руб.";
            txtTotalAll.Text = _totalAll.ToString("N0") + " руб.";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbApartment.SelectedValue == null)
            {
                MessageBox.Show("Выберите объект недвижимости.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите арендатора.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            double deposit = (double)numDeposit.Value;
            double commission = (double)numCommission.Value;
            string payment = cmbPayment.SelectedItem != null ? cmbPayment.SelectedItem.ToString() : "Оплачено";
            string notes = txtNotes.Text.Trim();

            string insertSql = "INSERT INTO Rentals (ApartmentID, ClientID, StartDate, EndDate, RentType, TotalCost, DepositAmount, CommissionAmount, PaymentStatus, [Status], Notes) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            DatabaseContext.ExecuteNonQuery(insertSql,
                new OleDbParameter("?", aptId),
                new OleDbParameter("?", clientId),
                new OleDbParameter("?", start),
                new OleDbParameter("?", end),
                new OleDbParameter("?", rentType),
                new OleDbParameter("?", _totalAll),
                new OleDbParameter("?", deposit),
                new OleDbParameter("?", commission),
                new OleDbParameter("?", payment),
                new OleDbParameter("?", "Активен"),
                new OleDbParameter("?", notes)
            );

            string updateSql = "UPDATE Apartments SET [Status] = 'Сдана' WHERE ID = ?";
            DatabaseContext.ExecuteNonQuery(updateSql, new OleDbParameter("?", aptId));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
