namespace QuickNote
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.btnInsertPic = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnColor = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.cbbFontSize = new System.Windows.Forms.ComboBox();
            this.cbbFontFamily = new System.Windows.Forms.ComboBox();
            this.btnUnderL = new System.Windows.Forms.Button();
            this.btnIta = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeV = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelAdd = new System.Windows.Forms.Panel();
            this.tbTextNote = new System.Windows.Forms.RichTextBox();
            this.tbAddTag = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAddTitle = new System.Windows.Forms.TextBox();
            this.lstV = new System.Windows.Forms.ListView();
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSortTreeV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmrudSizeSuggestTag = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbtnCrlSpace = new System.Windows.Forms.RadioButton();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnEdit.SuspendLayout();
            this.pnColor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudSizeSuggestTag)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "asdad";
            this.notifyIcon1.BalloonTipTitle = "asda";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Double click to chang status Main Window";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.statitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.showToolStripMenuItem.Text = "Show window";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // statitToolStripMenuItem
            // 
            this.statitToolStripMenuItem.Name = "statitToolStripMenuItem";
            this.statitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.statitToolStripMenuItem.Text = "Statistics";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Hide";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.pnEdit);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panelAdd);
            this.groupBox1.Controls.Add(this.lstV);
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 498);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pnEdit
            // 
            this.pnEdit.Controls.Add(this.btnInsertPic);
            this.pnEdit.Controls.Add(this.btnEdit);
            this.pnEdit.Controls.Add(this.pnColor);
            this.pnEdit.Controls.Add(this.cbbFontSize);
            this.pnEdit.Controls.Add(this.cbbFontFamily);
            this.pnEdit.Controls.Add(this.btnUnderL);
            this.pnEdit.Controls.Add(this.btnIta);
            this.pnEdit.Controls.Add(this.btnBold);
            this.pnEdit.Location = new System.Drawing.Point(270, 160);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(905, 30);
            this.pnEdit.TabIndex = 17;
            // 
            // btnInsertPic
            // 
            this.btnInsertPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertPic.BackgroundImage")));
            this.btnInsertPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertPic.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsertPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPic.Location = new System.Drawing.Point(408, 7);
            this.btnInsertPic.Name = "btnInsertPic";
            this.btnInsertPic.Size = new System.Drawing.Size(22, 22);
            this.btnInsertPic.TabIndex = 32;
            this.tt.SetToolTip(this.btnInsertPic, "Insert picture from your computer");
            this.btnInsertPic.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(677, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(43, 23);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Save";
            this.tt.SetToolTip(this.btnEdit, "Save changed");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnColor
            // 
            this.pnColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnColor.Controls.Add(this.btnFont);
            this.pnColor.Controls.Add(this.btnColor);
            this.pnColor.Location = new System.Drawing.Point(261, 7);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(25, 20);
            this.pnColor.TabIndex = 24;
            this.tt.SetToolTip(this.pnColor, "Change color of your text");
            this.pnColor.Click += new System.EventHandler(this.pnColor_Click);
            this.pnColor.MouseLeave += new System.EventHandler(this.pnColor_MouseLeave);
            this.pnColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseMove);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFont.BackgroundImage")));
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFont.Enabled = false;
            this.btnFont.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFont.FlatAppearance.BorderSize = 0;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Location = new System.Drawing.Point(5, 2);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(15, 12);
            this.btnFont.TabIndex = 17;
            this.tt.SetToolTip(this.btnFont, "Change color of your text");
            this.btnFont.UseVisualStyleBackColor = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Enabled = false;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(2, 14);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(21, 5);
            this.btnColor.TabIndex = 23;
            this.tt.SetToolTip(this.btnColor, "Change color of your text");
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // cbbFontSize
            // 
            this.cbbFontSize.FormattingEnabled = true;
            this.cbbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbbFontSize.Location = new System.Drawing.Point(193, 6);
            this.cbbFontSize.Name = "cbbFontSize";
            this.cbbFontSize.Size = new System.Drawing.Size(42, 21);
            this.cbbFontSize.TabIndex = 22;
            this.tt.SetToolTip(this.cbbFontSize, "Change the size of your text");
            this.cbbFontSize.Validated += new System.EventHandler(this.cbbFontSize_Validated);
            // 
            // cbbFontFamily
            // 
            this.cbbFontFamily.FormattingEnabled = true;
            this.cbbFontFamily.Location = new System.Drawing.Point(94, 6);
            this.cbbFontFamily.Name = "cbbFontFamily";
            this.cbbFontFamily.Size = new System.Drawing.Size(93, 21);
            this.cbbFontFamily.TabIndex = 21;
            this.tt.SetToolTip(this.cbbFontFamily, "Pick a new font for your text");
            this.cbbFontFamily.Validated += new System.EventHandler(this.cbbFontFamily_Validated);
            // 
            // btnUnderL
            // 
            this.btnUnderL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnderL.BackgroundImage")));
            this.btnUnderL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnderL.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnderL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderL.Location = new System.Drawing.Point(370, 10);
            this.btnUnderL.Name = "btnUnderL";
            this.btnUnderL.Size = new System.Drawing.Size(15, 16);
            this.btnUnderL.TabIndex = 20;
            this.tt.SetToolTip(this.btnUnderL, "Underline your text");
            this.btnUnderL.UseVisualStyleBackColor = true;
            this.btnUnderL.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIta
            // 
            this.btnIta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIta.BackgroundImage")));
            this.btnIta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIta.Location = new System.Drawing.Point(335, 10);
            this.btnIta.Name = "btnIta";
            this.btnIta.Size = new System.Drawing.Size(15, 15);
            this.btnIta.TabIndex = 19;
            this.tt.SetToolTip(this.btnIta, "Italicize your text");
            this.btnIta.UseVisualStyleBackColor = true;
            this.btnIta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBold.BackgroundImage")));
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBold.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Location = new System.Drawing.Point(304, 10);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(15, 15);
            this.btnBold.TabIndex = 18;
            this.tt.SetToolTip(this.btnBold, "Make your text bold");
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.treeV);
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 480);
            this.panel1.TabIndex = 16;
            // 
            // treeV
            // 
            this.treeV.BackColor = System.Drawing.SystemColors.Control;
            this.treeV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treeV.HideSelection = false;
            this.treeV.HotTracking = true;
            this.treeV.ImageIndex = 0;
            this.treeV.ImageList = this.imageList1;
            this.treeV.Indent = 20;
            this.treeV.ItemHeight = 20;
            this.treeV.Location = new System.Drawing.Point(3, 6);
            this.treeV.Name = "treeV";
            this.treeV.SelectedImageIndex = 0;
            this.treeV.ShowLines = false;
            this.treeV.ShowNodeToolTips = true;
            this.treeV.Size = new System.Drawing.Size(257, 469);
            this.treeV.TabIndex = 8;
            this.treeV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeV_AfterSelect);
            this.treeV.DoubleClick += new System.EventHandler(this.treeV_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tag-2.png");
            this.imageList1.Images.SetKeyName(1, "icons8-bill-50.png");
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.tbTextNote);
            this.panelAdd.Controls.Add(this.tbAddTag);
            this.panelAdd.Controls.Add(this.tbTag);
            this.panelAdd.Controls.Add(this.tbTitle);
            this.panelAdd.Controls.Add(this.tbAddTitle);
            this.panelAdd.Location = new System.Drawing.Point(263, 192);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(912, 302);
            this.panelAdd.TabIndex = 15;
            // 
            // tbTextNote
            // 
            this.tbTextNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTextNote.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTextNote.Location = new System.Drawing.Point(7, 26);
            this.tbTextNote.Name = "tbTextNote";
            this.tbTextNote.Size = new System.Drawing.Size(902, 271);
            this.tbTextNote.TabIndex = 20;
            this.tbTextNote.Text = "";
            // 
            // tbAddTag
            // 
            this.tbAddTag.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddTag.Location = new System.Drawing.Point(504, 1);
            this.tbAddTag.Name = "tbAddTag";
            this.tbAddTag.Size = new System.Drawing.Size(404, 26);
            this.tbAddTag.TabIndex = 19;
            this.tt.SetToolTip(this.tbAddTag, "List tags of this Note");
            // 
            // tbTag
            // 
            this.tbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTag.Location = new System.Drawing.Point(460, 1);
            this.tbTag.Name = "tbTag";
            this.tbTag.ReadOnly = true;
            this.tbTag.Size = new System.Drawing.Size(48, 26);
            this.tbTag.TabIndex = 18;
            this.tbTag.Text = "Tags";
            this.tbTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(7, 1);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(75, 26);
            this.tbTitle.TabIndex = 17;
            this.tbTitle.Text = "Title";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddTitle
            // 
            this.tbAddTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbAddTitle.Location = new System.Drawing.Point(81, 1);
            this.tbAddTitle.Name = "tbAddTitle";
            this.tbAddTitle.Size = new System.Drawing.Size(379, 26);
            this.tbAddTitle.TabIndex = 16;
            this.tt.SetToolTip(this.tbAddTitle, "Title of this Note");
            // 
            // lstV
            // 
            this.lstV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col2,
            this.col3,
            this.col1,
            this.col4});
            this.lstV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstV.FullRowSelect = true;
            this.lstV.GridLines = true;
            this.lstV.Location = new System.Drawing.Point(266, 14);
            this.lstV.Name = "lstV";
            this.lstV.Size = new System.Drawing.Size(909, 144);
            this.lstV.TabIndex = 9;
            this.lstV.UseCompatibleStateImageBehavior = false;
            this.lstV.View = System.Windows.Forms.View.Details;
            this.lstV.SelectedIndexChanged += new System.EventHandler(this.lstV_SelectedIndexChanged);
            // 
            // col2
            // 
            this.col2.Text = "Title";
            this.col2.Width = 200;
            // 
            // col3
            // 
            this.col3.Text = "Note";
            this.col3.Width = 350;
            // 
            // col1
            // 
            this.col1.Text = "Created";
            this.col1.Width = 150;
            // 
            // col4
            // 
            this.col4.Text = "Tags";
            this.col4.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnSortTreeV);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Location = new System.Drawing.Point(3, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 32);
            this.panel2.TabIndex = 9;
            // 
            // btnSortTreeV
            // 
            this.btnSortTreeV.Location = new System.Drawing.Point(152, 6);
            this.btnSortTreeV.Name = "btnSortTreeV";
            this.btnSortTreeV.Size = new System.Drawing.Size(75, 23);
            this.btnSortTreeV.TabIndex = 13;
            this.btnSortTreeV.Text = "Sort";
            this.tt.SetToolTip(this.btnSortTreeV, "Sort Tags List");
            this.btnSortTreeV.UseVisualStyleBackColor = true;
            this.btnSortTreeV.Click += new System.EventHandler(this.btnSortTreeV_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(71, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.tt.SetToolTip(this.btnRefresh, "Refresh Tree view");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddNote.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNote.Image")));
            this.btnAddNote.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddNote.Location = new System.Drawing.Point(0, 1);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(115, 30);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "New Note";
            this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.btnAddNote, "Click to add new Note");
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.ShowHelp = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nmrudSizeSuggestTag);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.rdbtnCrlSpace);
            this.panel3.Controls.Add(this.btnAddNote);
            this.panel3.Location = new System.Drawing.Point(263, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 32);
            this.panel3.TabIndex = 12;
            this.tt.SetToolTip(this.panel3, "Chose shortcut key to add new Note");
            // 
            // nmrudSizeSuggestTag
            // 
            this.nmrudSizeSuggestTag.BackColor = System.Drawing.Color.Lavender;
            this.nmrudSizeSuggestTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrudSizeSuggestTag.Location = new System.Drawing.Point(321, 5);
            this.nmrudSizeSuggestTag.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmrudSizeSuggestTag.Name = "nmrudSizeSuggestTag";
            this.nmrudSizeSuggestTag.Size = new System.Drawing.Size(35, 21);
            this.nmrudSizeSuggestTag.TabIndex = 14;
            this.nmrudSizeSuggestTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tt.SetToolTip(this.nmrudSizeSuggestTag, "Change number of tags will suggest on  new Note");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(226, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "WIN + Z";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbtnCrlSpace
            // 
            this.rdbtnCrlSpace.AutoSize = true;
            this.rdbtnCrlSpace.Checked = true;
            this.rdbtnCrlSpace.Location = new System.Drawing.Point(121, 8);
            this.rdbtnCrlSpace.Name = "rdbtnCrlSpace";
            this.rdbtnCrlSpace.Size = new System.Drawing.Size(96, 17);
            this.rdbtnCrlSpace.TabIndex = 12;
            this.rdbtnCrlSpace.TabStop = true;
            this.rdbtnCrlSpace.Text = "CTRL + SPACE";
            this.rdbtnCrlSpace.UseVisualStyleBackColor = true;
            this.rdbtnCrlSpace.CheckedChanged += new System.EventHandler(this.rdbtnCrlSpace_CheckedChanged);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickNote--";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnEdit.ResumeLayout(false);
            this.pnColor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudSizeSuggestTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1 = new System.Windows.Forms.NotifyIcon();
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstV;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.TreeView treeV;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox tbAddTag;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAddTitle;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Panel pnEdit;
        private System.Windows.Forms.Button btnUnderL;
        private System.Windows.Forms.Button btnIta;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.ComboBox cbbFontSize;
        private System.Windows.Forms.ComboBox cbbFontFamily;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox tbTextNote;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbtnCrlSpace;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem statitToolStripMenuItem;
        private System.Windows.Forms.Button btnInsertPic;
        private System.Windows.Forms.Button btnSortTreeV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.NumericUpDown nmrudSizeSuggestTag;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
    }
}

