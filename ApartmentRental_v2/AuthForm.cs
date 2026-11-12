using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ApartmentRental_v2
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Введите имя пользователя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string sql = "SELECT ID, Username, FullName, [Role], Phone FROM Users WHERE Username = ? AND [Password] = ?";
            DataTable dt = DatabaseContext.ExecuteQuery(sql,
                new OleDbParameter("?", username),
                new OleDbParameter("?", password)
            );

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                CurrentSession.UserID = Convert.ToInt32(r["ID"]);
                CurrentSession.Username = r["Username"].ToString();
                CurrentSession.FullName = r["FullName"].ToString();
                CurrentSession.Role = r["Role"].ToString();
                CurrentSession.Phone = r["Phone"] != DBNull.Value ? r["Phone"].ToString() : "";

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.\nПожалуйста, проверьте введённые данные.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
