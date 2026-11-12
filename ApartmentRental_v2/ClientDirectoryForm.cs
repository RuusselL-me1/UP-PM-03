using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ApartmentRental_v2
{
    public partial class ClientDirectoryForm : Form
    {
        private int? _clientId;

        public ClientDirectoryForm(int? clientId = null)
        {
            InitializeComponent();
            _clientId = clientId;
        }

        private void ClientDirectoryForm_Load(object sender, EventArgs e)
        {
            if (_clientId.HasValue)
            {
                lblTitle.Text = "Редактирование клиента #" + _clientId.Value;
                LoadClientData(_clientId.Value);
            }
            else
            {
                lblTitle.Text = "Новый клиент / арендатор";
                cmbType.SelectedIndex = 0;
            }
        }

        private void LoadClientData(int id)
        {
            DataTable dt = DatabaseContext.ExecuteQuery("SELECT * FROM Clients WHERE ID = ?", new OleDbParameter("?", id));
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                txtName.Text = r["FullName"].ToString();
                txtPassport.Text = r["Passport"].ToString();
                txtPhone.Text = r["Phone"].ToString();
                txtEmail.Text = r["Email"] != DBNull.Value ? r["Email"].ToString() : "";
                cmbType.SelectedItem = r["ClientType"] != DBNull.Value ? r["ClientType"].ToString() : "Физическое лицо";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Укажите ФИО или наименование клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Укажите контактный номер телефона.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            string name = txtName.Text.Trim();
            string passport = txtPassport.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string type = cmbType.SelectedItem != null ? cmbType.SelectedItem.ToString() : "Физическое лицо";

            if (_clientId.HasValue)
            {
                string sql = "UPDATE Clients SET FullName = ?, Passport = ?, Phone = ?, Email = ?, ClientType = ? WHERE ID = ?";
                DatabaseContext.ExecuteNonQuery(sql,
                    new OleDbParameter("?", name),
                    new OleDbParameter("?", passport),
                    new OleDbParameter("?", phone),
                    new OleDbParameter("?", email),
                    new OleDbParameter("?", type),
                    new OleDbParameter("?", _clientId.Value)
                );
            }
            else
            {
                string sql = "INSERT INTO Clients (FullName, Passport, Phone, Email, ClientType) VALUES (?, ?, ?, ?, ?)";
                DatabaseContext.ExecuteNonQuery(sql,
                    new OleDbParameter("?", name),
                    new OleDbParameter("?", passport),
                    new OleDbParameter("?", phone),
                    new OleDbParameter("?", email),
                    new OleDbParameter("?", type)
                );
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
