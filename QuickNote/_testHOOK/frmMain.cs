using _testHOOK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuickNote
{
    public partial class frmMain : Form
    {
        #region Formm Main Windows property
        private Keys _key0 = Keys.LControlKey;
        private Keys _key1 = Keys.Space;
        private List<Keys> _ListKeys = new List<Keys>();
        private List<ANote> _listNote = new List<ANote>();
        string[] _listNameFile = null;
        private bool _showMainWindow = false;
        private List<TagNote> _listTag = new List<TagNote>();
        private bool _isSort = true;
        private TreeNode _rootTags = new TreeNode();
        private TreeNode _rootAllTags = new TreeNode();
        private string _idNoteSelected = null;
        public FontFamily[] Families { get; }
        #endregion
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(FileDB.Inst.IconPath + "\\frmMainIcon.ico");
            panelAdd.Hide();
            pnEdit.Hide();
            loadDataCbbFont();
            initsHookKey();
            loadDataTreeView();
            notifyIcon1.ShowBalloonTip(5000, "QuickNote-- was started", "Double click to show window", ToolTipIcon.Info);
            showThisForm(_showMainWindow);
        }
        void loadDataTreeView()
        {
            loadDataNote();
            loadTreeView();

        }
        /// <summary>
        /// change shorcut key 
        /// </summary>
        void selectHookKey()
        {
            if (rdbtnCrlSpace.Checked)
            {
                _key0 = Keys.LControlKey;
                _key1 = Keys.Space;
            }
            else
            {
                _key0 = Keys.LWin;
                _key1 = Keys.Z;
            }
        }
        void initTreeView()
        {
            treeV.AfterSelect += TreeV_AfterSelect;
            treeV.ItemHeight = 20;
            _rootTags.ImageIndex = 0;
            _rootTags.Text = "All Tags";
            _rootAllTags.ImageIndex = 0;
            _rootAllTags.Text = "All Notes       (" + _listNote.Count.ToString() + ")";
        }
        void loadNoteAllTags()
        {
            foreach (ANote note in _listNote)
            {
                _rootAllTags.Nodes.Add(new TreeNode()
                {
                    Text = note.TitleNote,
                    NodeFont = new Font(treeV.Font.FontFamily, 10, FontStyle.Regular),
                    ImageIndex = 1

                }
                      );
            }

        }
        void loadNoteRootTags()
        {
            _rootTags.Nodes.Clear();
            foreach (TagNote tag in _listTag)
            {
                int maxNoteInTag = 0;
                TreeNode root = new TreeNode();
                root.NodeFont = new Font("Arial", 12, FontStyle.Bold);
                foreach (ANote note in _listNote)
                {
                    if (note.Tags.Contains(tag.Tag))
                    {
                        root.Nodes.Add(new TreeNode()
                        {
                            Text = note.TitleNote,
                            NodeFont = new Font(treeV.Font.FontFamily, 10, FontStyle.Regular),
                            ImageIndex = 1
                        }
                        );
                        maxNoteInTag++;
                    }
                }
                root.Text = tag.Tag + "     (" + root.Nodes.Count + ")";
                _rootTags.Nodes.Add(root);
                tag.NAppFre = maxNoteInTag;
            }
        }
        void loadTreeView()
        {

            initTreeView();
            treeV.Nodes.Add(_rootTags);


            initListTag(_isSort);
            if (_listTag != null)
            {
                loadNoteAllTags();
                loadNoteRootTags();

            }
            treeV.Nodes.Add(_rootAllTags);
        }

        private void TreeV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeV_DoubleClick(e, new EventArgs());
        }

        void initListTag(bool isAtoZ)
        {
            foreach (ANote item in _listNote)
            {
                foreach (string tags in item.Tags)
                {
                    bool flag = true;
                    for (int i = 0; i < _listTag.Count; i++)
                    {

                        if (_listTag[i].Tag == tags)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        _listTag.Add(new TagNote(tags, 0));
                    }
                }

            }
            if (isAtoZ)
                _listTag.Sort((x, y) => x.Tag.CompareTo(y.Tag));
            else
                _listTag.Sort((x, y) => y.Tag.CompareTo(x.Tag));
        }
        void initsHookKey()
        {
            KeyBoardHook hooking = new KeyBoardHook();
            hooking.KeyDown += Hooking_KeyDown;
            hooking.KeyUp += Hooking_KeyUp;
        }

        private void Hooking_KeyDown(object sender, KeyEventArgs e)
        {
            _ListKeys.Add(e.KeyCode);
            int count = _ListKeys.Count;
            if (count == 2)
            {
                if (_ListKeys[0] == _key0)
                {
                    if (_ListKeys[1] == _key1)
                    {
                        frmAddNote frmadd = new frmAddNote(_listNote.Count, (int)nmrudSizeSuggestTag.Value, _listTag);
                        this.AddOwnedForm(frmadd);
                        frmadd.AddNote += new frmAddNote.AddNoteHandler(addSuccess);
                        frmadd.Show();
                    }
                }
            }
        }

        private void Hooking_KeyUp(object sender, KeyEventArgs e)
        {
            _ListKeys.Clear();
        }

        private void loadDataNote()
        {
            _listNameFile = FileDB.Inst.ShowFile(FileDB.Inst.NotePath);
            if (_listNameFile.Length > 0)
            {
                foreach (string item in _listNameFile)
                {
                    string fileName = FileDB.Inst.NotePath + "\\" + item;
                    string data = FileDB.Inst.readFile(fileName);
                    string[] tmp = data.Split(new string[] { ";\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (tmp.Length == 4)
                    {
                        string[] tagsArr = tmp[0].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
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
                notifyIcon1.Icon = new Icon(FileDB.Inst.IconPath + "\\Noti0.ico");
                notifyIcon1.Text = "2 click to hide window";
                contextMenuStrip1.Items[0].Text = "Hide window";
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Icon = new Icon(FileDB.Inst.IconPath + "\\Noti1.ico");
                notifyIcon1.Text = "2 click to show window";
                contextMenuStrip1.Items[0].Text = "Show window";
            }
            this.ShowInTaskbar = show;

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
            _showMainWindow = !_showMainWindow;
            showThisForm(_showMainWindow);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _showMainWindow = !_showMainWindow;
            showThisForm(_showMainWindow);
        }
        void addItemToLstView(ANote item)
        {
            ListViewItem tmp = new ListViewItem() { Text = item.TitleNote };
            // Display first 50 char in column text Note on ListView
            tmp.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.TextNote.Substring(0, item.TextNote.Length > 49 ? 50 : item.TextNote.Length));

            tmp.SubItems.Add(new ListViewItem.ListViewSubItem().Text = item.DayCre.ToString("dd/MM/yyyy hh:mm tt"));
            string tags = "";
            foreach (string tg in item.Tags)
            {
                tags += (tg + ", ");
            }

            tags = tags.Remove(tags.Length - 2);
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
        }
        private void treeV_DoubleClick(object sender, EventArgs e)
        {
            panelAdd.Hide();
            pnEdit.Hide();
            _idNoteSelected = null;
            TreeNode tr = treeV.SelectedNode;
            if (tr == null) { return; }
            if (!tr.Name.Equals("_rootTags") && tr.Text != "")
            {
                //set panel when user click on tree view
                foreach (Control item in panelAdd.Controls)
                {
                    if (item.Name != "tbTitle" && item.Name != "tbTag")
                    {
                        item.Text = "";
                    }
                }
                lstV.Items.Clear();
                if (tr.Text.Contains("All Notes"))
                {
                    foreach (ANote allnote in _listNote)
                    {
                        addItemToLstView(allnote);
                    }
                    return;
                }
                foreach (TagNote it in _listTag)
                {
                    string nodeSelected = treeV.SelectedNode.Text;
                    if (nodeSelected.Contains(it.Tag))
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
                            foreach (string tag in item.Tags)
                            {
                                if (it.Tag.Equals(tag))
                                {
                                    addItemToLstView(item);
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
                            tbAddTag.Text += (itm + ", ");
                        }
                        tbAddTag.Text = tbAddTag.Text.Remove(tbAddTag.TextLength - 2);

                        tbTextNote.Font = note.Font;
                        tbTextNote.ForeColor = note.Color;
                        btnColor.BackColor = note.Color;
                        cbbFontFamily.Text = tbTextNote.Font.FontFamily.Name;
                        cbbFontSize.Text = tbTextNote.Font.Size.ToString();
                        _idNoteSelected = note.IdNote;
                        return;
                    }
                }
                return;
            }
        }
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            frmAddNote frmadd = new frmAddNote(_listNote.Count, (int)nmrudSizeSuggestTag.Value, _listTag);
            this.AddOwnedForm(frmadd);
            frmadd.AddNote += new frmAddNote.AddNoteHandler(addSuccess);
            frmadd.Show();
        }
        void addSuccess(bool b)
        {
            if (b)
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
            showToolStripMenuItem_Click(sender, e);
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
            _rootTags.Nodes.Clear();
            _rootAllTags.Nodes.Clear();
            _listNote.Clear();
            _listNameFile = null;
            _listTag.Clear();
            lstV.Items.Clear();
            panelAdd.Hide();
            pnEdit.Hide();

            loadDataTreeView();
        }

        private void pnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tbTextNote.ForeColor = colorDialog1.Color;
                btnColor.BackColor = colorDialog1.Color;
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

        private void btnEdit_Click(object sender, EventArgs e)
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

            ANote note = new ANote(_idNoteSelected, title, textNote, tags, cl, fnt, fntFam, fntSize);
            FileDB.Inst.deleteFile(_idNoteSelected);
            FileDB.Inst.writeANote(Int32.Parse(_idNoteSelected), note);

            btnRefresh_Click(sender, e);
        }

        private void rdbtnCrlSpace_CheckedChanged(object sender, EventArgs e)
        {
            selectHookKey();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            _showMainWindow = !_showMainWindow;
            showThisForm(_showMainWindow);
        }

        private void btnSortTreeV_Click(object sender, EventArgs e)
        {
            _isSort = !_isSort; ;
            initListTag(_isSort);
            loadNoteRootTags();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_listTag.Count < 1 || _listTag == null)
            {
                MessageBox.Show("Data not found !");
                return;
            }
            frmStatistic fS = new frmStatistic(_listTag);
            fS.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QuickNote - Final Project of Windows Programming 2017 FIT HCMUS","Made by Cuong Phi 1512050");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("www.fb.com/ficuong");
            }
            catch
            {
                MessageBox.Show("nficuong@gmail.com","Contact me with email:");
            }
        }

        private void statitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisticToolStripMenuItem_Click(sender, e);
        }
    }
}
