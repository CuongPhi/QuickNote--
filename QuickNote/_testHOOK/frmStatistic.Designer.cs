namespace _testHOOK
{
    partial class frmStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistic));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnBar = new System.Windows.Forms.RadioButton();
            this.drbtnRadar = new System.Windows.Forms.RadioButton();
            this.rdbtnPyramid = new System.Windows.Forms.RadioButton();
            this.rdbtnPie = new System.Windows.Forms.RadioButton();
            this.rdbtnColumn = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "List Tags";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 65);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(847, 407);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "TAGS OVERVIEW";
            this.chart1.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnBar);
            this.groupBox1.Controls.Add(this.drbtnRadar);
            this.groupBox1.Controls.Add(this.rdbtnPyramid);
            this.groupBox1.Controls.Add(this.rdbtnPie);
            this.groupBox1.Controls.Add(this.rdbtnColumn);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TypeChart";
            // 
            // rdbtnBar
            // 
            this.rdbtnBar.AutoSize = true;
            this.rdbtnBar.Checked = true;
            this.rdbtnBar.Location = new System.Drawing.Point(104, 15);
            this.rdbtnBar.Name = "rdbtnBar";
            this.rdbtnBar.Size = new System.Drawing.Size(41, 17);
            this.rdbtnBar.TabIndex = 4;
            this.rdbtnBar.TabStop = true;
            this.rdbtnBar.Text = "Bar";
            this.rdbtnBar.UseVisualStyleBackColor = true;
            this.rdbtnBar.CheckedChanged += new System.EventHandler(this.rdbtnBar_CheckedChanged);
            // 
            // drbtnRadar
            // 
            this.drbtnRadar.AutoSize = true;
            this.drbtnRadar.Location = new System.Drawing.Point(379, 15);
            this.drbtnRadar.Name = "drbtnRadar";
            this.drbtnRadar.Size = new System.Drawing.Size(54, 17);
            this.drbtnRadar.TabIndex = 3;
            this.drbtnRadar.Text = "Radar";
            this.drbtnRadar.UseVisualStyleBackColor = true;
            this.drbtnRadar.CheckedChanged += new System.EventHandler(this.drbtnRadar_CheckedChanged);
            // 
            // rdbtnPyramid
            // 
            this.rdbtnPyramid.AutoSize = true;
            this.rdbtnPyramid.Location = new System.Drawing.Point(648, 15);
            this.rdbtnPyramid.Name = "rdbtnPyramid";
            this.rdbtnPyramid.Size = new System.Drawing.Size(62, 17);
            this.rdbtnPyramid.TabIndex = 2;
            this.rdbtnPyramid.Text = "Pyramid";
            this.rdbtnPyramid.UseVisualStyleBackColor = true;
            this.rdbtnPyramid.CheckedChanged += new System.EventHandler(this.rdbtnPyramid_CheckedChanged);
            // 
            // rdbtnPie
            // 
            this.rdbtnPie.AutoSize = true;
            this.rdbtnPie.Location = new System.Drawing.Point(519, 15);
            this.rdbtnPie.Name = "rdbtnPie";
            this.rdbtnPie.Size = new System.Drawing.Size(40, 17);
            this.rdbtnPie.TabIndex = 1;
            this.rdbtnPie.Text = "Pie";
            this.rdbtnPie.UseVisualStyleBackColor = true;
            this.rdbtnPie.CheckedChanged += new System.EventHandler(this.rdbtnPie_CheckedChanged);
            // 
            // rdbtnColumn
            // 
            this.rdbtnColumn.AutoSize = true;
            this.rdbtnColumn.Location = new System.Drawing.Point(234, 15);
            this.rdbtnColumn.Name = "rdbtnColumn";
            this.rdbtnColumn.Size = new System.Drawing.Size(60, 17);
            this.rdbtnColumn.TabIndex = 0;
            this.rdbtnColumn.Text = "Column";
            this.rdbtnColumn.UseVisualStyleBackColor = true;
            this.rdbtnColumn.CheckedChanged += new System.EventHandler(this.rdbtnColumn_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typeViewToolStripMenuItem
            // 
            this.typeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primaryToolStripMenuItem,
            this.secondaryToolStripMenuItem});
            this.typeViewToolStripMenuItem.Name = "typeViewToolStripMenuItem";
            this.typeViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.typeViewToolStripMenuItem.Text = "View";
            this.typeViewToolStripMenuItem.MouseLeave += new System.EventHandler(this.typeViewToolStripMenuItem_MouseLeave);
            this.typeViewToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.typeViewToolStripMenuItem_MouseMove);
            // 
            // primaryToolStripMenuItem
            // 
            this.primaryToolStripMenuItem.Checked = true;
            this.primaryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.primaryToolStripMenuItem.Name = "primaryToolStripMenuItem";
            this.primaryToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.primaryToolStripMenuItem.Text = "Primary";
            this.primaryToolStripMenuItem.Click += new System.EventHandler(this.primaryToolStripMenuItem_Click);
            // 
            // secondaryToolStripMenuItem
            // 
            this.secondaryToolStripMenuItem.Name = "secondaryToolStripMenuItem";
            this.secondaryToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.secondaryToolStripMenuItem.Text = "Secondary";
            this.secondaryToolStripMenuItem.Click += new System.EventHandler(this.secondaryToolStripMenuItem_Click);
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStatistic";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnPyramid;
        private System.Windows.Forms.RadioButton rdbtnPie;
        private System.Windows.Forms.RadioButton rdbtnColumn;
        private System.Windows.Forms.RadioButton drbtnRadar;
        private System.Windows.Forms.RadioButton rdbtnBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem typeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem primaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondaryToolStripMenuItem;
    }
}