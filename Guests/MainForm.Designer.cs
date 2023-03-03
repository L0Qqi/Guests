namespace Guests
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAMPM = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHeadingStatus = new System.Windows.Forms.Label();
            this.labelHeadingGuests = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.rBLeave = new System.Windows.Forms.RadioButton();
            this.rBEmployed = new System.Windows.Forms.RadioButton();
            this.rBFree = new System.Windows.Forms.RadioButton();
            this.rBReserved = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ClientsList = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBDateOfLeaving = new System.Windows.Forms.GroupBox();
            this.DateOfLeaving = new System.Windows.Forms.Label();
            this.gBDateOfEnter = new System.Windows.Forms.GroupBox();
            this.DateOfEnter = new System.Windows.Forms.Label();
            this.stLabel = new System.Windows.Forms.Label();
            this.buttonCardOpen = new System.Windows.Forms.Button();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pictureOfClient = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsList)).BeginInit();
            this.gBDateOfLeaving.SuspendLayout();
            this.gBDateOfEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearch.Image = global::Guests.Properties.Resources._211817_search_strong_icon;
            this.pictureBoxSearch.Location = new System.Drawing.Point(964, 3);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(53, 52);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 3;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(377, 3);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(581, 52);
            this.textBoxSearch.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelAMPM);
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(19, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 52);
            this.panel3.TabIndex = 1;
            // 
            // labelAMPM
            // 
            this.labelAMPM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAMPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAMPM.Location = new System.Drawing.Point(264, 0);
            this.labelAMPM.Name = "labelAMPM";
            this.labelAMPM.Size = new System.Drawing.Size(76, 52);
            this.labelAMPM.TabIndex = 1;
            this.labelAMPM.Text = "XX";
            this.labelAMPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(268, 52);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "HH:MM:SS";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelHeadingStatus
            // 
            this.labelHeadingStatus.AutoSize = true;
            this.labelHeadingStatus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeadingStatus.Location = new System.Drawing.Point(12, 3);
            this.labelHeadingStatus.Name = "labelHeadingStatus";
            this.labelHeadingStatus.Size = new System.Drawing.Size(95, 31);
            this.labelHeadingStatus.TabIndex = 7;
            this.labelHeadingStatus.Text = "Статус";
            this.labelHeadingStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelHeadingGuests
            // 
            this.labelHeadingGuests.AutoSize = true;
            this.labelHeadingGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelHeadingGuests.Location = new System.Drawing.Point(3, 3);
            this.labelHeadingGuests.Name = "labelHeadingGuests";
            this.labelHeadingGuests.Size = new System.Drawing.Size(208, 31);
            this.labelHeadingGuests.TabIndex = 8;
            this.labelHeadingGuests.Text = "Список гостей";
            this.labelHeadingGuests.Click += new System.EventHandler(this.label2_Click);
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.roomNumberLabel.Location = new System.Drawing.Point(3, 3);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(139, 31);
            this.roomNumberLabel.TabIndex = 9;
            this.roomNumberLabel.Text = "Номер №";
            this.roomNumberLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 509);
            this.panel2.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonAll);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExit);
            this.splitContainer1.Panel1.Controls.Add(this.rBLeave);
            this.splitContainer1.Panel1.Controls.Add(this.rBEmployed);
            this.splitContainer1.Panel1.Controls.Add(this.rBFree);
            this.splitContainer1.Panel1.Controls.Add(this.rBReserved);
            this.splitContainer1.Panel1.Controls.Add(this.labelHeadingStatus);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1077, 509);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 0;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(18, 129);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAll.TabIndex = 16;
            this.radioButtonAll.Text = "Все";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Location = new System.Drawing.Point(18, 464);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 32);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // rBLeave
            // 
            this.rBLeave.AutoSize = true;
            this.rBLeave.Location = new System.Drawing.Point(18, 106);
            this.rBLeave.Name = "rBLeave";
            this.rBLeave.Size = new System.Drawing.Size(103, 17);
            this.rBLeave.TabIndex = 15;
            this.rBLeave.Text = "Выписываются";
            this.rBLeave.UseVisualStyleBackColor = true;
            this.rBLeave.CheckedChanged += new System.EventHandler(this.rBLeave_CheckedChanged);
            // 
            // rBEmployed
            // 
            this.rBEmployed.AutoSize = true;
            this.rBEmployed.Location = new System.Drawing.Point(18, 83);
            this.rBEmployed.Name = "rBEmployed";
            this.rBEmployed.Size = new System.Drawing.Size(63, 17);
            this.rBEmployed.TabIndex = 14;
            this.rBEmployed.Text = "Заняты";
            this.rBEmployed.UseVisualStyleBackColor = true;
            this.rBEmployed.CheckedChanged += new System.EventHandler(this.rBEmployed_CheckedChanged);
            // 
            // rBFree
            // 
            this.rBFree.AutoSize = true;
            this.rBFree.Location = new System.Drawing.Point(18, 60);
            this.rBFree.Name = "rBFree";
            this.rBFree.Size = new System.Drawing.Size(82, 17);
            this.rBFree.TabIndex = 13;
            this.rBFree.Text = "Свободные";
            this.rBFree.UseVisualStyleBackColor = true;
            this.rBFree.CheckedChanged += new System.EventHandler(this.rBFree_CheckedChanged);
            // 
            // rBReserved
            // 
            this.rBReserved.AutoSize = true;
            this.rBReserved.Location = new System.Drawing.Point(18, 37);
            this.rBReserved.Name = "rBReserved";
            this.rBReserved.Size = new System.Drawing.Size(116, 17);
            this.rBReserved.TabIndex = 12;
            this.rBReserved.Text = "Зарезервировано";
            this.rBReserved.UseVisualStyleBackColor = true;
            this.rBReserved.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ClientsList);
            this.splitContainer2.Panel1.Controls.Add(this.labelHeadingGuests);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gBDateOfLeaving);
            this.splitContainer2.Panel2.Controls.Add(this.gBDateOfEnter);
            this.splitContainer2.Panel2.Controls.Add(this.stLabel);
            this.splitContainer2.Panel2.Controls.Add(this.buttonCardOpen);
            this.splitContainer2.Panel2.Controls.Add(this.FullNameLabel);
            this.splitContainer2.Panel2.Controls.Add(this.statusLabel);
            this.splitContainer2.Panel2.Controls.Add(this.pictureOfClient);
            this.splitContainer2.Panel2.Controls.Add(this.roomNumberLabel);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(831, 509);
            this.splitContainer2.SplitterDistance = 410;
            this.splitContainer2.TabIndex = 0;
            // 
            // ClientsList
            // 
            this.ClientsList.AllowUserToAddRows = false;
            this.ClientsList.AllowUserToDeleteRows = false;
            this.ClientsList.AllowUserToResizeColumns = false;
            this.ClientsList.AllowUserToResizeRows = false;
            this.ClientsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.Status,
            this.Room});
            this.ClientsList.Location = new System.Drawing.Point(9, 37);
            this.ClientsList.Name = "ClientsList";
            this.ClientsList.ReadOnly = true;
            this.ClientsList.RowHeadersVisible = false;
            this.ClientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsList.Size = new System.Drawing.Size(313, 433);
            this.ClientsList.TabIndex = 9;
            this.ClientsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsList_CellContentClick);
            this.ClientsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsList_CellContentDoubleClick);
            this.ClientsList.DoubleClick += new System.EventHandler(this.ClientsList_DoubleClick);
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Имя";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 140;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 120;
            // 
            // Room
            // 
            this.Room.HeaderText = "Номер";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 50;
            // 
            // gBDateOfLeaving
            // 
            this.gBDateOfLeaving.Controls.Add(this.DateOfLeaving);
            this.gBDateOfLeaving.Location = new System.Drawing.Point(20, 355);
            this.gBDateOfLeaving.Name = "gBDateOfLeaving";
            this.gBDateOfLeaving.Size = new System.Drawing.Size(254, 43);
            this.gBDateOfLeaving.TabIndex = 20;
            this.gBDateOfLeaving.TabStop = false;
            this.gBDateOfLeaving.Text = "Дата выезда:";
            this.gBDateOfLeaving.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DateOfLeaving
            // 
            this.DateOfLeaving.AutoSize = true;
            this.DateOfLeaving.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfLeaving.Location = new System.Drawing.Point(6, 16);
            this.DateOfLeaving.Name = "DateOfLeaving";
            this.DateOfLeaving.Size = new System.Drawing.Size(82, 21);
            this.DateOfLeaving.TabIndex = 0;
            this.DateOfLeaving.Text = "hh:mm:ss";
            this.DateOfLeaving.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // gBDateOfEnter
            // 
            this.gBDateOfEnter.Controls.Add(this.DateOfEnter);
            this.gBDateOfEnter.Location = new System.Drawing.Point(20, 290);
            this.gBDateOfEnter.Name = "gBDateOfEnter";
            this.gBDateOfEnter.Size = new System.Drawing.Size(254, 43);
            this.gBDateOfEnter.TabIndex = 19;
            this.gBDateOfEnter.TabStop = false;
            this.gBDateOfEnter.Text = "Дата заезда:";
            this.gBDateOfEnter.Enter += new System.EventHandler(this.GBDateOfEnter_Enter);
            // 
            // DateOfEnter
            // 
            this.DateOfEnter.AutoSize = true;
            this.DateOfEnter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfEnter.Location = new System.Drawing.Point(6, 16);
            this.DateOfEnter.Name = "DateOfEnter";
            this.DateOfEnter.Size = new System.Drawing.Size(82, 21);
            this.DateOfEnter.TabIndex = 0;
            this.DateOfEnter.Text = "hh:mm:ss";
            this.DateOfEnter.Click += new System.EventHandler(this.DateOfEnter_Click);
            // 
            // stLabel
            // 
            this.stLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stLabel.Location = new System.Drawing.Point(20, 178);
            this.stLabel.Name = "stLabel";
            this.stLabel.Size = new System.Drawing.Size(88, 37);
            this.stLabel.TabIndex = 18;
            this.stLabel.Text = "Статус";
            this.stLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCardOpen
            // 
            this.buttonCardOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCardOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCardOpen.Location = new System.Drawing.Point(241, 447);
            this.buttonCardOpen.Name = "buttonCardOpen";
            this.buttonCardOpen.Size = new System.Drawing.Size(163, 49);
            this.buttonCardOpen.TabIndex = 17;
            this.buttonCardOpen.Text = "Просмотр карточки";
            this.buttonCardOpen.UseVisualStyleBackColor = true;
            this.buttonCardOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(20, 227);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(336, 41);
            this.FullNameLabel.TabIndex = 12;
            this.FullNameLabel.Text = "ФИО";
            this.FullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(130, 178);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(226, 37);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Статус";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureOfClient
            // 
            this.pictureOfClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureOfClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOfClient.Image = global::Guests.Properties.Resources.comdlpng6950136;
            this.pictureOfClient.Location = new System.Drawing.Point(221, 37);
            this.pictureOfClient.Name = "pictureOfClient";
            this.pictureOfClient.Size = new System.Drawing.Size(135, 118);
            this.pictureOfClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOfClient.TabIndex = 10;
            this.pictureOfClient.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "Гости";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsList)).EndInit();
            this.gBDateOfLeaving.ResumeLayout(false);
            this.gBDateOfLeaving.PerformLayout();
            this.gBDateOfEnter.ResumeLayout(false);
            this.gBDateOfEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeadingStatus;
        private System.Windows.Forms.Label labelHeadingGuests;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RadioButton rBLeave;
        private System.Windows.Forms.RadioButton rBEmployed;
        private System.Windows.Forms.RadioButton rBFree;
        private System.Windows.Forms.RadioButton rBReserved;
        private System.Windows.Forms.PictureBox pictureOfClient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCardOpen;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label labelAMPM;
        private System.Windows.Forms.DataGridView ClientsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.Label stLabel;
        private System.Windows.Forms.GroupBox gBDateOfLeaving;
        private System.Windows.Forms.Label DateOfLeaving;
        private System.Windows.Forms.GroupBox gBDateOfEnter;
        private System.Windows.Forms.Label DateOfEnter;
        private System.Windows.Forms.RadioButton radioButtonAll;
    }
}

