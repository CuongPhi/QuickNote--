using gma.System.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class frmMain : Form
    {
        private List<Keys> _ListKeys = new List<Keys>();
        private List<ANote> _listNote = new List<ANote>();
        string[] _listNameFile = null;

        private List<string> _listTag = new List<string>();

        public FontFamily[] Families { get; }
        /// <summary>
        /// thread hooking
        /// </summary>

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAdd.Hide();
            pnEdit.Hide();
            loadDataCbbFont();
            initsHookKey();
            loadDataTreeView();
            notifyIcon1.ShowBalloonTip(5000, " ", " ", ToolTipIcon.Info);
            showThisForm(false);
        }
        void loadDataTreeView()
        {
            loadDataNote();
            loadTreeView();

        }
        void loadTreeView()
        {
            treeV.AfterSelect += TreeV_AfterSelect;

            treeV.ItemHeight = 20;
            TreeNode rootTags = new TreeNode();
            rootTags.ImageIndex = 0;

            rootTags.Text = "All Tags";

            treeV.Nodes.Add(rootTags);

            initListTag();
            if (_listTag != null)
            {
                foreach (string tag in _listTag)
                {
                    TreeNode root = new TreeNode();
                    root.NodeFont = new Font("Arial", 12, FontStyle.Bold);
                    foreach (ANote note in _listNote)
                    {
                        if (note.Tags.Contains(tag))
                        {
                            root.Nodes.Add(new TreeNode()
                            {
                                Text = note.TitleNote,
                                NodeFont = new Font(treeV.Font.FontFamily, 10, FontStyle.Regular),
                                ImageIndex = 1

                            }
                            );
                        }
                    }
                    root.Text = tag + "     (" + root.Nodes.Count + ")";
                    rootTags.Nodes.Add(root);
                }

            }
        }

        private void TreeV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeV_DoubleClick(e, new EventArgs());
        }

        void initListTag()
        {
            foreach (ANote item in _listNote)
            {
                foreach (string tags in item.Tags)
                {
                    bool flag = true;
                    for (int i = 0; i < _listTag.Count; i++)
                    {
                        if (_listTag[i] == tags)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        _listTag.Add(tags);
                    }
                }

            }
        }
        void initsHookKey()
        {
            UserActivityHook _uAH = new UserActivityHook(false, true);
            _uAH.KeyDown += UAH_KeyDown;
            _uAH.KeyUp += _uAH_KeyUp;
        }
        private void loadDataNote()
        {
            _listNameFile = FileDB.Inst.ShowFile(FileDB.Inst.DataPath);
            if (_listNameFile.Length > 0)
            {
                foreach (string item in _listNameFile)
                {
                    string fileName = FileDB.Inst.DataPath + "\\" + item;
                    string data = FileDB.Inst.readFile(fileName);
                    string[] tmp = data.Split(new string[] { ";\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (tmp.Length == 4)
                    {
                        string[] tagsArr = tmp[0].Split(',');
                        List<string> listTag = new List<string>();
                        foreach (string tag in tagsArr)
                        {
                            listTag.Add(tag);
                        }
                        string[] font = tmp[3].Split(',');
                        Color c = Color.FromArgb(120, Int32.Parse(font[2]), Int32.Parse(font[3]), Int32.Parse(font[4]));
                        int fontSize = Int32.Parse(font[1]);
                        bool bold = bool.Parse(font[5]) == true ? true : false;
                        bool Ital = bool.Parse(font[6]) == true ? true : false;
                        bool UnderL = bool.Parse(font[7]) == true ? true : false;

                        FontStyle myfontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                        if (bold || Ital || UnderL)
                        {

                            if (!bold) { myfontStyle = myfontStyle & ~FontStyle.Bold; }
                            if (!Ital) { myfontStyle = myfontStyle & ~FontStyle.Italic; }
                            if (!UnderL) { myfontStyle = myfontStyle & ~FontStyle.Underline; }
                        }
                        else { myfontStyle = FontStyle.Regular; }

                        Font fnt = new Font(font[0], fontSize, myfontStyle);
                        _listNote.Add(new ANote(item, tmp[1], tmp[2], File.GetCreationTime(fileName), listTag, c, fnt));
                    }
                }
            }
            //
        }
        void loadDataCbbFont()
        {
            foreach (FontFamily item in FontFamily.Families)
            {
                cbbFontFamily.Items.Add(item.Name);
            }

        }

        private void showThisForm(bool show)
        {
            if (show)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;

            }
            this.ShowInTaskbar = show;

        }

        private void _uAH_KeyUp(object sender, KeyEventArgs e)
        {
            _ListKeys.Clear();
        }

        private void UAH_KeyDown(object sender, KeyEventArgs e)
        {
            _ListKeys.Add(e.KeyCode);
            int count = _ListKeys.Count;
            if (count == 2)
            {
                if (_ListKeys[0] == Keys.LControlKey)
                {
                    if (_ListKeys[1] == Keys.Space)
                    {
                        frmAddNote frmadd = new frmAddNote(_listNote.Count);
                        this.AddOwnedForm(frmadd);
                        frmadd.AddNote += new frmAddNote.AddNoteHandler(addSuccess);
                        frmadd.Show();
                    }
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showThisForm(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            showThisForm(false);
        }
        private void treeV_DoubleClick(object sender, EventArgs e)
        {
            panelAdd.Hide();
            pnEdit.Hide();
            TreeNode tr = treeV.SelectedNode;
            if (tr == null) { return; }
            if (!tr.Name.Equals("rootTags") && tr.Text != "")
            {

                foreach (Control item in panelAdd.Controls)
                {
                    if (item.Name != "tbTitle" && item.Name != "tbTag")
                    {
                        item.Text = "";
                    }
                }
                lstV.Items.Clear();
                foreach (string it in _listTag)
                {
                    string nodeSelected = treeV.SelectedNode.Text;
                    if (nodeSelected.Contains(it))
                    {
                        foreach (ANote item in _listNote)
                        {
                            if (nodeSelected.Equals(item.TitleNote))
                            {
                                return;
                            }
                        }
                        foreach (ANote item in _listNote)
                        {
                            foreach (var tag in item.Tags)
                            {
                                if (it.Equals(tag))
                                {
                                    ListViewItem tmp = new ListViewItem() { Text = item.TitleNote };

                                    tmp.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.TextNote);
                                    tmp.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.DayCre.ToString("dd/MM/yyyy hh:mm tt"));
                                    string tags = "";
                                    foreach (string tg in item.Tags)
                                    {
                                        tags += (tg + ",");
                                    }

                                    if (tags[tags.Length - 1] == ',')
                                    {
                                        tags = tags.Remove(tags.Length - 1, 1);
                                    }
                                    tmp.SubItems.Add(new ListViewItem.ListViewSubItem().Text = tags);

                                    tmp.Font = new Font(tmp.Font.FontFamily, 11);
                                    tmp.UseItemStyleForSubItems = false;

                                    foreach (ListViewItem.ListViewSubItem sub in tmp.SubItems)
                                    {
                                        if (sub.Text != item.TitleNote)
                                        {
                                            sub.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                                        }
                                    }
                                    lstV.Items.Add(tmp);
                                    break;
                                }
                            }

                        }

                    }
                }
            }

        }

        private void lstV_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAdd.Show();
            pnEdit.Show();
            foreach (ListViewItem item in lstV.SelectedItems)
            {
                tbAddTitle.Text = item.Text;
                foreach (ANote note in _listNote)
                {
                    if (tbAddTitle.Text.Equals(note.TitleNote))
                    {
                        tbTextNote.Text = note.TextNote;
                        tbAddTag.Text = "";
                        foreach (string itm in note.Tags)
                        {
                            tbAddTag.Text += (itm + ",");
                        }
                        if (tbAddTag.Text[tbAddTag.TextLength - 1] == ',')
                        {
                            tbAddTag.Text = tbAddTag.Text.Remove(tbAddTag.TextLength - 1, 1);
                        }
                        cbbFontFamily.Text = tbTextNote.Font.FontFamily.Name;
                        cbbFontSize.Text = tbTextNote.Font.Size.ToString();
                        tbTextNote.Font = note.Font;
                        tbTextNote.ForeColor = note.Color;
                        btnFont.BackColor = note.Color;
                        return;
                    }
                }
                return;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTextNote.ForeColor = colorDialog1.Color;
                btnFont.BackColor = colorDialog1.Color;
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            frmAddNote frmadd = new frmAddNote(_listNote.Count);
            this.AddOwnedForm(frmadd);
            frmadd.AddNote += new frmAddNote.AddNoteHandler(addSuccess);
            frmadd.Show();
        }
        void addSuccess(bool b)
        {
           if(b)
            {
                btnRefresh_Click(new object(), new EventArgs());
            }
        }

        private void Frmadd_AddNote(object sender, EventArgs e)
        {
            
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeV.Nodes.Clear();
            treeV.Refresh();

            _listNote.Clear();
            _listNameFile = null;
            _listTag.Clear();
            loadDataTreeView();
        }
    }
}
