
namespace Client {
    partial class Main {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SubmenuPanel = new System.Windows.Forms.Panel();
            this.addTabPanel = new System.Windows.Forms.Panel();
            this.addTab_cancel = new FontAwesome.Sharp.IconButton();
            this.button_addTab = new FontAwesome.Sharp.IconButton();
            this.Name_label = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.URL_label = new System.Windows.Forms.Label();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.SubPanel = new System.Windows.Forms.Panel();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.devtools = new FontAwesome.Sharp.IconPictureBox();
            this.TabsSwitcher = new FontAwesome.Sharp.IconPictureBox();
            this.NotepadIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ClearCacheButton = new FontAwesome.Sharp.IconPictureBox();
            this.FolderIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Time = new System.Windows.Forms.Label();
            this.NotepadIconButton = new FontAwesome.Sharp.IconPictureBox();
            this.ReferenceIconButton = new FontAwesome.Sharp.IconPictureBox();
            this.ScaleMinusButton = new FontAwesome.Sharp.IconPictureBox();
            this.ScalePlusButton = new FontAwesome.Sharp.IconPictureBox();
            this.ForwardPageButton = new FontAwesome.Sharp.IconPictureBox();
            this.BackPageButton = new FontAwesome.Sharp.IconPictureBox();
            this.ReloadButton = new FontAwesome.Sharp.IconPictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TabsPanel = new System.Windows.Forms.Panel();
            this.server2 = new FontAwesome.Sharp.IconButton();
            this.addTab = new FontAwesome.Sharp.IconPictureBox();
            this.server1 = new FontAwesome.Sharp.IconButton();
            this.DefaultTab = new FontAwesome.Sharp.IconButton();
            this.SubmenuPanel.SuspendLayout();
            this.addTabPanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devtools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabsSwitcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotepadIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCacheButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotepadIconButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceIconButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleMinusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScalePlusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadButton)).BeginInit();
            this.TabsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTab)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmenuPanel
            // 
            this.SubmenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.SubmenuPanel.Controls.Add(this.addTabPanel);
            this.SubmenuPanel.Controls.Add(this.SubPanel);
            this.SubmenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmenuPanel.Location = new System.Drawing.Point(0, 30);
            this.SubmenuPanel.Name = "SubmenuPanel";
            this.SubmenuPanel.Size = new System.Drawing.Size(1526, 628);
            this.SubmenuPanel.TabIndex = 2;
            // 
            // addTabPanel
            // 
            this.addTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.addTabPanel.Controls.Add(this.addTab_cancel);
            this.addTabPanel.Controls.Add(this.button_addTab);
            this.addTabPanel.Controls.Add(this.Name_label);
            this.addTabPanel.Controls.Add(this.tb_Name);
            this.addTabPanel.Controls.Add(this.URL_label);
            this.addTabPanel.Controls.Add(this.tb_URL);
            this.addTabPanel.Location = new System.Drawing.Point(579, 197);
            this.addTabPanel.Name = "addTabPanel";
            this.addTabPanel.Size = new System.Drawing.Size(400, 200);
            this.addTabPanel.TabIndex = 1;
            this.addTabPanel.Visible = false;
            // 
            // addTab_cancel
            // 
            this.addTab_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTab_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addTab_cancel.FlatAppearance.BorderSize = 0;
            this.addTab_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTab_cancel.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.addTab_cancel.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTab_cancel.ForeColor = System.Drawing.Color.Silver;
            this.addTab_cancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.addTab_cancel.IconColor = System.Drawing.Color.Silver;
            this.addTab_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addTab_cancel.IconSize = 15;
            this.addTab_cancel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.addTab_cancel.Location = new System.Drawing.Point(215, 145);
            this.addTab_cancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.addTab_cancel.Name = "addTab_cancel";
            this.addTab_cancel.Size = new System.Drawing.Size(110, 28);
            this.addTab_cancel.TabIndex = 5;
            this.addTab_cancel.Text = "Отменить";
            this.addTab_cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTab_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addTab_cancel.UseVisualStyleBackColor = false;
            this.addTab_cancel.Click += new System.EventHandler(this.addTab_cancel_Click);
            // 
            // button_addTab
            // 
            this.button_addTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addTab.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.button_addTab.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTab.ForeColor = System.Drawing.Color.Black;
            this.button_addTab.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.button_addTab.IconColor = System.Drawing.Color.Black;
            this.button_addTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_addTab.IconSize = 15;
            this.button_addTab.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_addTab.Location = new System.Drawing.Point(81, 146);
            this.button_addTab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button_addTab.Name = "button_addTab";
            this.button_addTab.Size = new System.Drawing.Size(109, 26);
            this.button_addTab.TabIndex = 4;
            this.button_addTab.Text = "Добавить";
            this.button_addTab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_addTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_addTab.UseVisualStyleBackColor = true;
            this.button_addTab.Click += new System.EventHandler(this.button_addTab_Click);
            // 
            // Name_label
            // 
            this.Name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_label.AutoSize = true;
            this.Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Name_label.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Name_label.Location = new System.Drawing.Point(14, 91);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(85, 16);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Имя сервера";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.Color.Black;
            this.tb_Name.Location = new System.Drawing.Point(105, 91);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(274, 23);
            this.tb_Name.TabIndex = 2;
            // 
            // URL_label
            // 
            this.URL_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL_label.AutoSize = true;
            this.URL_label.BackColor = System.Drawing.Color.Transparent;
            this.URL_label.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL_label.ForeColor = System.Drawing.Color.White;
            this.URL_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.URL_label.Location = new System.Drawing.Point(12, 49);
            this.URL_label.Name = "URL_label";
            this.URL_label.Size = new System.Drawing.Size(87, 16);
            this.URL_label.TabIndex = 1;
            this.URL_label.Text = "URL Сервера";
            this.URL_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_URL
            // 
            this.tb_URL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_URL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_URL.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_URL.ForeColor = System.Drawing.Color.Black;
            this.tb_URL.Location = new System.Drawing.Point(105, 49);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(274, 23);
            this.tb_URL.TabIndex = 0;
            this.tb_URL.Text = "https://";
            // 
            // SubPanel
            // 
            this.SubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SubPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SubPanel.Location = new System.Drawing.Point(1213, 0);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(313, 628);
            this.SubPanel.TabIndex = 0;
            this.SubPanel.Visible = false;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.UpperPanel.Controls.Add(this.devtools);
            this.UpperPanel.Controls.Add(this.TabsSwitcher);
            this.UpperPanel.Controls.Add(this.NotepadIcon);
            this.UpperPanel.Controls.Add(this.ClearCacheButton);
            this.UpperPanel.Controls.Add(this.FolderIcon);
            this.UpperPanel.Controls.Add(this.Time);
            this.UpperPanel.Controls.Add(this.NotepadIconButton);
            this.UpperPanel.Controls.Add(this.ReferenceIconButton);
            this.UpperPanel.Controls.Add(this.ScaleMinusButton);
            this.UpperPanel.Controls.Add(this.ScalePlusButton);
            this.UpperPanel.Controls.Add(this.ForwardPageButton);
            this.UpperPanel.Controls.Add(this.BackPageButton);
            this.UpperPanel.Controls.Add(this.ReloadButton);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1526, 30);
            this.UpperPanel.TabIndex = 0;
            // 
            // devtools
            // 
            this.devtools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.devtools.Enabled = false;
            this.devtools.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.devtools.IconColor = System.Drawing.Color.White;
            this.devtools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.devtools.IconSize = 24;
            this.devtools.Location = new System.Drawing.Point(137, 6);
            this.devtools.Name = "devtools";
            this.devtools.Size = new System.Drawing.Size(24, 24);
            this.devtools.TabIndex = 18;
            this.devtools.TabStop = false;
            this.devtools.Visible = false;
            this.devtools.Click += new System.EventHandler(this.devtools_Click);
            // 
            // TabsSwitcher
            // 
            this.TabsSwitcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabsSwitcher.BackColor = System.Drawing.Color.Transparent;
            this.TabsSwitcher.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.TabsSwitcher.IconColor = System.Drawing.Color.White;
            this.TabsSwitcher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TabsSwitcher.IconSize = 24;
            this.TabsSwitcher.Location = new System.Drawing.Point(1352, 4);
            this.TabsSwitcher.Name = "TabsSwitcher";
            this.TabsSwitcher.Size = new System.Drawing.Size(24, 24);
            this.TabsSwitcher.TabIndex = 17;
            this.TabsSwitcher.TabStop = false;
            this.TabsSwitcher.Click += new System.EventHandler(this.TabsSwitcher_Click);
            // 
            // NotepadIcon
            // 
            this.NotepadIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotepadIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.NotepadIcon.Enabled = false;
            this.NotepadIcon.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.NotepadIcon.IconColor = System.Drawing.Color.White;
            this.NotepadIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NotepadIcon.IconSize = 24;
            this.NotepadIcon.Location = new System.Drawing.Point(1352, 5);
            this.NotepadIcon.Name = "NotepadIcon";
            this.NotepadIcon.Size = new System.Drawing.Size(24, 24);
            this.NotepadIcon.TabIndex = 16;
            this.NotepadIcon.TabStop = false;
            this.NotepadIcon.Visible = false;
            this.NotepadIcon.Click += new System.EventHandler(this.NotepadIconButton_Click);
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCacheButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClearCacheButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearCacheButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ClearCacheButton.IconColor = System.Drawing.Color.White;
            this.ClearCacheButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClearCacheButton.IconSize = 24;
            this.ClearCacheButton.Location = new System.Drawing.Point(1388, 5);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(24, 24);
            this.ClearCacheButton.TabIndex = 15;
            this.ClearCacheButton.TabStop = false;
            this.ClearCacheButton.Click += new System.EventHandler(this.ClearCacheButton_Click);
            // 
            // FolderIcon
            // 
            this.FolderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.FolderIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FolderIcon.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.FolderIcon.IconColor = System.Drawing.Color.White;
            this.FolderIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FolderIcon.IconSize = 26;
            this.FolderIcon.Location = new System.Drawing.Point(1422, 5);
            this.FolderIcon.Name = "FolderIcon";
            this.FolderIcon.Size = new System.Drawing.Size(26, 26);
            this.FolderIcon.TabIndex = 12;
            this.FolderIcon.TabStop = false;
            this.FolderIcon.Click += new System.EventHandler(this.FolderIcon_Click);
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(154)))), ((int)(((byte)(45)))));
            this.Time.Location = new System.Drawing.Point(1457, 4);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(60, 24);
            this.Time.TabIndex = 11;
            this.Time.Text = "00:00";
            this.Time.DoubleClick += new System.EventHandler(this.Time_DoubleClick);
            // 
            // NotepadIconButton
            // 
            this.NotepadIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotepadIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.NotepadIconButton.Enabled = false;
            this.NotepadIconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NotepadIconButton.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.NotepadIconButton.IconColor = System.Drawing.SystemColors.ControlText;
            this.NotepadIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NotepadIconButton.IconSize = 24;
            this.NotepadIconButton.Location = new System.Drawing.Point(1465, 6);
            this.NotepadIconButton.Name = "NotepadIconButton";
            this.NotepadIconButton.Size = new System.Drawing.Size(24, 24);
            this.NotepadIconButton.TabIndex = 10;
            this.NotepadIconButton.TabStop = false;
            this.NotepadIconButton.Visible = false;
            this.NotepadIconButton.Click += new System.EventHandler(this.NotepadIconButton_Click);
            // 
            // ReferenceIconButton
            // 
            this.ReferenceIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReferenceIconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ReferenceIconButton.Enabled = false;
            this.ReferenceIconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReferenceIconButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.ReferenceIconButton.IconColor = System.Drawing.SystemColors.ControlText;
            this.ReferenceIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReferenceIconButton.IconSize = 24;
            this.ReferenceIconButton.Location = new System.Drawing.Point(1495, 5);
            this.ReferenceIconButton.Name = "ReferenceIconButton";
            this.ReferenceIconButton.Size = new System.Drawing.Size(24, 24);
            this.ReferenceIconButton.TabIndex = 9;
            this.ReferenceIconButton.TabStop = false;
            this.ReferenceIconButton.Visible = false;
            // 
            // ScaleMinusButton
            // 
            this.ScaleMinusButton.BackColor = System.Drawing.Color.Transparent;
            this.ScaleMinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScaleMinusButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.ScaleMinusButton.IconColor = System.Drawing.Color.White;
            this.ScaleMinusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ScaleMinusButton.IconSize = 22;
            this.ScaleMinusButton.Location = new System.Drawing.Point(109, 7);
            this.ScaleMinusButton.Name = "ScaleMinusButton";
            this.ScaleMinusButton.Size = new System.Drawing.Size(22, 22);
            this.ScaleMinusButton.TabIndex = 8;
            this.ScaleMinusButton.TabStop = false;
            this.ScaleMinusButton.Click += new System.EventHandler(this.ScaleMinusButton_Click);
            // 
            // ScalePlusButton
            // 
            this.ScalePlusButton.BackColor = System.Drawing.Color.Transparent;
            this.ScalePlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScalePlusButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ScalePlusButton.IconColor = System.Drawing.Color.White;
            this.ScalePlusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ScalePlusButton.IconSize = 22;
            this.ScalePlusButton.Location = new System.Drawing.Point(82, 7);
            this.ScalePlusButton.Name = "ScalePlusButton";
            this.ScalePlusButton.Size = new System.Drawing.Size(22, 22);
            this.ScalePlusButton.TabIndex = 7;
            this.ScalePlusButton.TabStop = false;
            this.ScalePlusButton.Click += new System.EventHandler(this.ScalePlusButton_Click);
            // 
            // ForwardPageButton
            // 
            this.ForwardPageButton.BackColor = System.Drawing.Color.Transparent;
            this.ForwardPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForwardPageButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.ForwardPageButton.IconColor = System.Drawing.Color.White;
            this.ForwardPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ForwardPageButton.IconSize = 29;
            this.ForwardPageButton.Location = new System.Drawing.Point(52, 4);
            this.ForwardPageButton.Name = "ForwardPageButton";
            this.ForwardPageButton.Size = new System.Drawing.Size(29, 29);
            this.ForwardPageButton.TabIndex = 6;
            this.ForwardPageButton.TabStop = false;
            this.ForwardPageButton.Click += new System.EventHandler(this.ForwardPageButton_Click);
            // 
            // BackPageButton
            // 
            this.BackPageButton.BackColor = System.Drawing.Color.Transparent;
            this.BackPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPageButton.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.BackPageButton.IconColor = System.Drawing.Color.White;
            this.BackPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackPageButton.IconSize = 29;
            this.BackPageButton.Location = new System.Drawing.Point(29, 4);
            this.BackPageButton.Name = "BackPageButton";
            this.BackPageButton.Size = new System.Drawing.Size(29, 29);
            this.BackPageButton.TabIndex = 5;
            this.BackPageButton.TabStop = false;
            this.BackPageButton.Click += new System.EventHandler(this.BackPageButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.ReloadButton.IconColor = System.Drawing.Color.White;
            this.ReloadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReloadButton.IconSize = 22;
            this.ReloadButton.Location = new System.Drawing.Point(8, 7);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(22, 22);
            this.ReloadButton.TabIndex = 4;
            this.ReloadButton.TabStop = false;
            this.ReloadButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TabsPanel
            // 
            this.TabsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TabsPanel.Controls.Add(this.server2);
            this.TabsPanel.Controls.Add(this.addTab);
            this.TabsPanel.Controls.Add(this.server1);
            this.TabsPanel.Controls.Add(this.DefaultTab);
            this.TabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabsPanel.Location = new System.Drawing.Point(0, 30);
            this.TabsPanel.Name = "TabsPanel";
            this.TabsPanel.Size = new System.Drawing.Size(1526, 30);
            this.TabsPanel.TabIndex = 3;
            this.TabsPanel.Visible = false;
            // 
            // server2
            // 
            this.server2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.server2.FlatAppearance.BorderSize = 0;
            this.server2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.server2.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server2.ForeColor = System.Drawing.Color.White;
            this.server2.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.server2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.server2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.server2.IconSize = 16;
            this.server2.Location = new System.Drawing.Point(237, 4);
            this.server2.Name = "server2";
            this.server2.Size = new System.Drawing.Size(106, 23);
            this.server2.TabIndex = 3;
            this.server2.Text = "Главная";
            this.server2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.server2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.server2.UseVisualStyleBackColor = false;
            this.server2.Visible = false;
            this.server2.Click += new System.EventHandler(this.server2_Click);
            this.server2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.server2_MouseDown);
            this.server2.MouseEnter += new System.EventHandler(this.server2_MouseEnter);
            // 
            // addTab
            // 
            this.addTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.addTab.Enabled = false;
            this.addTab.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addTab.IconColor = System.Drawing.Color.White;
            this.addTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addTab.IconSize = 20;
            this.addTab.Location = new System.Drawing.Point(1496, 7);
            this.addTab.Name = "addTab";
            this.addTab.Size = new System.Drawing.Size(20, 20);
            this.addTab.TabIndex = 2;
            this.addTab.TabStop = false;
            this.addTab.Visible = false;
            this.addTab.Click += new System.EventHandler(this.addTab_Click);
            // 
            // server1
            // 
            this.server1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.server1.FlatAppearance.BorderSize = 0;
            this.server1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.server1.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server1.ForeColor = System.Drawing.Color.White;
            this.server1.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.server1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.server1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.server1.IconSize = 16;
            this.server1.Location = new System.Drawing.Point(123, 4);
            this.server1.Name = "server1";
            this.server1.Size = new System.Drawing.Size(106, 23);
            this.server1.TabIndex = 1;
            this.server1.Text = "Game #2";
            this.server1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.server1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.server1.UseVisualStyleBackColor = false;
            this.server1.Click += new System.EventHandler(this.server1_Click);
            this.server1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.server1_MouseDown);
            this.server1.MouseEnter += new System.EventHandler(this.server1_MouseEnter);
            // 
            // DefaultTab
            // 
            this.DefaultTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DefaultTab.FlatAppearance.BorderSize = 0;
            this.DefaultTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultTab.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultTab.ForeColor = System.Drawing.Color.White;
            this.DefaultTab.IconChar = FontAwesome.Sharp.IconChar.Splotch;
            this.DefaultTab.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DefaultTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DefaultTab.IconSize = 16;
            this.DefaultTab.Location = new System.Drawing.Point(7, 4);
            this.DefaultTab.Name = "DefaultTab";
            this.DefaultTab.Size = new System.Drawing.Size(108, 23);
            this.DefaultTab.TabIndex = 0;
            this.DefaultTab.Text = "Game #1";
            this.DefaultTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DefaultTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DefaultTab.UseVisualStyleBackColor = false;
            this.DefaultTab.Click += new System.EventHandler(this.DefaultTab_Click);
            this.DefaultTab.MouseEnter += new System.EventHandler(this.DefaultTab_MouseEnter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1526, 658);
            this.Controls.Add(this.TabsPanel);
            this.Controls.Add(this.SubmenuPanel);
            this.Controls.Add(this.UpperPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 200);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SubmenuPanel.ResumeLayout(false);
            this.addTabPanel.ResumeLayout(false);
            this.addTabPanel.PerformLayout();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devtools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabsSwitcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotepadIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCacheButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotepadIconButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceIconButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleMinusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScalePlusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadButton)).EndInit();
            this.TabsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubmenuPanel;
        private System.Windows.Forms.Panel UpperPanel;
        private FontAwesome.Sharp.IconPictureBox ReloadButton;
        private FontAwesome.Sharp.IconPictureBox ScaleMinusButton;
        private FontAwesome.Sharp.IconPictureBox ScalePlusButton;
        private FontAwesome.Sharp.IconPictureBox ForwardPageButton;
        private FontAwesome.Sharp.IconPictureBox BackPageButton;
        private FontAwesome.Sharp.IconPictureBox ReferenceIconButton;
        private System.Windows.Forms.Panel SubPanel;
        private FontAwesome.Sharp.IconPictureBox NotepadIconButton;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer Timer;
        private FontAwesome.Sharp.IconPictureBox FolderIcon;
        private FontAwesome.Sharp.IconPictureBox ClearCacheButton;
        private FontAwesome.Sharp.IconPictureBox NotepadIcon;
        private FontAwesome.Sharp.IconPictureBox TabsSwitcher;
        private System.Windows.Forms.Panel TabsPanel;
        private FontAwesome.Sharp.IconButton DefaultTab;
        private FontAwesome.Sharp.IconButton server1;
        private FontAwesome.Sharp.IconPictureBox addTab;
        private System.Windows.Forms.Panel addTabPanel;
        private FontAwesome.Sharp.IconButton button_addTab;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label URL_label;
        private System.Windows.Forms.TextBox tb_URL;
        private FontAwesome.Sharp.IconButton addTab_cancel;
        private FontAwesome.Sharp.IconButton server2;
        private FontAwesome.Sharp.IconPictureBox devtools;
    }
}

