namespace ApartmentRental_v2
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
            this.lblRentCost = new System.Windows.Forms.Label();
            this.txtRentCost = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.numDeposit = new System.Windows.Forms.NumericUpDown();
            this.lblCommission = new System.Windows.Forms.Label();
            this.numCommission = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAll = new System.Windows.Forms.Label();
            this.txtTotalAll = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommission)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblHeader.Location = new System.Drawing.Point(18, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(288, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Оформление договора найма жилья";
            // 
            // lblApartment
            // 
            this.lblApartment.AutoSize = true;
            this.lblApartment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblApartment.Location = new System.Drawing.Point(20, 52);
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
            this.cmbApartment.Location = new System.Drawing.Point(155, 49);
            this.cmbApartment.Name = "cmbApartment";
            this.cmbApartment.Size = new System.Drawing.Size(340, 25);
            this.cmbApartment.TabIndex = 2;
            this.cmbApartment.SelectedIndexChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClient.Location = new System.Drawing.Point(20, 90);
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
            this.cmbClient.Location = new System.Drawing.Point(155, 87);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(340, 25);
            this.cmbClient.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblType.Location = new System.Drawing.Point(20, 128);
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
            this.cmbRentType.Location = new System.Drawing.Point(155, 125);
            this.cmbRentType.Name = "cmbRentType";
            this.cmbRentType.Size = new System.Drawing.Size(160, 25);
            this.cmbRentType.TabIndex = 6;
            this.cmbRentType.SelectedIndexChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStart.Location = new System.Drawing.Point(20, 166);
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
            this.dtpStart.Location = new System.Drawing.Point(155, 163);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(140, 24);
            this.dtpStart.TabIndex = 8;
            this.dtpStart.ValueChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEnd.Location = new System.Drawing.Point(315, 166);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(49, 17);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Выезд:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd.MM.yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(365, 163);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 24);
            this.dtpEnd.TabIndex = 10;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDuration.Location = new System.Drawing.Point(20, 204);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(95, 17);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Длительность:";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDuration.Location = new System.Drawing.Point(155, 201);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(140, 24);
            this.txtDuration.TabIndex = 12;
            // 
            // lblRentCost
            // 
            this.lblRentCost.AutoSize = true;
            this.lblRentCost.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRentCost.Location = new System.Drawing.Point(20, 242);
            this.lblRentCost.Name = "lblRentCost";
            this.lblRentCost.Size = new System.Drawing.Size(107, 17);
            this.lblRentCost.TabIndex = 13;
            this.lblRentCost.Text = "Арендная плата:";
            // 
            // txtRentCost
            // 
            this.txtRentCost.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtRentCost.Location = new System.Drawing.Point(155, 239);
            this.txtRentCost.Name = "txtRentCost";
            this.txtRentCost.ReadOnly = true;
            this.txtRentCost.Size = new System.Drawing.Size(140, 24);
            this.txtRentCost.TabIndex = 14;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDeposit.Location = new System.Drawing.Point(315, 204);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(45, 17);
            this.lblDeposit.TabIndex = 15;
            this.lblDeposit.Text = "Залог:";
            // 
            // numDeposit
            // 
            this.numDeposit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numDeposit.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numDeposit.Location = new System.Drawing.Point(365, 201);
            this.numDeposit.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            this.numDeposit.Name = "numDeposit";
            this.numDeposit.Size = new System.Drawing.Size(130, 24);
            this.numDeposit.TabIndex = 16;
            this.numDeposit.ValueChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCommission.Location = new System.Drawing.Point(315, 242);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(47, 17);
            this.lblCommission.TabIndex = 17;
            this.lblCommission.Text = "Комис:";
            // 
            // numCommission
            // 
            this.numCommission.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numCommission.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            this.numCommission.Location = new System.Drawing.Point(365, 239);
            this.numCommission.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numCommission.Name = "numCommission";
            this.numCommission.Size = new System.Drawing.Size(130, 24);
            this.numCommission.TabIndex = 18;
            this.numCommission.ValueChanged += new System.EventHandler(this.RecalculateCost);
            // 
            // lblTotalAll
            // 
            this.lblTotalAll.AutoSize = true;
            this.lblTotalAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblTotalAll.Location = new System.Drawing.Point(20, 280);
            this.lblTotalAll.Name = "lblTotalAll";
            this.lblTotalAll.Size = new System.Drawing.Size(126, 20);
            this.lblTotalAll.TabIndex = 19;
            this.lblTotalAll.Text = "Итого к оплате:";
            // 
            // txtTotalAll
            // 
            this.txtTotalAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotalAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.txtTotalAll.Location = new System.Drawing.Point(155, 277);
            this.txtTotalAll.Name = "txtTotalAll";
            this.txtTotalAll.ReadOnly = true;
            this.txtTotalAll.Size = new System.Drawing.Size(160, 27);
            this.txtTotalAll.TabIndex = 20;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPayment.Location = new System.Drawing.Point(20, 318);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(95, 17);
            this.lblPayment.TabIndex = 21;
            this.lblPayment.Text = "Статус оплаты:";
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Оплачено",
            "Частично",
            "Ожидает оплаты"});
            this.cmbPayment.Location = new System.Drawing.Point(155, 315);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(160, 25);
            this.cmbPayment.TabIndex = 22;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNotes.Location = new System.Drawing.Point(20, 355);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(86, 17);
            this.lblNotes.TabIndex = 23;
            this.lblNotes.Text = "Примечания:";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNotes.Location = new System.Drawing.Point(155, 352);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(340, 50);
            this.txtNotes.TabIndex = 24;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(205, 420);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(175, 34);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Заключить договор";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.Location = new System.Drawing.Point(390, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 34);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // RentalAgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(516, 470);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtTotalAll);
            this.Controls.Add(this.lblTotalAll);
            this.Controls.Add(this.numCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.numDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtRentCost);
            this.Controls.Add(this.lblRentCost);
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
            this.Text = "Оформление договора найма | v2.0";
            this.Load += new System.EventHandler(this.RentalAgreementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommission)).EndInit();
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
        private System.Windows.Forms.Label lblRentCost;
        private System.Windows.Forms.TextBox txtRentCost;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.NumericUpDown numDeposit;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.NumericUpDown numCommission;
        private System.Windows.Forms.Label lblTotalAll;
        private System.Windows.Forms.TextBox txtTotalAll;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
