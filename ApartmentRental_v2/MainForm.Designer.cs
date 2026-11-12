namespace ApartmentRental_v2
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.lblCardCommissions = new System.Windows.Forms.Label();
            this.lblCardRevenue = new System.Windows.Forms.Label();
            this.lblCardOccupancy = new System.Windows.Forms.Label();
            this.lblCardTotal = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.chkFilterAppliances = new System.Windows.Forms.CheckBox();
            this.chkFilterFurniture = new System.Windows.Forms.CheckBox();
            this.chkFilterBalcony = new System.Windows.Forms.CheckBox();
            this.numFilterMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.lblFilterMaxPrice = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cmbFilterRooms = new System.Windows.Forms.ComboBox();
            this.lblFilterRooms = new System.Windows.Forms.Label();
            this.cmbFilterDistrict = new System.Windows.Forms.ComboBox();
            this.lblFilterDistrict = new System.Windows.Forms.Label();
            this.lblFilterHeader = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabApartments = new System.Windows.Forms.TabPage();
            this.dgvApartments = new System.Windows.Forms.DataGridView();
            this.pnlAptBar = new System.Windows.Forms.Panel();
            this.btnExportApartments = new System.Windows.Forms.Button();
            this.btnRentApt = new System.Windows.Forms.Button();
            this.btnDeleteApt = new System.Windows.Forms.Button();
            this.btnEditApt = new System.Windows.Forms.Button();
            this.btnAddApt = new System.Windows.Forms.Button();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.pnlRentBar = new System.Windows.Forms.Panel();
            this.btnExportRentals = new System.Windows.Forms.Button();
            this.btnDeleteRental = new System.Windows.Forms.Button();
            this.btnCloseRental = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.pnlClientBar = new System.Windows.Forms.Panel();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tabExperiment = new System.Windows.Forms.TabPage();
            this.pnlExpBottom = new System.Windows.Forms.Panel();
            this.txtExpConclusion = new System.Windows.Forms.TextBox();
            this.lblExpConclusion = new System.Windows.Forms.Label();
            this.dgvExperiment = new System.Windows.Forms.DataGridView();
            this.pnlExpTop = new System.Windows.Forms.Panel();
            this.btnRunExperiment = new System.Windows.Forms.Button();
            this.numSqMeterCost = new System.Windows.Forms.NumericUpDown();
            this.lblSqMeterCost = new System.Windows.Forms.Label();
            this.numTaxRate = new System.Windows.Forms.NumericUpDown();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.numExpExpenses = new System.Windows.Forms.NumericUpDown();
            this.lblExpExpenses = new System.Windows.Forms.Label();
            this.cmbExpPeriod = new System.Windows.Forms.ComboBox();
            this.lblExpPeriod = new System.Windows.Forms.Label();
            this.lblExpDesc = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFilterMaxPrice)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabApartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).BeginInit();
            this.pnlAptBar.SuspendLayout();
            this.tabRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.pnlRentBar.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.pnlClientBar.SuspendLayout();
            this.tabExperiment.SuspendLayout();
            this.pnlExpBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperiment)).BeginInit();
            this.pnlExpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSqMeterCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.lblUserInfo);
            this.pnlTop.Controls.Add(this.lblSubTitle);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1084, 68);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(90)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(964, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Сменить роль";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblUserInfo.Location = new System.Drawing.Point(530, 24);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserInfo.Size = new System.Drawing.Size(420, 20);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "Пользователь: Шивырталов Д.А. | Роль: Администратор";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.lblSubTitle.Location = new System.Drawing.Point(18, 38);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(437, 17);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Информационная система управления арендой квартир | Редакция 2.0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Агентство недвижимости «Городской Квартал»";
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.White;
            this.pnlCards.Controls.Add(this.lblCardCommissions);
            this.pnlCards.Controls.Add(this.lblCardRevenue);
            this.pnlCards.Controls.Add(this.lblCardOccupancy);
            this.pnlCards.Controls.Add(this.lblCardTotal);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 68);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1084, 45);
            this.pnlCards.TabIndex = 1;
            // 
            // lblCardCommissions
            // 
            this.lblCardCommissions.AutoSize = true;
            this.lblCardCommissions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardCommissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.lblCardCommissions.Location = new System.Drawing.Point(680, 14);
            this.lblCardCommissions.Name = "lblCardCommissions";
            this.lblCardCommissions.Size = new System.Drawing.Size(183, 17);
            this.lblCardCommissions.TabIndex = 3;
            this.lblCardCommissions.Text = "Комиссии и залоги: 0 руб.";
            // 
            // lblCardRevenue
            // 
            this.lblCardRevenue.AutoSize = true;
            this.lblCardRevenue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblCardRevenue.Location = new System.Drawing.Point(440, 14);
            this.lblCardRevenue.Name = "lblCardRevenue";
            this.lblCardRevenue.Size = new System.Drawing.Size(178, 17);
            this.lblCardRevenue.TabIndex = 2;
            this.lblCardRevenue.Text = "Активная аренда: 0 руб.";
            // 
            // lblCardOccupancy
            // 
            this.lblCardOccupancy.AutoSize = true;
            this.lblCardOccupancy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardOccupancy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(60)))));
            this.lblCardOccupancy.Location = new System.Drawing.Point(220, 14);
            this.lblCardOccupancy.Name = "lblCardOccupancy";
            this.lblCardOccupancy.Size = new System.Drawing.Size(149, 17);
            this.lblCardOccupancy.TabIndex = 1;
            this.lblCardOccupancy.Text = "Занятость фонда: 0%";
            // 
            // lblCardTotal
            // 
            this.lblCardTotal.AutoSize = true;
            this.lblCardTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCardTotal.Location = new System.Drawing.Point(20, 14);
            this.lblCardTotal.Name = "lblCardTotal";
            this.lblCardTotal.Size = new System.Drawing.Size(126, 17);
            this.lblCardTotal.TabIndex = 0;
            this.lblCardTotal.Text = "Всего объектов: 0";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlLeft.Controls.Add(this.btnResetFilters);
            this.pnlLeft.Controls.Add(this.chkFilterAppliances);
            this.pnlLeft.Controls.Add(this.chkFilterFurniture);
            this.pnlLeft.Controls.Add(this.chkFilterBalcony);
            this.pnlLeft.Controls.Add(this.numFilterMaxPrice);
            this.pnlLeft.Controls.Add(this.lblFilterMaxPrice);
            this.pnlLeft.Controls.Add(this.txtSearch);
            this.pnlLeft.Controls.Add(this.lblSearch);
            this.pnlLeft.Controls.Add(this.cmbFilterStatus);
            this.pnlLeft.Controls.Add(this.lblFilterStatus);
            this.pnlLeft.Controls.Add(this.cmbFilterRooms);
            this.pnlLeft.Controls.Add(this.lblFilterRooms);
            this.pnlLeft.Controls.Add(this.cmbFilterDistrict);
            this.pnlLeft.Controls.Add(this.lblFilterDistrict);
            this.pnlLeft.Controls.Add(this.lblFilterHeader);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 113);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(225, 598);
            this.pnlLeft.TabIndex = 2;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.White;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnResetFilters.Location = new System.Drawing.Point(15, 395);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(195, 28);
            this.btnResetFilters.TabIndex = 14;
            this.btnResetFilters.Text = "Сбросить фильтры";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // chkFilterAppliances
            // 
            this.chkFilterAppliances.AutoSize = true;
            this.chkFilterAppliances.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkFilterAppliances.Location = new System.Drawing.Point(15, 360);
            this.chkFilterAppliances.Name = "chkFilterAppliances";
            this.chkFilterAppliances.Size = new System.Drawing.Size(126, 19);
            this.chkFilterAppliances.TabIndex = 13;
            this.chkFilterAppliances.Text = "Бытовая техника";
            this.chkFilterAppliances.UseVisualStyleBackColor = true;
            this.chkFilterAppliances.CheckedChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // chkFilterFurniture
            // 
            this.chkFilterFurniture.AutoSize = true;
            this.chkFilterFurniture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkFilterFurniture.Location = new System.Drawing.Point(15, 335);
            this.chkFilterFurniture.Name = "chkFilterFurniture";
            this.chkFilterFurniture.Size = new System.Drawing.Size(68, 19);
            this.chkFilterFurniture.TabIndex = 12;
            this.chkFilterFurniture.Text = "Мебель";
            this.chkFilterFurniture.UseVisualStyleBackColor = true;
            this.chkFilterFurniture.CheckedChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // chkFilterBalcony
            // 
            this.chkFilterBalcony.AutoSize = true;
            this.chkFilterBalcony.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkFilterBalcony.Location = new System.Drawing.Point(15, 310);
            this.chkFilterBalcony.Name = "chkFilterBalcony";
            this.chkFilterBalcony.Size = new System.Drawing.Size(107, 19);
            this.chkFilterBalcony.TabIndex = 11;
            this.chkFilterBalcony.Text = "Лоджия/балкон";
            this.chkFilterBalcony.UseVisualStyleBackColor = true;
            this.chkFilterBalcony.CheckedChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // numFilterMaxPrice
            // 
            this.numFilterMaxPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numFilterMaxPrice.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            this.numFilterMaxPrice.Location = new System.Drawing.Point(15, 275);
            this.numFilterMaxPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numFilterMaxPrice.Name = "numFilterMaxPrice";
            this.numFilterMaxPrice.Size = new System.Drawing.Size(195, 24);
            this.numFilterMaxPrice.TabIndex = 10;
            this.numFilterMaxPrice.ValueChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblFilterMaxPrice
            // 
            this.lblFilterMaxPrice.AutoSize = true;
            this.lblFilterMaxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterMaxPrice.Location = new System.Drawing.Point(15, 255);
            this.lblFilterMaxPrice.Name = "lblFilterMaxPrice";
            this.lblFilterMaxPrice.Size = new System.Drawing.Size(133, 15);
            this.lblFilterMaxPrice.TabIndex = 9;
            this.lblFilterMaxPrice.Text = "Бюджет до (руб/мес):";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(15, 220);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 24);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(15, 200);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 15);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Поиск по адресу:";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Все статусы",
            "Свободна",
            "Сдана",
            "Бронь",
            "Ремонт"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(15, 165);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(195, 25);
            this.cmbFilterStatus.TabIndex = 6;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 145);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(95, 15);
            this.lblFilterStatus.TabIndex = 5;
            this.lblFilterStatus.Text = "Статус объекта:";
            // 
            // cmbFilterRooms
            // 
            this.cmbFilterRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterRooms.FormattingEnabled = true;
            this.cmbFilterRooms.Items.AddRange(new object[] {
            "Любое число комнат",
            "1-комнатная",
            "2-комнатная",
            "3-комнатная",
            "4+ комнат"});
            this.cmbFilterRooms.Location = new System.Drawing.Point(15, 110);
            this.cmbFilterRooms.Name = "cmbFilterRooms";
            this.cmbFilterRooms.Size = new System.Drawing.Size(195, 25);
            this.cmbFilterRooms.TabIndex = 4;
            this.cmbFilterRooms.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblFilterRooms
            // 
            this.lblFilterRooms.AutoSize = true;
            this.lblFilterRooms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterRooms.Location = new System.Drawing.Point(15, 90);
            this.lblFilterRooms.Name = "lblFilterRooms";
            this.lblFilterRooms.Size = new System.Drawing.Size(117, 15);
            this.lblFilterRooms.TabIndex = 3;
            this.lblFilterRooms.Text = "Количество комнат:";
            // 
            // cmbFilterDistrict
            // 
            this.cmbFilterDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterDistrict.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFilterDistrict.FormattingEnabled = true;
            this.cmbFilterDistrict.Location = new System.Drawing.Point(15, 55);
            this.cmbFilterDistrict.Name = "cmbFilterDistrict";
            this.cmbFilterDistrict.Size = new System.Drawing.Size(195, 25);
            this.cmbFilterDistrict.TabIndex = 2;
            this.cmbFilterDistrict.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblFilterDistrict
            // 
            this.lblFilterDistrict.AutoSize = true;
            this.lblFilterDistrict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterDistrict.Location = new System.Drawing.Point(15, 35);
            this.lblFilterDistrict.Name = "lblFilterDistrict";
            this.lblFilterDistrict.Size = new System.Drawing.Size(86, 15);
            this.lblFilterDistrict.TabIndex = 1;
            this.lblFilterDistrict.Text = "Район города:";
            // 
            // lblFilterHeader
            // 
            this.lblFilterHeader.AutoSize = true;
            this.lblFilterHeader.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblFilterHeader.Location = new System.Drawing.Point(15, 12);
            this.lblFilterHeader.Name = "lblFilterHeader";
            this.lblFilterHeader.Size = new System.Drawing.Size(143, 19);
            this.lblFilterHeader.TabIndex = 0;
            this.lblFilterHeader.Text = "Параметры поиска";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabApartments);
            this.tabMain.Controls.Add(this.tabRentals);
            this.tabMain.Controls.Add(this.tabClients);
            this.tabMain.Controls.Add(this.tabExperiment);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabMain.Location = new System.Drawing.Point(225, 113);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(859, 598);
            this.tabMain.TabIndex = 3;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabApartments
            // 
            this.tabApartments.Controls.Add(this.dgvApartments);
            this.tabApartments.Controls.Add(this.pnlAptBar);
            this.tabApartments.Location = new System.Drawing.Point(4, 26);
            this.tabApartments.Name = "tabApartments";
            this.tabApartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabApartments.Size = new System.Drawing.Size(851, 568);
            this.tabApartments.TabIndex = 0;
            this.tabApartments.Text = "Каталог квартир";
            this.tabApartments.UseVisualStyleBackColor = true;
            // 
            // dgvApartments
            // 
            this.dgvApartments.AllowUserToAddRows = false;
            this.dgvApartments.AllowUserToDeleteRows = false;
            this.dgvApartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApartments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApartments.ColumnHeadersHeight = 32;
            this.dgvApartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApartments.EnableHeadersVisualStyles = false;
            this.dgvApartments.Location = new System.Drawing.Point(3, 49);
            this.dgvApartments.MultiSelect = false;
            this.dgvApartments.Name = "dgvApartments";
            this.dgvApartments.ReadOnly = true;
            this.dgvApartments.RowHeadersVisible = false;
            this.dgvApartments.RowTemplate.Height = 26;
            this.dgvApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartments.Size = new System.Drawing.Size(845, 516);
            this.dgvApartments.TabIndex = 1;
            // 
            // pnlAptBar
            // 
            this.pnlAptBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlAptBar.Controls.Add(this.btnExportApartments);
            this.pnlAptBar.Controls.Add(this.btnRentApt);
            this.pnlAptBar.Controls.Add(this.btnDeleteApt);
            this.pnlAptBar.Controls.Add(this.btnEditApt);
            this.pnlAptBar.Controls.Add(this.btnAddApt);
            this.pnlAptBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAptBar.Location = new System.Drawing.Point(3, 3);
            this.pnlAptBar.Name = "pnlAptBar";
            this.pnlAptBar.Size = new System.Drawing.Size(845, 46);
            this.pnlAptBar.TabIndex = 0;
            // 
            // btnExportApartments
            // 
            this.btnExportApartments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportApartments.BackColor = System.Drawing.Color.White;
            this.btnExportApartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportApartments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportApartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnExportApartments.Location = new System.Drawing.Point(710, 8);
            this.btnExportApartments.Name = "btnExportApartments";
            this.btnExportApartments.Size = new System.Drawing.Size(125, 30);
            this.btnExportApartments.TabIndex = 4;
            this.btnExportApartments.Text = "Экспорт в CSV";
            this.btnExportApartments.UseVisualStyleBackColor = false;
            this.btnExportApartments.Click += new System.EventHandler(this.btnExportApartments_Click);
            // 
            // btnRentApt
            // 
            this.btnRentApt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(60)))));
            this.btnRentApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentApt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRentApt.ForeColor = System.Drawing.Color.White;
            this.btnRentApt.Location = new System.Drawing.Point(400, 8);
            this.btnRentApt.Name = "btnRentApt";
            this.btnRentApt.Size = new System.Drawing.Size(160, 30);
            this.btnRentApt.TabIndex = 3;
            this.btnRentApt.Text = "Оформить аренду";
            this.btnRentApt.UseVisualStyleBackColor = false;
            this.btnRentApt.Click += new System.EventHandler(this.btnRentApt_Click);
            // 
            // btnDeleteApt
            // 
            this.btnDeleteApt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteApt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteApt.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApt.Location = new System.Drawing.Point(260, 8);
            this.btnDeleteApt.Name = "btnDeleteApt";
            this.btnDeleteApt.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteApt.TabIndex = 2;
            this.btnDeleteApt.Text = "Удалить";
            this.btnDeleteApt.UseVisualStyleBackColor = false;
            this.btnDeleteApt.Click += new System.EventHandler(this.btnDeleteApt_Click);
            // 
            // btnEditApt
            // 
            this.btnEditApt.BackColor = System.Drawing.Color.White;
            this.btnEditApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditApt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditApt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnEditApt.Location = new System.Drawing.Point(135, 8);
            this.btnEditApt.Name = "btnEditApt";
            this.btnEditApt.Size = new System.Drawing.Size(115, 30);
            this.btnEditApt.TabIndex = 1;
            this.btnEditApt.Text = "Изменить";
            this.btnEditApt.UseVisualStyleBackColor = false;
            this.btnEditApt.Click += new System.EventHandler(this.btnEditApt_Click);
            // 
            // btnAddApt
            // 
            this.btnAddApt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnAddApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddApt.ForeColor = System.Drawing.Color.White;
            this.btnAddApt.Location = new System.Drawing.Point(10, 8);
            this.btnAddApt.Name = "btnAddApt";
            this.btnAddApt.Size = new System.Drawing.Size(115, 30);
            this.btnAddApt.TabIndex = 0;
            this.btnAddApt.Text = "+ Добавить";
            this.btnAddApt.UseVisualStyleBackColor = false;
            this.btnAddApt.Click += new System.EventHandler(this.btnAddApt_Click);
            // 
            // tabRentals
            // 
            this.tabRentals.Controls.Add(this.dgvRentals);
            this.tabRentals.Controls.Add(this.pnlRentBar);
            this.tabRentals.Location = new System.Drawing.Point(4, 26);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentals.Size = new System.Drawing.Size(851, 568);
            this.tabRentals.TabIndex = 1;
            this.tabRentals.Text = "Договоры аренды";
            this.tabRentals.UseVisualStyleBackColor = true;
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToDeleteRows = false;
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentals.ColumnHeadersHeight = 32;
            this.dgvRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentals.EnableHeadersVisualStyles = false;
            this.dgvRentals.Location = new System.Drawing.Point(3, 49);
            this.dgvRentals.MultiSelect = false;
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.RowTemplate.Height = 26;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(845, 516);
            this.dgvRentals.TabIndex = 2;
            // 
            // pnlRentBar
            // 
            this.pnlRentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlRentBar.Controls.Add(this.btnExportRentals);
            this.pnlRentBar.Controls.Add(this.btnDeleteRental);
            this.pnlRentBar.Controls.Add(this.btnCloseRental);
            this.pnlRentBar.Controls.Add(this.btnNewRental);
            this.pnlRentBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRentBar.Location = new System.Drawing.Point(3, 3);
            this.pnlRentBar.Name = "pnlRentBar";
            this.pnlRentBar.Size = new System.Drawing.Size(845, 46);
            this.pnlRentBar.TabIndex = 1;
            // 
            // btnExportRentals
            // 
            this.btnExportRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportRentals.BackColor = System.Drawing.Color.White;
            this.btnExportRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportRentals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnExportRentals.Location = new System.Drawing.Point(710, 8);
            this.btnExportRentals.Name = "btnExportRentals";
            this.btnExportRentals.Size = new System.Drawing.Size(125, 30);
            this.btnExportRentals.TabIndex = 3;
            this.btnExportRentals.Text = "Экспорт в CSV";
            this.btnExportRentals.UseVisualStyleBackColor = false;
            this.btnExportRentals.Click += new System.EventHandler(this.btnExportRentals_Click);
            // 
            // btnDeleteRental
            // 
            this.btnDeleteRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRental.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRental.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRental.Location = new System.Drawing.Point(335, 8);
            this.btnDeleteRental.Name = "btnDeleteRental";
            this.btnDeleteRental.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteRental.TabIndex = 2;
            this.btnDeleteRental.Text = "Удалить";
            this.btnDeleteRental.UseVisualStyleBackColor = false;
            this.btnDeleteRental.Click += new System.EventHandler(this.btnDeleteRental_Click);
            // 
            // btnCloseRental
            // 
            this.btnCloseRental.BackColor = System.Drawing.Color.White;
            this.btnCloseRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRental.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnCloseRental.Location = new System.Drawing.Point(170, 8);
            this.btnCloseRental.Name = "btnCloseRental";
            this.btnCloseRental.Size = new System.Drawing.Size(155, 30);
            this.btnCloseRental.TabIndex = 1;
            this.btnCloseRental.Text = "Завершить аренду";
            this.btnCloseRental.UseVisualStyleBackColor = false;
            this.btnCloseRental.Click += new System.EventHandler(this.btnCloseRental_Click);
            // 
            // btnNewRental
            // 
            this.btnNewRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(60)))));
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewRental.ForeColor = System.Drawing.Color.White;
            this.btnNewRental.Location = new System.Drawing.Point(10, 8);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(150, 30);
            this.btnNewRental.TabIndex = 0;
            this.btnNewRental.Text = "+ Новый договор";
            this.btnNewRental.UseVisualStyleBackColor = false;
            this.btnNewRental.Click += new System.EventHandler(this.btnRentApt_Click);
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.dgvClients);
            this.tabClients.Controls.Add(this.pnlClientBar);
            this.tabClients.Location = new System.Drawing.Point(4, 26);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(851, 568);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "База клиентов";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.ColumnHeadersHeight = 32;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.Location = new System.Drawing.Point(3, 49);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowTemplate.Height = 26;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(845, 516);
            this.dgvClients.TabIndex = 3;
            // 
            // pnlClientBar
            // 
            this.pnlClientBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlClientBar.Controls.Add(this.btnDeleteClient);
            this.pnlClientBar.Controls.Add(this.btnEditClient);
            this.pnlClientBar.Controls.Add(this.btnAddClient);
            this.pnlClientBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientBar.Location = new System.Drawing.Point(3, 3);
            this.pnlClientBar.Name = "pnlClientBar";
            this.pnlClientBar.Size = new System.Drawing.Size(845, 46);
            this.pnlClientBar.TabIndex = 2;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Location = new System.Drawing.Point(260, 8);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.Text = "Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.White;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnEditClient.Location = new System.Drawing.Point(135, 8);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(115, 30);
            this.btnEditClient.TabIndex = 1;
            this.btnEditClient.Text = "Изменить";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(10, 8);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(115, 30);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "+ Добавить";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tabExperiment
            // 
            this.tabExperiment.Controls.Add(this.pnlExpBottom);
            this.tabExperiment.Controls.Add(this.dgvExperiment);
            this.tabExperiment.Controls.Add(this.pnlExpTop);
            this.tabExperiment.Location = new System.Drawing.Point(4, 26);
            this.tabExperiment.Name = "tabExperiment";
            this.tabExperiment.Padding = new System.Windows.Forms.Padding(8);
            this.tabExperiment.Size = new System.Drawing.Size(851, 568);
            this.tabExperiment.TabIndex = 3;
            this.tabExperiment.Text = "Вычислительный эксперимент (ROI)";
            this.tabExperiment.UseVisualStyleBackColor = true;
            // 
            // pnlExpBottom
            // 
            this.pnlExpBottom.Controls.Add(this.txtExpConclusion);
            this.pnlExpBottom.Controls.Add(this.lblExpConclusion);
            this.pnlExpBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExpBottom.Location = new System.Drawing.Point(8, 410);
            this.pnlExpBottom.Name = "pnlExpBottom";
            this.pnlExpBottom.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnlExpBottom.Size = new System.Drawing.Size(835, 150);
            this.pnlExpBottom.TabIndex = 2;
            // 
            // txtExpConclusion
            // 
            this.txtExpConclusion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.txtExpConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpConclusion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtExpConclusion.Location = new System.Drawing.Point(0, 26);
            this.txtExpConclusion.Multiline = true;
            this.txtExpConclusion.Name = "txtExpConclusion";
            this.txtExpConclusion.ReadOnly = true;
            this.txtExpConclusion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExpConclusion.Size = new System.Drawing.Size(835, 124);
            this.txtExpConclusion.TabIndex = 1;
            // 
            // lblExpConclusion
            // 
            this.lblExpConclusion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpConclusion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpConclusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblExpConclusion.Location = new System.Drawing.Point(0, 4);
            this.lblExpConclusion.Name = "lblExpConclusion";
            this.lblExpConclusion.Size = new System.Drawing.Size(835, 22);
            this.lblExpConclusion.TabIndex = 0;
            this.lblExpConclusion.Text = "Аналитическое заключение по окупаемости и рентабельности инвестиций в аренду:";
            // 
            // dgvExperiment
            // 
            this.dgvExperiment.AllowUserToAddRows = false;
            this.dgvExperiment.AllowUserToDeleteRows = false;
            this.dgvExperiment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExperiment.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExperiment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExperiment.ColumnHeadersHeight = 32;
            this.dgvExperiment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExperiment.EnableHeadersVisualStyles = false;
            this.dgvExperiment.Location = new System.Drawing.Point(8, 92);
            this.dgvExperiment.MultiSelect = false;
            this.dgvExperiment.Name = "dgvExperiment";
            this.dgvExperiment.ReadOnly = true;
            this.dgvExperiment.RowHeadersVisible = false;
            this.dgvExperiment.RowTemplate.Height = 26;
            this.dgvExperiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExperiment.Size = new System.Drawing.Size(835, 468);
            this.dgvExperiment.TabIndex = 1;
            // 
            // pnlExpTop
            // 
            this.pnlExpTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlExpTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpTop.Controls.Add(this.btnRunExperiment);
            this.pnlExpTop.Controls.Add(this.numSqMeterCost);
            this.pnlExpTop.Controls.Add(this.lblSqMeterCost);
            this.pnlExpTop.Controls.Add(this.numTaxRate);
            this.pnlExpTop.Controls.Add(this.lblTaxRate);
            this.pnlExpTop.Controls.Add(this.numExpExpenses);
            this.pnlExpTop.Controls.Add(this.lblExpExpenses);
            this.pnlExpTop.Controls.Add(this.cmbExpPeriod);
            this.pnlExpTop.Controls.Add(this.lblExpPeriod);
            this.pnlExpTop.Controls.Add(this.lblExpDesc);
            this.pnlExpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpTop.Location = new System.Drawing.Point(8, 8);
            this.pnlExpTop.Name = "pnlExpTop";
            this.pnlExpTop.Size = new System.Drawing.Size(835, 84);
            this.pnlExpTop.TabIndex = 0;
            // 
            // btnRunExperiment
            // 
            this.btnRunExperiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnRunExperiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunExperiment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRunExperiment.ForeColor = System.Drawing.Color.White;
            this.btnRunExperiment.Location = new System.Drawing.Point(675, 38);
            this.btnRunExperiment.Name = "btnRunExperiment";
            this.btnRunExperiment.Size = new System.Drawing.Size(145, 32);
            this.btnRunExperiment.TabIndex = 9;
            this.btnRunExperiment.Text = "Рассчитать ROI";
            this.btnRunExperiment.UseVisualStyleBackColor = false;
            this.btnRunExperiment.Click += new System.EventHandler(this.btnRunExperiment_Click);
            // 
            // numSqMeterCost
            // 
            this.numSqMeterCost.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSqMeterCost.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            this.numSqMeterCost.Location = new System.Drawing.Point(535, 44);
            this.numSqMeterCost.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            this.numSqMeterCost.Minimum = new decimal(new int[] { 30000, 0, 0, 0 });
            this.numSqMeterCost.Name = "numSqMeterCost";
            this.numSqMeterCost.Size = new System.Drawing.Size(125, 24);
            this.numSqMeterCost.TabIndex = 8;
            this.numSqMeterCost.Value = new decimal(new int[] { 110000, 0, 0, 0 });
            // 
            // lblSqMeterCost
            // 
            this.lblSqMeterCost.AutoSize = true;
            this.lblSqMeterCost.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSqMeterCost.Location = new System.Drawing.Point(532, 26);
            this.lblSqMeterCost.Name = "lblSqMeterCost";
            this.lblSqMeterCost.Size = new System.Drawing.Size(127, 15);
            this.lblSqMeterCost.TabIndex = 7;
            this.lblSqMeterCost.Text = "Цена м² покупки (руб):";
            // 
            // numTaxRate
            // 
            this.numTaxRate.DecimalPlaces = 1;
            this.numTaxRate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numTaxRate.Location = new System.Drawing.Point(405, 44);
            this.numTaxRate.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numTaxRate.Name = "numTaxRate";
            this.numTaxRate.Size = new System.Drawing.Size(105, 24);
            this.numTaxRate.TabIndex = 6;
            this.numTaxRate.Value = new decimal(new int[] { 60, 0, 0, 65536 });
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTaxRate.Location = new System.Drawing.Point(402, 26);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(105, 15);
            this.lblTaxRate.TabIndex = 5;
            this.lblTaxRate.Text = "Налог/сервис (%):";
            // 
            // numExpExpenses
            // 
            this.numExpExpenses.DecimalPlaces = 1;
            this.numExpExpenses.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numExpExpenses.Location = new System.Drawing.Point(265, 44);
            this.numExpExpenses.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numExpExpenses.Name = "numExpExpenses";
            this.numExpExpenses.Size = new System.Drawing.Size(115, 24);
            this.numExpExpenses.TabIndex = 4;
            this.numExpExpenses.Value = new decimal(new int[] { 150, 0, 0, 65536 });
            // 
            // lblExpExpenses
            // 
            this.lblExpExpenses.AutoSize = true;
            this.lblExpExpenses.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblExpExpenses.Location = new System.Drawing.Point(262, 26);
            this.lblExpExpenses.Name = "lblExpExpenses";
            this.lblExpExpenses.Size = new System.Drawing.Size(114, 15);
            this.lblExpExpenses.TabIndex = 3;
            this.lblExpExpenses.Text = "Амортизация/ЖКХ:";
            // 
            // cmbExpPeriod
            // 
            this.cmbExpPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpPeriod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbExpPeriod.FormattingEnabled = true;
            this.cmbExpPeriod.Items.AddRange(new object[] {
            "Текущий месяц (30 дн.)",
            "Квартал (90 дн.)",
            "Годовой срез (365 дн.)"});
            this.cmbExpPeriod.Location = new System.Drawing.Point(12, 44);
            this.cmbExpPeriod.Name = "cmbExpPeriod";
            this.cmbExpPeriod.Size = new System.Drawing.Size(230, 25);
            this.cmbExpPeriod.TabIndex = 2;
            // 
            // lblExpPeriod
            // 
            this.lblExpPeriod.AutoSize = true;
            this.lblExpPeriod.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblExpPeriod.Location = new System.Drawing.Point(12, 26);
            this.lblExpPeriod.Name = "lblExpPeriod";
            this.lblExpPeriod.Size = new System.Drawing.Size(102, 15);
            this.lblExpPeriod.TabIndex = 1;
            this.lblExpPeriod.Text = "Период расчетов:";
            // 
            // lblExpDesc
            // 
            this.lblExpDesc.AutoSize = true;
            this.lblExpDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblExpDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblExpDesc.Location = new System.Drawing.Point(10, 5);
            this.lblExpDesc.Name = "lblExpDesc";
            this.lblExpDesc.Size = new System.Drawing.Size(657, 17);
            this.lblExpDesc.TabIndex = 0;
            this.lblExpDesc.Text = "Математическая модель оценки доходности (NOI), коэффициента загрузки (Occupancy) " +
    "и окупаемости (Cap Rate)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления арендой квартир | v2.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCards.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFilterMaxPrice)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabApartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).EndInit();
            this.pnlAptBar.ResumeLayout(false);
            this.tabRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.pnlRentBar.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.pnlClientBar.ResumeLayout(false);
            this.tabExperiment.ResumeLayout(false);
            this.pnlExpBottom.ResumeLayout(false);
            this.pnlExpBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperiment)).EndInit();
            this.pnlExpTop.ResumeLayout(false);
            this.pnlExpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSqMeterCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Label lblCardTotal;
        private System.Windows.Forms.Label lblCardOccupancy;
        private System.Windows.Forms.Label lblCardRevenue;
        private System.Windows.Forms.Label lblCardCommissions;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblFilterHeader;
        private System.Windows.Forms.Label lblFilterDistrict;
        private System.Windows.Forms.ComboBox cmbFilterDistrict;
        private System.Windows.Forms.Label lblFilterRooms;
        private System.Windows.Forms.ComboBox cmbFilterRooms;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterMaxPrice;
        private System.Windows.Forms.NumericUpDown numFilterMaxPrice;
        private System.Windows.Forms.CheckBox chkFilterBalcony;
        private System.Windows.Forms.CheckBox chkFilterFurniture;
        private System.Windows.Forms.CheckBox chkFilterAppliances;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabApartments;
        private System.Windows.Forms.Panel pnlAptBar;
        private System.Windows.Forms.Button btnAddApt;
        private System.Windows.Forms.Button btnEditApt;
        private System.Windows.Forms.Button btnDeleteApt;
        private System.Windows.Forms.Button btnRentApt;
        private System.Windows.Forms.Button btnExportApartments;
        private System.Windows.Forms.DataGridView dgvApartments;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.Panel pnlRentBar;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.Button btnCloseRental;
        private System.Windows.Forms.Button btnDeleteRental;
        private System.Windows.Forms.Button btnExportRentals;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.Panel pnlClientBar;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TabPage tabExperiment;
        private System.Windows.Forms.Panel pnlExpTop;
        private System.Windows.Forms.Label lblExpDesc;
        private System.Windows.Forms.Label lblExpPeriod;
        private System.Windows.Forms.ComboBox cmbExpPeriod;
        private System.Windows.Forms.Label lblExpExpenses;
        private System.Windows.Forms.NumericUpDown numExpExpenses;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.NumericUpDown numTaxRate;
        private System.Windows.Forms.Label lblSqMeterCost;
        private System.Windows.Forms.NumericUpDown numSqMeterCost;
        private System.Windows.Forms.Button btnRunExperiment;
        private System.Windows.Forms.DataGridView dgvExperiment;
        private System.Windows.Forms.Panel pnlExpBottom;
        private System.Windows.Forms.Label lblExpConclusion;
        private System.Windows.Forms.TextBox txtExpConclusion;
    }
}
