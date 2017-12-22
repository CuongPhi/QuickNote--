using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class frmAddNote : Form
    {

        private FontFamily[] Families { get; }
        private bool addSuccess = false;

        private int _sumNote = 0;
        public delegate void AddNoteHandler(bool b);
        public AddNoteHandler AddNote;
        
        public frmAddNote(int noteSum)
        {

            InitializeComponent();
            _sumNote = noteSum;
        }

        private void frmAddNote_Load(object sender, EventArgs e)
        {
            foreach (FontFamily item in FontFamily.Families)
            {
                cbbFontFamily.Items.Add(item.Name);
            }
            cbbFontSize.Text = tbTextNote.Font.Size.ToString();
            cbbFontFamily.Text = tbTextNote.Font.FontFamily.Name;

        }

        private void cbbFontSize_Validated(object sender, EventArgs e)
        {
            uint fontSize = 8;
            if (!uint.TryParse(cbbFontSize.Text, out fontSize))
            {

                MessageBox.Show("This is not a valid number !");
                cbbFontSize.Text = tbTextNote.Font.Size.ToString();

            }
            else if (fontSize > 73 || fontSize < 8)
            {
                MessageBox.Show("Size from 8 to 72 !");
                cbbFontSize.Text = tbTextNote.Font.Size.ToString();
            }
            else
            {
                tbTextNote.Font = new Font(tbTextNote.Font.FontFamily, Int32.Parse(cbbFontSize.Text), tbTextNote.Font.Style);
            }
        }

        private void cbbFontFamily_Validated(object sender, EventArgs e)
        {
            if (!cbbFontFamily.Items.Contains(cbbFontFamily.Text))
            {
                MessageBox.Show("There is no font with that name !");
                cbbFontFamily.Text = tbTextNote.Font.FontFamily.Name;
            }
            else
            {
                tbTextNote.Font = new Font(cbbFontFamily.Text, tbTextNote.Font.Size, tbTextNote.Font.Style);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool bold = tbTextNote.Font.Underline;
            FontStyle ft = tbTextNote.Font.Style;
            if (bold)
            {
                ft = ft & ~FontStyle.Underline;
            }
            else
            {
                ft = ft | FontStyle.Underline;
            }
            tbTextNote.Font = new Font(tbTextNote.Font, ft);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            bool bold = tbTextNote.Font.Bold;
            FontStyle ft = tbTextNote.Font.Style;
            if (bold)
            {
                ft = ft & ~FontStyle.Bold;
            }
            else
            {
                ft = ft | FontStyle.Bold;
            }
            tbTextNote.Font = new Font(tbTextNote.Font, ft);
        }

        private void btnIta_Click(object sender, EventArgs e)
        {
            bool bold = tbTextNote.Font.Italic;
            FontStyle ft = tbTextNote.Font.Style;
            if (bold)
            {
                ft = ft & ~FontStyle.Italic;
            }
            else
            {
                ft = ft | FontStyle.Italic;
            }
            tbTextNote.Font = new Font(tbTextNote.Font, ft);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "";
            string stringSplit = ";\r\n";
            if (tbTextNote.Text.Length < 2)
            {
                MessageBox.Show("Text very short !");
                return;
            }
            if (tbAddTag.Text == "" || tbAddTitle.Text == "")
            {
                if (MessageBox.Show("Do you want to empty tags or title ??", "Error input !",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (tbAddTag.Text == "")
                    {
                        data += ("None" + stringSplit);
                    }
                    else
                    {
                        data += (tbAddTag.Text + stringSplit);
                    }
                    if (tbAddTitle.Text == "")
                    {
                        data += ("None" + stringSplit);
                    }
                    else
                    {
                        data += (tbAddTitle.Text + stringSplit);
                    }

                }
                else
                {
                    return;
                }
            }
            else
            {
                data += (tbAddTag.Text + stringSplit);
                data += (tbAddTitle.Text + stringSplit);
            }
            data += (tbTextNote.Text + stringSplit);
            data += (cbbFontFamily.Text + "," + cbbFontSize.Text + ",");

            Color c = tbTextNote.ForeColor;
            data += (c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ",");

            Font fnt = tbTextNote.Font;
            data += (fnt.Bold.ToString() + "," + fnt.Italic.ToString() + "," + fnt.Underline.ToString());

            string fileName = FileDB.Inst.DataPath + "\\" + _sumNote;
            FileDB.Inst.writeFile(fileName, data);


            addSuccess = true;
            this.Close();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            ColorDialog clDl = new ColorDialog();
            if (clDl.ShowDialog() == DialogResult.OK)
            {
                tbTextNote.ForeColor = clDl.Color;
                btnFont.BackColor = clDl.Color;
            }
        }

        private void frmAddNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AddNote != null)
            {
                AddNote(addSuccess);
            }

        }
    }
}
