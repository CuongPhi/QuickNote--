namespace QuickNote
{
    partial class frmAddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNote));
            this.panelAdd = new System.Windows.Forms.Panel();
            this.pnColor = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.cbbFontSize = new System.Windows.Forms.ComboBox();
            this.cbbFontFamily = new System.Windows.Forms.ComboBox();
            this.btnUnderL = new System.Windows.Forms.Button();
            this.btnIta = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTextNote = new System.Windows.Forms.RichTextBox();
            this.tbAddTag = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAddTitle = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.panelAdd.SuspendLayout();
            this.pnColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.pnColor);
            this.panelAdd.Controls.Add(this.cbbFontSize);
            this.panelAdd.Controls.Add(this.cbbFontFamily);
            this.panelAdd.Controls.Add(this.btnUnderL);
            this.panelAdd.Controls.Add(this.btnIta);
            this.panelAdd.Controls.Add(this.btnBold);
            this.panelAdd.Controls.Add(this.btnSave);
            this.panelAdd.Controls.Add(this.tbTextNote);
            this.panelAdd.Controls.Add(this.tbAddTag);
            this.panelAdd.Controls.Add(this.tbTag);
            this.panelAdd.Controls.Add(this.tbTitle);
            this.panelAdd.Controls.Add(this.tbAddTitle);
            this.panelAdd.Location = new System.Drawing.Point(1, 2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(286, 293);
            this.panelAdd.TabIndex = 16;
            // 
            // pnColor
            // 
            this.pnColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnColor.Controls.Add(this.btnFont);
            this.pnColor.Controls.Add(this.btnColor);
            this.pnColor.Location = new System.Drawing.Point(160, 50);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(25, 20);
            this.pnColor.TabIndex = 29;
            this.tt.SetToolTip(this.pnColor, "Color text Note");
            this.pnColor.Click += new System.EventHandler(this.pnColor_Click_1);
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
            this.tt.SetToolTip(this.btnFont, "Chose color of text Note");
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
            this.cbbFontSize.Location = new System.Drawing.Point(110, 49);
            this.cbbFontSize.Name = "cbbFontSize";
            this.cbbFontSize.Size = new System.Drawing.Size(42, 21);
            this.cbbFontSize.TabIndex = 28;
            this.cbbFontSize.Text = "12";
            this.tt.SetToolTip(this.cbbFontSize, "Chose Font Size");
            this.cbbFontSize.Validated += new System.EventHandler(this.cbbFontSize_Validated);
            // 
            // cbbFontFamily
            // 
            this.cbbFontFamily.FormattingEnabled = true;
            this.cbbFontFamily.Location = new System.Drawing.Point(11, 49);
            this.cbbFontFamily.Name = "cbbFontFamily";
            this.cbbFontFamily.Size = new System.Drawing.Size(93, 21);
            this.cbbFontFamily.TabIndex = 27;
            this.cbbFontFamily.Text = "Arial";
            this.tt.SetToolTip(this.cbbFontFamily, "Chose Font Families");
            this.cbbFontFamily.Validated += new System.EventHandler(this.cbbFontFamily_Validated);
            // 
            // btnUnderL
            // 
            this.btnUnderL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUnderL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnderL.BackgroundImage")));
            this.btnUnderL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnderL.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnderL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderL.Location = new System.Drawing.Point(235, 53);
            this.btnUnderL.Name = "btnUnderL";
            this.btnUnderL.Size = new System.Drawing.Size(15, 16);
            this.btnUnderL.TabIndex = 26;
            this.tt.SetToolTip(this.btnUnderL, "Text Underline");
            this.btnUnderL.UseVisualStyleBackColor = false;
            this.btnUnderL.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIta
            // 
            this.btnIta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIta.BackgroundImage")));
            this.btnIta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIta.Location = new System.Drawing.Point(214, 53);
            this.btnIta.Name = "btnIta";
            this.btnIta.Size = new System.Drawing.Size(15, 15);
            this.btnIta.TabIndex = 25;
            this.tt.SetToolTip(this.btnIta, "Text Italic");
            this.btnIta.UseVisualStyleBackColor = false;
            this.btnIta.Click += new System.EventHandler(this.btnIta_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBold.BackgroundImage")));
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBold.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Location = new System.Drawing.Point(193, 53);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(15, 15);
            this.btnBold.TabIndex = 24;
            this.tt.SetToolTip(this.btnBold, "Text Bold");
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(240, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 36);
            this.btnSave.TabIndex = 21;
            this.tt.SetToolTip(this.btnSave, "Click to Save new Note");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTextNote
            // 
            this.tbTextNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTextNote.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTextNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTextNote.Location = new System.Drawing.Point(3, 75);
            this.tbTextNote.Name = "tbTextNote";
            this.tbTextNote.Size = new System.Drawing.Size(283, 215);
            this.tbTextNote.TabIndex = 20;
            this.tbTextNote.Text = "";
            this.tt.SetToolTip(this.tbTextNote, "Type text Note");
            this.tbTextNote.TextChanged += new System.EventHandler(this.tbTextNote_TextChanged);
            // 
            // tbAddTag
            // 
            this.tbAddTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbAddTag.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tbAddTag.Location = new System.Drawing.Point(59, 0);
            this.tbAddTag.Name = "tbAddTag";
            this.tbAddTag.Size = new System.Drawing.Size(175, 22);
            this.tbAddTag.TabIndex = 19;
            this.tt.SetToolTip(this.tbAddTag, "Suggested tag");
            this.tbAddTag.TextChanged += new System.EventHandler(this.tbAddTag_TextChanged);
            this.tbAddTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddTag_KeyDown);
            this.tbAddTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAddTag_KeyUp);
            // 
            // tbTag
            // 
            this.tbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTag.Location = new System.Drawing.Point(11, 0);
            this.tbTag.Name = "tbTag";
            this.tbTag.ReadOnly = true;
            this.tbTag.Size = new System.Drawing.Size(50, 22);
            this.tbTag.TabIndex = 18;
            this.tbTag.Text = "Tags:";
            this.tbTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(11, 21);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(49, 22);
            this.tbTitle.TabIndex = 17;
            this.tbTitle.Text = "Title:";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddTitle
            // 
            this.tbAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbAddTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAddTitle.Location = new System.Drawing.Point(59, 21);
            this.tbAddTitle.Name = "tbAddTitle";
            this.tbAddTitle.Size = new System.Drawing.Size(175, 22);
            this.tbAddTitle.TabIndex = 16;
            this.tt.SetToolTip(this.tbAddTitle, "Type title Note");
            // 
            // frmAddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(293, 296);
            this.Controls.Add(this.panelAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNote_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNote_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.pnColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.RichTextBox tbTextNote;
        private System.Windows.Forms.TextBox tbAddTag;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAddTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbbFontSize;
        private System.Windows.Forms.ComboBox cbbFontFamily;
        private System.Windows.Forms.Button btnUnderL;
        private System.Windows.Forms.Button btnIta;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ToolTip tt;
    }
}