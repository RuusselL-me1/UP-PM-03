using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ApartmentRental_v1
{
    public partial class ApartmentEditorForm : Form
    {
        private int? _apartmentId;

        public ApartmentEditorForm(int? apartmentId = null)
        {
            InitializeComponent();
            _apartmentId = apartmentId;
        }

        private void ApartmentEditorForm_Load(object sender, EventArgs e)
        {
            LoadDistricts();

            if (_apartmentId.HasValue)
            {
                lblTitle.Text = "Редактирование квартиры #" + _apartmentId.Value;
                LoadApartmentDetails(_apartmentId.Value);
            }
            else
            {
                lblTitle.Text = "Новый объект недвижимости";
                cmbStatus.SelectedIndex = 0;
            }
        }

        private void LoadDistricts()
        {
            DataTable dt = DatabaseContext.ExecuteQuery("SELECT ID, DistrictName FROM Districts ORDER BY DistrictName");
            cmbDistrict.DataSource = dt;
            cmbDistrict.DisplayMember = "DistrictName";
            cmbDistrict.ValueMember = "ID";
        }

        private void LoadApartmentDetails(int id)
        {
            DataTable dt = DatabaseContext.ExecuteQuery("SELECT * FROM Apartments WHERE ID = ?", new OleDbParameter("?", id));
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                cmbDistrict.SelectedValue = Convert.ToInt32(r["DistrictID"]);
                txtAddress.Text = r["Address"].ToString();
                numRooms.Value = Convert.ToDecimal(r["RoomsCount"]);
                numFloor.Value = Convert.ToDecimal(r["Floor"]);
                numArea.Value = Convert.ToDecimal(r["TotalArea"]);
                numPriceMonth.Value = Convert.ToDecimal(r["PricePerMonth"]);
                numPriceDay.Value = Convert.ToDecimal(r["PricePerDay"]);
                cmbStatus.SelectedItem = r["Status"].ToString();
                txtDesc.Text = r["Description"] != DBNull.Value ? r["Description"].ToString() : "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Укажите адрес квартиры.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            if (cmbDistrict.SelectedValue == null)
            {
                MessageBox.Show("Выберите район города.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int districtId = Convert.ToInt32(cmbDistrict.SelectedValue);
            string address = txtAddress.Text.Trim();
            int rooms = (int)numRooms.Value;
            int floor = (int)numFloor.Value;
            double area = (double)numArea.Value;
            double priceMonth = (double)numPriceMonth.Value;
            double priceDay = (double)numPriceDay.Value;
            string status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Свободна";
            string desc = txtDesc.Text.Trim();

            if (_apartmentId.HasValue)
            {
                string sql = "UPDATE Apartments SET DistrictID = ?, Address = ?, RoomsCount = ?, Floor = ?, TotalArea = ?, PricePerMonth = ?, PricePerDay = ?, [Status] = ?, Description = ? WHERE ID = ?";
                DatabaseContext.ExecuteNonQuery(sql,
                    new OleDbParameter("?", districtId),
                    new OleDbParameter("?", address),
                    new OleDbParameter("?", rooms),
                    new OleDbParameter("?", floor),
                    new OleDbParameter("?", area),
                    new OleDbParameter("?", priceMonth),
                    new OleDbParameter("?", priceDay),
                    new OleDbParameter("?", status),
                    new OleDbParameter("?", desc),
                    new OleDbParameter("?", _apartmentId.Value)
                );
            }
            else
            {
                string sql = "INSERT INTO Apartments (DistrictID, Address, RoomsCount, Floor, TotalArea, PricePerMonth, PricePerDay, [Status], Description) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                DatabaseContext.ExecuteNonQuery(sql,
                    new OleDbParameter("?", districtId),
                    new OleDbParameter("?", address),
                    new OleDbParameter("?", rooms),
                    new OleDbParameter("?", floor),
                    new OleDbParameter("?", area),
                    new OleDbParameter("?", priceMonth),
                    new OleDbParameter("?", priceDay),
                    new OleDbParameter("?", status),
                    new OleDbParameter("?", desc)
                );
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
