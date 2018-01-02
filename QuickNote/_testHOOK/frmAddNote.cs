using _testHOOK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class frmAddNote : Form
    {
        private FontFamily[] Families { get; }
        private bool addSuccess = false;
        private int _sumNote = 0;
        /// <summary>
        /// set numbers of suggested tags in new note 
        /// </summary>
        private int _suggTag=0;
        private List<TagNote> _listTag = new List<TagNote>();
        /// <summary>
        /// delegate addnote successfull
        /// </summary>
        /// <param name="b"></param>
        public delegate void AddNoteHandler(bool b);
        public AddNoteHandler AddNote;
        /// <summary>
        /// this form contructor
        /// </summary>
        /// <param name="noteSum"></param>
        /// <param name="suggestTag"></param>
        public frmAddNote(int noteSum,int suggTag, List<TagNote> listTag)
        {

            InitializeComponent();
            _sumNote = noteSum;
            _listTag = new List<TagNote>(listTag);
            _suggTag = suggTag;
        }

        private void frmAddNote_Load(object sender, EventArgs e)
        {
            this.ptb.Hide();
            this.ptb.Enabled = false;
            foreach (FontFamily item in FontFamily.Families)
            {
                cbbFontFamily.Items.Add(item.Name);
            }
            cbbFontSize.Text = tbTextNote.Font.Size.ToString();
            cbbFontFamily.Text = tbTextNote.Font.FontFamily.Name;

            // set text (suggest tags) for tbAddTag
            if (_listTag.Count < 1)
            {
                return;
            }
            _listTag.Sort((x, y) => y.NAppFre.CompareTo(x.NAppFre));

            for (int i = 0; i < _listTag.Count && i < _suggTag; i++)
            {
                tbAddTag.Text += _listTag[i].Tag + ", ";
            }
            if (tbAddTag.Text.Length < 2)
            {
                return;
            }
            tbAddTag.Text = tbAddTag.Text.Remove(tbAddTag.Text.Length - 2);

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
            string tags = "";
            string title = "";
            string textNote = "";
            Color cl = tbTextNote.ForeColor;
            Font fnt = tbTextNote.Font;
            string fntFam = "";
            string fntSize = "";
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
                        tags = "None";
                    }
                    else
                    {
                        tags = tbAddTag.Text;
                    }
                    if (tbAddTitle.Text == "")
                    {
                        title = "None";
                    }
                    else
                    {
                        title = tbAddTitle.Text;
                    }

                }
                else
                {
                    return;
                }
            }
            else
            {
                tags = tbAddTag.Text;
                title = tbAddTitle.Text;
            }
            textNote = tbTextNote.Text;

            fntFam = cbbFontFamily.Text;
            fntSize = cbbFontSize.Text;


            ANote note = new ANote(_sumNote.ToString(), title, textNote, tags, cl, fnt, fntFam, fntSize);

            FileDB.Inst.writeANote(_sumNote, note);

            addSuccess = true;
            this.Close();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AddNote != null)
            {
                AddNote(addSuccess);
            }

        }

        private void pnColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog clDl = new ColorDialog();
            if (clDl.ShowDialog() == DialogResult.OK)
            {
                tbTextNote.ForeColor = clDl.Color;
                btnColor.BackColor = clDl.Color;
            }
        }

        private void pnColor_MouseMove(object sender, MouseEventArgs e)
        {
            pnColor.BackColor = Color.Silver;
            btnFont.BackColor = Color.Silver;

        }

        private void pnColor_MouseLeave(object sender, EventArgs e)
        {
            pnColor.BackColor = Color.White;
            btnFont.BackColor = Color.White;

        }

        private void tbAddTag_TextChanged(object sender, EventArgs e)
        {
               tbAddTag.ForeColor = Color.Black;
               tt.SetToolTip(tbAddTag, "Types the multiple tags, seperated by commas and space, ex: (“Note, Tags, Title”)");
         
        }

        private void tbAddTag_KeyDown(object sender, KeyEventArgs e)
        {
     
            //if (tbAddTag.Text == _listTag.)
            //{
            //    if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            //    {
            //        tbAddTag.Text = "";
            //    }
            //}
        }

        private void tbAddTag_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Oemcomma)
                {
                    tbAddTag.Text += " ";
                    tbAddTag.SelectionStart = tbAddTag.Text.Length;

                }
            }
            catch { }
        }

        private void btnInsertPic_Click(object sender, EventArgs e)
        {
            ptb.Enabled = !ptb.Enabled;
            if (ptb.Enabled)
            {
                ptb.Show();
            }
            else
            {
                ptb.Hide();
            }
        }
    }

}
