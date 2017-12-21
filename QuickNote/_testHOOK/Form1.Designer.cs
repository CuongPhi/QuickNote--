namespace _testHOOK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.tbAddTag = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAddTitle = new System.Windows.Forms.TextBox();
            this.tbTextNote = new System.Windows.Forms.TextBox();
            this.lstV = new System.Windows.Forms.ListView();
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeV = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnEdit.SuspendLayout();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.tbAddTag);
            this.panelAdd.Controls.Add(this.tbTag);
            this.panelAdd.Controls.Add(this.tbTitle);
            this.panelAdd.Controls.Add(this.tbAddTitle);
            this.panelAdd.Controls.Add(this.tbTextNote);
            this.panelAdd.Location = new System.Drawing.Point(263, 192);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(733, 302);
            this.panelAdd.TabIndex = 15;
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
            // tbTextNote
            // 
            this.tbTextNote.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTextNote.Location = new System.Drawing.Point(7, 26);
            this.tbTextNote.Multiline = true;
            this.tbTextNote.Name = "tbTextNote";
            this.tbTextNote.Size = new System.Drawing.Size(724, 276);
            this.tbTextNote.TabIndex = 15;
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
            this.treeV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeV_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tag-2.png");
            this.imageList1.Images.SetKeyName(1, "icons8-bill-50.png");
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
            // btnFont
            // 
            this.btnFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFont.BackgroundImage")));
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFont.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Location = new System.Drawing.Point(132, 10);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(18, 17);
            this.btnFont.TabIndex = 17;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // pnEdit
            // 
            this.pnEdit.Controls.Add(this.button3);
            this.pnEdit.Controls.Add(this.button2);
            this.pnEdit.Controls.Add(this.button1);
            this.pnEdit.Controls.Add(this.btnFont);
            this.pnEdit.Location = new System.Drawing.Point(270, 160);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(709, 30);
            this.pnEdit.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(169, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(200, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 15);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(234, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(15, 15);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickNote--";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
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
        private System.Windows.Forms.TextBox tbTextNote;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Panel pnEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

