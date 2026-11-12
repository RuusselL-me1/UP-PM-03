namespace ApartmentRental_v1
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.lblCardRevenue = new System.Windows.Forms.Label();
            this.lblCardRented = new System.Windows.Forms.Label();
            this.lblCardFree = new System.Windows.Forms.Label();
            this.lblCardTotal = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cmbFilterRooms = new System.Windows.Forms.ComboBox();
            this.lblFilterRooms = new System.Windows.Forms.Label();
            this.cmbFilterDistrict = new System.Windows.Forms.ComboBox();
            this.lblFilterDistrict = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabApartments = new System.Windows.Forms.TabPage();
            this.dgvApartments = new System.Windows.Forms.DataGridView();
            this.pnlAptToolbar = new System.Windows.Forms.Panel();
            this.btnRentApartment = new System.Windows.Forms.Button();
            this.btnDeleteApartment = new System.Windows.Forms.Button();
            this.btnEditApartment = new System.Windows.Forms.Button();
            this.btnAddApartment = new System.Windows.Forms.Button();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.pnlRentToolbar = new System.Windows.Forms.Panel();
            this.btnDeleteRental = new System.Windows.Forms.Button();
            this.btnCloseRental = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.dgvDistrictSummary = new System.Windows.Forms.DataGridView();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.tabApartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).BeginInit();
            this.pnlAptToolbar.SuspendLayout();
            this.tabRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.pnlRentToolbar.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistrictSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblAppTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 65);
            this.pnlHeader.TabIndex = 0;
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
            this.lblSubTitle.Text = "Информационная система управления арендой квартир | Редакция 1.0";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(16, 8);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(420, 28);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Агентство недвижимости «Городской Квартал»";
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.White;
            this.pnlCards.Controls.Add(this.lblCardRevenue);
            this.pnlCards.Controls.Add(this.lblCardRented);
            this.pnlCards.Controls.Add(this.lblCardFree);
            this.pnlCards.Controls.Add(this.lblCardTotal);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 65);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1008, 45);
            this.pnlCards.TabIndex = 1;
            // 
            // lblCardRevenue
            // 
            this.lblCardRevenue.AutoSize = true;
            this.lblCardRevenue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblCardRevenue.Location = new System.Drawing.Point(540, 14);
            this.lblCardRevenue.Name = "lblCardRevenue";
            this.lblCardRevenue.Size = new System.Drawing.Size(207, 17);
            this.lblCardRevenue.TabIndex = 3;
            this.lblCardRevenue.Text = "Выручка от договоров: 0 руб.";
            // 
            // lblCardRented
            // 
            this.lblCardRented.AutoSize = true;
            this.lblCardRented.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardRented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(90)))), ((int)(((byte)(20)))));
            this.lblCardRented.Location = new System.Drawing.Point(360, 14);
            this.lblCardRented.Name = "lblCardRented";
            this.lblCardRented.Size = new System.Drawing.Size(84, 17);
            this.lblCardRented.TabIndex = 2;
            this.lblCardRented.Text = "Сдано: 0 шт.";
            // 
            // lblCardFree
            // 
            this.lblCardFree.AutoSize = true;
            this.lblCardFree.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardFree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(60)))));
            this.lblCardFree.Location = new System.Drawing.Point(180, 14);
            this.lblCardFree.Name = "lblCardFree";
            this.lblCardFree.Size = new System.Drawing.Size(101, 17);
            this.lblCardFree.TabIndex = 1;
            this.lblCardFree.Text = "Свободно: 0 шт.";
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
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlSidebar.Controls.Add(this.btnResetFilters);
            this.pnlSidebar.Controls.Add(this.txtSearch);
            this.pnlSidebar.Controls.Add(this.lblSearch);
            this.pnlSidebar.Controls.Add(this.cmbFilterStatus);
            this.pnlSidebar.Controls.Add(this.lblFilterStatus);
            this.pnlSidebar.Controls.Add(this.cmbFilterRooms);
            this.pnlSidebar.Controls.Add(this.lblFilterRooms);
            this.pnlSidebar.Controls.Add(this.cmbFilterDistrict);
            this.pnlSidebar.Controls.Add(this.lblFilterDistrict);
            this.pnlSidebar.Controls.Add(this.lblFilterTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 110);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 571);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.White;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnResetFilters.Location = new System.Drawing.Point(15, 290);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(190, 28);
            this.btnResetFilters.TabIndex = 9;
            this.btnResetFilters.Text = "Сбросить фильтры";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(15, 245);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 24);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(15, 225);
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
            this.cmbFilterStatus.Location = new System.Drawing.Point(15, 185);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(190, 25);
            this.cmbFilterStatus.TabIndex = 6;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 165);
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
            "Все варианты",
            "1 комната",
            "2 комнаты",
            "3 комнаты",
            "4+ комнат"});
            this.cmbFilterRooms.Location = new System.Drawing.Point(15, 125);
            this.cmbFilterRooms.Name = "cmbFilterRooms";
            this.cmbFilterRooms.Size = new System.Drawing.Size(190, 25);
            this.cmbFilterRooms.TabIndex = 4;
            this.cmbFilterRooms.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblFilterRooms
            // 
            this.lblFilterRooms.AutoSize = true;
            this.lblFilterRooms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterRooms.Location = new System.Drawing.Point(15, 105);
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
            this.cmbFilterDistrict.Location = new System.Drawing.Point(15, 65);
            this.cmbFilterDistrict.Name = "cmbFilterDistrict";
            this.cmbFilterDistrict.Size = new System.Drawing.Size(190, 25);
            this.cmbFilterDistrict.TabIndex = 2;
            this.cmbFilterDistrict.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblFilterDistrict
            // 
            this.lblFilterDistrict.AutoSize = true;
            this.lblFilterDistrict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterDistrict.Location = new System.Drawing.Point(15, 45);
            this.lblFilterDistrict.Name = "lblFilterDistrict";
            this.lblFilterDistrict.Size = new System.Drawing.Size(86, 15);
            this.lblFilterDistrict.TabIndex = 1;
            this.lblFilterDistrict.Text = "Район города:";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(147, 20);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Фильтры каталога";
            // 
            // tabContent
            // 
            this.tabContent.Controls.Add(this.tabApartments);
            this.tabContent.Controls.Add(this.tabRentals);
            this.tabContent.Controls.Add(this.tabSummary);
            this.tabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabContent.Location = new System.Drawing.Point(220, 110);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(788, 571);
            this.tabContent.TabIndex = 3;
            this.tabContent.SelectedIndexChanged += new System.EventHandler(this.tabContent_SelectedIndexChanged);
            // 
            // tabApartments
            // 
            this.tabApartments.Controls.Add(this.dgvApartments);
            this.tabApartments.Controls.Add(this.pnlAptToolbar);
            this.tabApartments.Location = new System.Drawing.Point(4, 26);
            this.tabApartments.Name = "tabApartments";
            this.tabApartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabApartments.Size = new System.Drawing.Size(780, 541);
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
            this.dgvApartments.Size = new System.Drawing.Size(774, 489);
            this.dgvApartments.TabIndex = 1;
            // 
            // pnlAptToolbar
            // 
            this.pnlAptToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlAptToolbar.Controls.Add(this.btnRentApartment);
            this.pnlAptToolbar.Controls.Add(this.btnDeleteApartment);
            this.pnlAptToolbar.Controls.Add(this.btnEditApartment);
            this.pnlAptToolbar.Controls.Add(this.btnAddApartment);
            this.pnlAptToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAptToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlAptToolbar.Name = "pnlAptToolbar";
            this.pnlAptToolbar.Size = new System.Drawing.Size(774, 46);
            this.pnlAptToolbar.TabIndex = 0;
            // 
            // btnRentApartment
            // 
            this.btnRentApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(60)))));
            this.btnRentApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentApartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRentApartment.ForeColor = System.Drawing.Color.White;
            this.btnRentApartment.Location = new System.Drawing.Point(415, 8);
            this.btnRentApartment.Name = "btnRentApartment";
            this.btnRentApartment.Size = new System.Drawing.Size(160, 30);
            this.btnRentApartment.TabIndex = 3;
            this.btnRentApartment.Text = "Оформить аренду";
            this.btnRentApartment.UseVisualStyleBackColor = false;
            this.btnRentApartment.Click += new System.EventHandler(this.btnRentApartment_Click);
            // 
            // btnDeleteApartment
            // 
            this.btnDeleteApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteApartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteApartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApartment.Location = new System.Drawing.Point(265, 8);
            this.btnDeleteApartment.Name = "btnDeleteApartment";
            this.btnDeleteApartment.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteApartment.TabIndex = 2;
            this.btnDeleteApartment.Text = "Удалить";
            this.btnDeleteApartment.UseVisualStyleBackColor = false;
            this.btnDeleteApartment.Click += new System.EventHandler(this.btnDeleteApartment_Click);
            // 
            // btnEditApartment
            // 
            this.btnEditApartment.BackColor = System.Drawing.Color.White;
            this.btnEditApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditApartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditApartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnEditApartment.Location = new System.Drawing.Point(140, 8);
            this.btnEditApartment.Name = "btnEditApartment";
            this.btnEditApartment.Size = new System.Drawing.Size(115, 30);
            this.btnEditApartment.TabIndex = 1;
            this.btnEditApartment.Text = "Изменить";
            this.btnEditApartment.UseVisualStyleBackColor = false;
            this.btnEditApartment.Click += new System.EventHandler(this.btnEditApartment_Click);
            // 
            // btnAddApartment
            // 
            this.btnAddApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.btnAddApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddApartment.ForeColor = System.Drawing.Color.White;
            this.btnAddApartment.Location = new System.Drawing.Point(10, 8);
            this.btnAddApartment.Name = "btnAddApartment";
            this.btnAddApartment.Size = new System.Drawing.Size(120, 30);
            this.btnAddApartment.TabIndex = 0;
            this.btnAddApartment.Text = "+ Добавить";
            this.btnAddApartment.UseVisualStyleBackColor = false;
            this.btnAddApartment.Click += new System.EventHandler(this.btnAddApartment_Click);
            // 
            // tabRentals
            // 
            this.tabRentals.Controls.Add(this.dgvRentals);
            this.tabRentals.Controls.Add(this.pnlRentToolbar);
            this.tabRentals.Location = new System.Drawing.Point(4, 26);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentals.Size = new System.Drawing.Size(780, 541);
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
            this.dgvRentals.Size = new System.Drawing.Size(774, 489);
            this.dgvRentals.TabIndex = 2;
            // 
            // pnlRentToolbar
            // 
            this.pnlRentToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlRentToolbar.Controls.Add(this.btnDeleteRental);
            this.pnlRentToolbar.Controls.Add(this.btnCloseRental);
            this.pnlRentToolbar.Controls.Add(this.btnNewRental);
            this.pnlRentToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRentToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlRentToolbar.Name = "pnlRentToolbar";
            this.pnlRentToolbar.Size = new System.Drawing.Size(774, 46);
            this.pnlRentToolbar.TabIndex = 1;
            // 
            // btnDeleteRental
            // 
            this.btnDeleteRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRental.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRental.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRental.Location = new System.Drawing.Point(340, 8);
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
            this.btnCloseRental.Location = new System.Drawing.Point(175, 8);
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
            this.btnNewRental.Size = new System.Drawing.Size(155, 30);
            this.btnNewRental.TabIndex = 0;
            this.btnNewRental.Text = "+ Новый договор";
            this.btnNewRental.UseVisualStyleBackColor = false;
            this.btnNewRental.Click += new System.EventHandler(this.btnRentApartment_Click);
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.dgvDistrictSummary);
            this.tabSummary.Controls.Add(this.lblSummaryTitle);
            this.tabSummary.Location = new System.Drawing.Point(4, 26);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(12);
            this.tabSummary.Size = new System.Drawing.Size(780, 541);
            this.tabSummary.TabIndex = 2;
            this.tabSummary.Text = "Сводка по районам";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // dgvDistrictSummary
            // 
            this.dgvDistrictSummary.AllowUserToAddRows = false;
            this.dgvDistrictSummary.AllowUserToDeleteRows = false;
            this.dgvDistrictSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDistrictSummary.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistrictSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDistrictSummary.ColumnHeadersHeight = 32;
            this.dgvDistrictSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDistrictSummary.EnableHeadersVisualStyles = false;
            this.dgvDistrictSummary.Location = new System.Drawing.Point(12, 42);
            this.dgvDistrictSummary.MultiSelect = false;
            this.dgvDistrictSummary.Name = "dgvDistrictSummary";
            this.dgvDistrictSummary.ReadOnly = true;
            this.dgvDistrictSummary.RowHeadersVisible = false;
            this.dgvDistrictSummary.RowTemplate.Height = 28;
            this.dgvDistrictSummary.Size = new System.Drawing.Size(756, 487);
            this.dgvDistrictSummary.TabIndex = 1;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(12, 12);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(756, 30);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Показатели арендного фонда в разрезе районов города";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tabContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет аренды квартир | Редакция 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCards.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.tabContent.ResumeLayout(false);
            this.tabApartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).EndInit();
            this.pnlAptToolbar.ResumeLayout(false);
            this.tabRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.pnlRentToolbar.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistrictSummary)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Label lblCardTotal;
        private System.Windows.Forms.Label lblCardFree;
        private System.Windows.Forms.Label lblCardRented;
        private System.Windows.Forms.Label lblCardRevenue;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblFilterDistrict;
        private System.Windows.Forms.ComboBox cmbFilterDistrict;
        private System.Windows.Forms.Label lblFilterRooms;
        private System.Windows.Forms.ComboBox cmbFilterRooms;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.TabControl tabContent;
        private System.Windows.Forms.TabPage tabApartments;
        private System.Windows.Forms.Panel pnlAptToolbar;
        private System.Windows.Forms.Button btnAddApartment;
        private System.Windows.Forms.Button btnEditApartment;
        private System.Windows.Forms.Button btnDeleteApartment;
        private System.Windows.Forms.Button btnRentApartment;
        private System.Windows.Forms.DataGridView dgvApartments;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.Panel pnlRentToolbar;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.Button btnCloseRental;
        private System.Windows.Forms.Button btnDeleteRental;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.DataGridView dgvDistrictSummary;
    }
}
