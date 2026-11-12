namespace ApartmentRental_v1
{
    partial class ApartmentEditorForm
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
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.numRooms = new System.Windows.Forms.NumericUpDown();
            this.lblFloor = new System.Windows.Forms.Label();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.lblArea = new System.Windows.Forms.Label();
            this.numArea = new System.Windows.Forms.NumericUpDown();
            this.lblPriceMonth = new System.Windows.Forms.Label();
            this.numPriceMonth = new System.Windows.Forms.NumericUpDown();
            this.lblPriceDay = new System.Windows.Forms.Label();
            this.numPriceDay = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Карточка объекта аренды";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDistrict.Location = new System.Drawing.Point(20, 52);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(95, 17);
            this.lblDistrict.TabIndex = 1;
            this.lblDistrict.Text = "Район города:";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(145, 49);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(280, 25);
            this.cmbDistrict.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAddress.Location = new System.Drawing.Point(20, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Точный адрес:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAddress.Location = new System.Drawing.Point(145, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 24);
            this.txtAddress.TabIndex = 4;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRooms.Location = new System.Drawing.Point(20, 124);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(107, 17);
            this.lblRooms.TabIndex = 5;
            this.lblRooms.Text = "Кол-во комнат:";
            // 
            // numRooms
            // 
            this.numRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numRooms.Location = new System.Drawing.Point(145, 122);
            this.numRooms.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numRooms.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numRooms.Name = "numRooms";
            this.numRooms.Size = new System.Drawing.Size(90, 24);
            this.numRooms.TabIndex = 6;
            this.numRooms.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFloor.Location = new System.Drawing.Point(255, 124);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(43, 17);
            this.lblFloor.TabIndex = 7;
            this.lblFloor.Text = "Этаж:";
            // 
            // numFloor
            // 
            this.numFloor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numFloor.Location = new System.Drawing.Point(335, 122);
            this.numFloor.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numFloor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(90, 24);
            this.numFloor.TabIndex = 8;
            this.numFloor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblArea.Location = new System.Drawing.Point(20, 160);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(98, 17);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Площадь (м²):";
            // 
            // numArea
            // 
            this.numArea.DecimalPlaces = 1;
            this.numArea.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numArea.Location = new System.Drawing.Point(145, 158);
            this.numArea.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numArea.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numArea.Name = "numArea";
            this.numArea.Size = new System.Drawing.Size(90, 24);
            this.numArea.TabIndex = 10;
            this.numArea.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // lblPriceMonth
            // 
            this.lblPriceMonth.AutoSize = true;
            this.lblPriceMonth.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPriceMonth.Location = new System.Drawing.Point(20, 196);
            this.lblPriceMonth.Name = "lblPriceMonth";
            this.lblPriceMonth.Size = new System.Drawing.Size(117, 17);
            this.lblPriceMonth.TabIndex = 11;
            this.lblPriceMonth.Text = "Аренда/мес (руб):";
            // 
            // numPriceMonth
            // 
            this.numPriceMonth.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numPriceMonth.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numPriceMonth.Location = new System.Drawing.Point(145, 194);
            this.numPriceMonth.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numPriceMonth.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numPriceMonth.Name = "numPriceMonth";
            this.numPriceMonth.Size = new System.Drawing.Size(120, 24);
            this.numPriceMonth.TabIndex = 12;
            this.numPriceMonth.Value = new decimal(new int[] { 25000, 0, 0, 0 });
            // 
            // lblPriceDay
            // 
            this.lblPriceDay.AutoSize = true;
            this.lblPriceDay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPriceDay.Location = new System.Drawing.Point(20, 232);
            this.lblPriceDay.Name = "lblPriceDay";
            this.lblPriceDay.Size = new System.Drawing.Size(123, 17);
            this.lblPriceDay.TabIndex = 13;
            this.lblPriceDay.Text = "Аренда/сут (руб):";
            // 
            // numPriceDay
            // 
            this.numPriceDay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numPriceDay.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            this.numPriceDay.Location = new System.Drawing.Point(145, 230);
            this.numPriceDay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numPriceDay.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numPriceDay.Name = "numPriceDay";
            this.numPriceDay.Size = new System.Drawing.Size(120, 24);
            this.numPriceDay.TabIndex = 14;
            this.numPriceDay.Value = new decimal(new int[] { 1800, 0, 0, 0 });
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatus.Location = new System.Drawing.Point(20, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 17);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Текущий статус:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Свободна",
            "Сдана",
            "Бронь",
            "Ремонт"});
            this.cmbStatus.Location = new System.Drawing.Point(145, 265);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(280, 25);
            this.cmbStatus.TabIndex = 16;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.Location = new System.Drawing.Point(20, 304);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(70, 17);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "Описание:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDesc.Location = new System.Drawing.Point(145, 301);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(280, 60);
            this.txtDesc.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(195, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 32);
            this.btnSave.TabIndex = 19;
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
            this.btnCancel.Location = new System.Drawing.Point(315, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ApartmentEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(446, 420);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numPriceDay);
            this.Controls.Add(this.lblPriceDay);
            this.Controls.Add(this.numPriceMonth);
            this.Controls.Add(this.lblPriceMonth);
            this.Controls.Add(this.numArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.numFloor);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.numRooms);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cmbDistrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApartmentEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор квартиры";
            this.Load += new System.EventHandler(this.ApartmentEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.NumericUpDown numRooms;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.NumericUpDown numArea;
        private System.Windows.Forms.Label lblPriceMonth;
        private System.Windows.Forms.NumericUpDown numPriceMonth;
        private System.Windows.Forms.Label lblPriceDay;
        private System.Windows.Forms.NumericUpDown numPriceDay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
