namespace ApartmentRental_v2
{
    partial class AuthForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlHint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.pnlTop.Controls.Add(this.lblSubTitle);
            this.pnlTop.Controls.Add(this.lblMainTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(420, 68);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.lblSubTitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(306, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Агентство недвижимости «Городской Квартал» | v2.0";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(18, 14);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(225, 25);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Вход в систему аренды";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLogin.Location = new System.Drawing.Point(25, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(124, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Имя пользователя:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLogin.Location = new System.Drawing.Point(28, 110);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(360, 25);
            this.txtLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPassword.Location = new System.Drawing.Point(25, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(28, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(360, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkShowPassword.Location = new System.Drawing.Point(28, 205);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(118, 19);
            this.chkShowPassword.TabIndex = 5;
            this.chkShowPassword.Text = "Показать пароль";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(28, 235);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Авторизоваться";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExit.Location = new System.Drawing.Point(218, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlHint
            // 
            this.pnlHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.pnlHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHint.Controls.Add(this.lblHint);
            this.pnlHint.Location = new System.Drawing.Point(28, 285);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(360, 75);
            this.pnlHint.TabIndex = 8;
            // 
            // lblHint
            // 
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.lblHint.Location = new System.Drawing.Point(0, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Padding = new System.Windows.Forms.Padding(6);
            this.lblHint.Size = new System.Drawing.Size(358, 73);
            this.lblHint.TabIndex = 0;
            this.lblHint.Text = "Тестовые учетные записи:\r\n• Администратор: admin / admin123\r\n• Риелтор: realtor " +
    "/ realtor123\r\n• Клиент: client / client123";
            // 
            // AuthForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(420, 375);
            this.Controls.Add(this.pnlHint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlHint.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.Label lblHint;
    }
}
