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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.cbbFontSize = new System.Windows.Forms.ComboBox();
            this.cbbFontFamily = new System.Windows.Forms.ComboBox();
            this.btnUnderL = new System.Windows.Forms.Button();
            this.btnIta = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
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
            this.btnAddNote = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "asdad";
            this.notifyIcon1.BalloonTipTitle = "asda";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.showToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
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
            this.groupBox1.Size = new System.Drawing.Size(996, 498);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pnEdit
            // 
            this.pnEdit.Controls.Add(this.cbbFontSize);
            this.pnEdit.Controls.Add(this.cbbFontFamily);
            this.pnEdit.Controls.Add(this.btnUnderL);
            this.pnEdit.Controls.Add(this.btnIta);
            this.pnEdit.Controls.Add(this.btnBold);
            this.pnEdit.Controls.Add(this.btnFont);
            this.pnEdit.Location = new System.Drawing.Point(270, 160);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(709, 30);
            this.pnEdit.TabIndex = 17;
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
            this.cbbFontSize.Location = new System.Drawing.Point(200, 6);
            this.cbbFontSize.Name = "cbbFontSize";
            this.cbbFontSize.Size = new System.Drawing.Size(42, 21);
            this.cbbFontSize.TabIndex = 22;
            this.cbbFontSize.Validated += new System.EventHandler(this.cbbFontSize_Validated);
            // 
            // cbbFontFamily
            // 
            this.cbbFontFamily.FormattingEnabled = true;
            this.cbbFontFamily.Location = new System.Drawing.Point(101, 6);
            this.cbbFontFamily.Name = "cbbFontFamily";
            this.cbbFontFamily.Size = new System.Drawing.Size(93, 21);
            this.cbbFontFamily.TabIndex = 21;
            this.cbbFontFamily.Validated += new System.EventHandler(this.cbbFontFamily_Validated);
            // 
            // btnUnderL
            // 
            this.btnUnderL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnderL.BackgroundImage")));
            this.btnUnderL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnderL.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnderL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderL.Location = new System.Drawing.Point(360, 10);
            this.btnUnderL.Name = "btnUnderL";
            this.btnUnderL.Size = new System.Drawing.Size(15, 15);
            this.btnUnderL.TabIndex = 20;
            this.btnUnderL.UseVisualStyleBackColor = true;
            this.btnUnderL.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIta
            // 
            this.btnIta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIta.BackgroundImage")));
            this.btnIta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIta.Location = new System.Drawing.Point(325, 10);
            this.btnIta.Name = "btnIta";
            this.btnIta.Size = new System.Drawing.Size(15, 15);
            this.btnIta.TabIndex = 19;
            this.btnIta.UseVisualStyleBackColor = true;
            this.btnIta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBold.BackgroundImage")));
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBold.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Location = new System.Drawing.Point(294, 10);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(15, 15);
            this.btnBold.TabIndex = 18;
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.Control;
            this.btnFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFont.BackgroundImage")));
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFont.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Location = new System.Drawing.Point(257, 7);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(20, 20);
            this.btnFont.TabIndex = 17;
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.treeV);
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 484);
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
            this.treeV.Size = new System.Drawing.Size(257, 475);
            this.treeV.TabIndex = 8;
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
            this.panelAdd.Size = new System.Drawing.Size(733, 302);
            this.panelAdd.TabIndex = 15;
            // 
            // tbTextNote
            // 
            this.tbTextNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTextNote.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTextNote.Location = new System.Drawing.Point(7, 26);
            this.tbTextNote.Name = "tbTextNote";
            this.tbTextNote.Size = new System.Drawing.Size(726, 271);
            this.tbTextNote.TabIndex = 20;
            this.tbTextNote.Text = "";
            // 
            // tbAddTag
            // 
            this.tbAddTag.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddTag.Location = new System.Drawing.Point(504, 1);
            this.tbAddTag.Name = "tbAddTag";
            this.tbAddTag.Size = new System.Drawing.Size(227, 26);
            this.tbAddTag.TabIndex = 19;
            // 
            // tbTag
            // 
            this.tbTag.Font = new System.Drawing.Font(".VnArial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbTitle.Font = new System.Drawing.Font(".VnArial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lstV.Size = new System.Drawing.Size(734, 144);
            this.lstV.TabIndex = 9;
            this.lstV.UseCompatibleStateImageBehavior = false;
            this.lstV.View = System.Windows.Forms.View.Details;
            this.lstV.SelectedIndexChanged += new System.EventHandler(this.lstV_SelectedIndexChanged);
            // 
            // col2
            // 
            this.col2.Text = "Title";
            this.col2.Width = 180;
            // 
            // col3
            // 
            this.col3.Text = "Note";
            this.col3.Width = 280;
            // 
            // col1
            // 
            this.col1.Text = "Created";
            this.col1.Width = 120;
            // 
            // col4
            // 
            this.col4.Text = "Tags";
            this.col4.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnAddNote);
            this.panel2.Location = new System.Drawing.Point(3, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 32);
            this.panel2.TabIndex = 9;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNote.Image")));
            this.btnAddNote.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddNote.Location = new System.Drawing.Point(267, 0);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(115, 30);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "New Note";
            this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.ShowHelp = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(63, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 552);
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
            this.panel1.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
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
    }
}

