namespace ApartmentRental_v2
{
    partial class ClientDirectoryForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Карточка клиента / юрлица";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.Location = new System.Drawing.Point(20, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ФИО / Организация:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.Location = new System.Drawing.Point(155, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 24);
            this.txtName.TabIndex = 2;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPassport.Location = new System.Drawing.Point(20, 95);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(117, 17);
            this.lblPassport.TabIndex = 3;
            this.lblPassport.Text = "Паспорт или ИНН:";
            // 
            // txtPassport
            // 
            this.txtPassport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassport.Location = new System.Drawing.Point(155, 92);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(270, 24);
            this.txtPassport.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhone.Location = new System.Drawing.Point(20, 135);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(113, 17);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Номер телефона:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPhone.Location = new System.Drawing.Point(155, 132);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(270, 24);
            this.txtPhone.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.Location = new System.Drawing.Point(20, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Электронная почта:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(155, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblType.Location = new System.Drawing.Point(20, 215);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 17);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Тип клиента:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.cmbType.Location = new System.Drawing.Point(155, 212);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(270, 25);
            this.cmbType.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(195, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.Location = new System.Drawing.Point(315, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ClientDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(446, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.ClientDirectoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
