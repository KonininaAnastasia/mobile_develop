namespace wfaFileExplorer
{
    public partial class Form1 : Form
    {
        private string curDir;

        public string CurDir
        {
            get => curDir;
            private set
            {
                curDir = value;
                edDir.Text = curDir;
            }
        }

        public string SelectItem { get; private set; }

        public Form1()
        {
            InitializeComponent();

            //buBack.Click
            //buForward.Click
            buUp.Click += (s, e) => LoadDir(Directory.GetParent(CurDir).ToString());
            edDir.KeyDown += EdDir_KeyDown;
            buDirSelect.Click += BuDirSelect_Click;

            miVievLargeIcon.Click += (s, e) => lv.View = View.LargeIcon;
            miVievSmalIcon.Click += (s, e) => lv.View = View.SmallIcon;
            miVievList.Click += (s, e) => lv.View = View.List;
            miVievDetails.Click += (s, e) => lv.View = View.Details;
            miVievTile.Click += (s, e) => lv.View = View.Tile;

            //(1)
            //ColumnHeader c1 = new();
            //c1.Text = "Имя";
            //c1.Width = 350;
            //lv.Columns.Add(c1);

            //(2)
            //lv.Columns.Add(new ColumnHeader() { Text = "Имя", Width = 350 });    

            //(3)
            lv.Columns.Add("Имя", 350);
            lv.Columns.Add("Дата изменения", 150);
            lv.Columns.Add("Тип", 100);
            lv.Columns.Add("Размер", 150);

            lv.ItemSelectionChanged += Lv_ItemSelectionChanged;
            lv.DoubleClick += Lv_DoubleClick;
            lv.ContextMenuStrip = contextMenuStrip1;

            this.Text += $": Drivers = {string.Join(" ", Directory.GetLogicalDrives())}";

            foreach (var drive in Directory.GetLogicalDrives())
            {
                treeView1.Nodes.Add(drive);
            }

            treeView1.DoubleClick += TreeView1_DoubleClick;

            //CurDir = "D:/";
            CurDir = Directory.GetCurrentDirectory();
            LoadDir(CurDir);
        }

        private void TreeView1_DoubleClick(object? sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new(treeView1.SelectedNode.FullPath);

            treeView1.BeginUpdate();
            treeView1.SelectedNode.Nodes.Clear();
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeView1.SelectedNode.Nodes.Add(item.FullName, item.Name, 0);
            }
            treeView1.EndUpdate();
            treeView1.SelectedNode.Expand();

            LoadDir(treeView1.SelectedNode.FullPath);
        }

        private void Lv_DoubleClick(object? sender, EventArgs e)
        {
            LoadDir(SelectItem);
        }

        private void Lv_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectItem = Path.Combine(CurDir, e.Item.Text);
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            laStatus.Text = $"Элементов: {lv.Items.Count}, Выбрано: {lv.SelectedItems.Count}";
        }

        private void BuDirSelect_Click(object? sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadDir(dialog.SelectedPath);
            }
        }

        private void EdDir_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDir(edDir.Text);
            }
        }

        private void LoadDir(string newDir)
        {
            DirectoryInfo directoryInfo = new(newDir);

            lv.BeginUpdate();
            lv.Items.Clear();
            foreach (var item in directoryInfo.GetDirectories())
            {
                //(1)
                //lv.Items.Add(item.Name, 0);
                //(2)
                lv.Items.Add(new ListViewItem(
                    new string[] { item.Name, item.LastWriteTime.ToString(), "Папка", "" },
                    0));
            }

            foreach (var item in directoryInfo.GetFiles())
            {
                //(1)
                //lv.Items.Add(item.Name, 1);
                //(2)
                lv.Items.Add(new ListViewItem(
                    new string[] { item.Name, item.LastWriteTime.ToString(), "Файл" + item.Extension, item.Length.ToString() + " байт" },
                    1));
            }
            lv.EndUpdate();
            CurDir = newDir;
        }

    }
}