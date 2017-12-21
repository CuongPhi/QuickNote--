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

namespace _testHOOK
{
    public partial class Form1 : Form
    {
        private List<Keys> _ListKeys = new List<Keys>();
        private List<ANote> _listNote = new List<ANote>();
        string[] _listNameFile = null;
        private string dataPath = Application.StartupPath + @"\DataNote\CurrNote";
        private List<string> _listTag = new List<string>();
        /// <summary>
        /// thread hooking
        /// </summary>
        Thread _thrHook = null;
        UserActivityHook _uAH;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAdd.Hide();
            pnEdit.Hide();
            _thrHook = new Thread(new ThreadStart(initsHookKey));
            _thrHook.Start();
            loadDataTreeView();
            // notifyIcon1.ShowBalloonTip(5000, " ", " ", ToolTipIcon.Info);
            showThisForm(true);
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
            _uAH = new UserActivityHook();
            _uAH.KeyDown += UAH_KeyDown;
            _uAH.KeyUp += _uAH_KeyUp;
        }
        private void loadDataNote()
        {
            _listNameFile = ShowFile(dataPath);
            if (_listNameFile.Length > 0)
            {
                foreach (string item in _listNameFile)
                {
                    string fileName = dataPath + "\\" + item;
                    string data = readFile(fileName);
                    string[] tmp = data.Split(new string[] { ";\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (tmp.Length == 3)
                    {
                        string[] tagsArr = tmp[0].Split(',');
                        List<string> listTag = new List<string>();
                        foreach (string tag in tagsArr)
                        {
                            listTag.Add(tag);
                        }

                        _listNote.Add(new ANote(item, tmp[1], tmp[2], File.GetCreationTime(fileName), listTag));
                    }
                }
            }
        }
        string readFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        void writeFile(string fileName, string text)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    writer.Write(text);
                }
            }
        }
        public string[] ShowFile(string path)
        {
            if (Directory.Exists(path))
            {
                return ProcessDirectory(path); // nếu file tồn tại
            }
            return null;
        }

        public string[] ProcessDirectory(string pathfile)
        {
            string[] fileList = Directory.GetFiles(pathfile);//lay danh sách file cho vao mảng
            string[] ListFileName = new string[fileList.Length]; //danh sach tên file trong thư mục

            //duyet mang file trong thư mục
            for (int i = 0; i < fileList.Length; i++)
            {
                ListFileName[i] = Path.GetFileName(fileList[i]).Trim();
            }
            return ListFileName;
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
                if (_ListKeys[0] == Keys.LWin)
                {
                    if (_ListKeys[1] == Keys.Space)
                    {
                        MessageBox.Show("");
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



        private void treeV_MouseClick(object sender, MouseEventArgs e)
        {
            //TreeViewHitTestInfo hitTest = treeV.HitTest(e.Location);
            //if (hitTest.Location == TreeViewHitTestLocations.PlusMinus)
            //{
            //    lstV.Items.Clear();
            //    foreach (ANote item in _listNote)
            //    {
            //        foreach (var tags in item.Tags)
            //        {
            //            if (hitTest.Node.Text.Contains(tags))
            //            {
            //                ListViewItem tmp = new ListViewItem() { Text = item.TitleNote };
            //                tmp.SubItems.Add(item.TextNote);
            //                tmp.SubItems.Add(item.DayCre.ToString("tt dd/MM/yyyy hh:mm tt"));

            //                lstV.Items.Add(tmp);
            //                break;
            //            }
            //        }
            //    }

            //}

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
                        return;
                    }
                }
                return;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
          
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();

        }
    }
}
