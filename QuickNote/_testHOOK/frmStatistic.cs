using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _testHOOK
{
    public partial class frmStatistic : Form
    {
        private List<TagNote> _lstTagNote = new List<TagNote>();
        public frmStatistic(List<TagNote> lstTag)
        {
            InitializeComponent();
            _lstTagNote = lstTag;
            create();
        }
        void create()
        {
            
            Series sr = new Series("Tags");
           for(int i=0;i < _lstTagNote.Count;i++ )
            { DataPoint dp = new DataPoint();
                dp.XValue = i;
                dp.SetValueY(_lstTagNote[i].NAppFre);
                dp.AxisLabel = _lstTagNote[i].Tag;
                sr.Points.Add(dp);
               
            }
            chart1.Series.Add(sr);

            chart1.Series[0].ChartType = SeriesChartType.Bar;
            chart1.Series[0].XAxisType = AxisType.Primary;

        }

        private void rdbtnColumn_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Column;
        }

        private void rdbtnPie_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Pie;
        }



        private void rdbtnPyramid_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Pyramid;
        }

        private void drbtnRadar_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Radar;
        }

        private void rdbtnBar_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Bar;
        }

        private void primaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            primaryToolStripMenuItem.Checked = true;
            secondaryToolStripMenuItem.Checked = false;
            chart1.Series[0].XAxisType = AxisType.Primary;
            chart1.Titles[0].Docking = Docking.Top;

        }

        private void secondaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secondaryToolStripMenuItem.Checked = true;

            primaryToolStripMenuItem.Checked = false;
            chart1.Series[0].XAxisType = AxisType.Secondary;
            chart1.Titles[0].Docking = Docking.Bottom;


        }

        private void typeViewToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            typeViewToolStripMenuItem.ShowDropDown();
        }

        private void typeViewToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
