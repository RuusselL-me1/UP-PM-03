namespace ApartmentRental_v1
{
    partial class RentalAgreementForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblApartment = new System.Windows.Forms.Label();
            this.cmbApartment = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbRentType = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblHeader.Location = new System.Drawing.Point(18, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(248, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Оформление договора аренды";
            // 
            // lblApartment
            // 
            this.lblApartment.AutoSize = true;
            this.lblApartment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblApartment.Location = new System.Drawing.Point(20, 55);
            this.lblApartment.Name = "lblApartment";
            this.lblApartment.Size = new System.Drawing.Size(124, 17);
            this.lblApartment.TabIndex = 1;
            this.lblApartment.Text = "Выберите объект:";
            // 
            // cmbApartment
            // 
            this.cmbApartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbApartment.FormattingEnabled = true;
            this.cmbApartment.Location = new System.Drawing.Point(155, 52);
            this.cmbApartment.Name = "cmbApartment";
            this.cmbApartment.Size = new System.Drawing.Size(320, 25);
            this.cmbApartment.TabIndex = 2;
            this.cmbApartment.SelectedIndexChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClient.Location = new System.Drawing.Point(20, 95);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(126, 17);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Клиент / арендатор:";
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(155, 92);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(320, 25);
            this.cmbClient.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblType.Location = new System.Drawing.Point(20, 135);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(83, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Тип аренды:";
            // 
            // cmbRentType
            // 
            this.cmbRentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRentType.FormattingEnabled = true;
            this.cmbRentType.Items.AddRange(new object[] {
            "Посуточно",
            "Долгосрочно"});
            this.cmbRentType.Location = new System.Drawing.Point(155, 132);
            this.cmbRentType.Name = "cmbRentType";
            this.cmbRentType.Size = new System.Drawing.Size(160, 25);
            this.cmbRentType.TabIndex = 6;
            this.cmbRentType.SelectedIndexChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStart.Location = new System.Drawing.Point(20, 175);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(84, 17);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Дата заезда:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd.MM.yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(155, 172);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(130, 24);
            this.dtpStart.TabIndex = 8;
            this.dtpStart.ValueChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEnd.Location = new System.Drawing.Point(20, 215);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(87, 17);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Дата выезда:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd.MM.yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(155, 212);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 24);
            this.dtpEnd.TabIndex = 10;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDuration.Location = new System.Drawing.Point(20, 255);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(95, 17);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Длительность:";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDuration.Location = new System.Drawing.Point(155, 252);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(160, 24);
            this.txtDuration.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 295);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 19);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Итоговая сумма:";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.txtTotalCost.Location = new System.Drawing.Point(155, 291);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(160, 27);
            this.txtTotalCost.TabIndex = 14;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(205, 345);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(155, 34);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Оформить договор";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.Location = new System.Drawing.Point(370, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // RentalAgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(496, 395);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.cmbRentType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.cmbApartment);
            this.Controls.Add(this.lblApartment);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalAgreementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оформление договора";
            this.Load += new System.EventHandler(this.RentalAgreementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblApartment;
        private System.Windows.Forms.ComboBox cmbApartment;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbRentType;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
