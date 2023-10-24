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
        public Form1()
        {
            InitializeComponent();

            //buBack.Click
            //buForward.Click
            buUp.Click += (s, e) => LoadDir(Directory.GetParent(CurDir).ToString());
            //edDir
            //buDirSelect.Click


            //CurDir = "D:/";
            CurDir = Directory.GetCurrentDirectory();
            LoadDir(CurDir);
        }

        private void LoadDir(string newDir)
        {
            DirectoryInfo directoryInfo = new(newDir);

            lv.BeginUpdate();
            lv.Items.Clear();
            foreach (var item in directoryInfo.GetDirectories())
            {
                lv.Items.Add(item.Name, 0);
            }

            foreach (var item in directoryInfo.GetFiles())
            {
                lv.Items.Add(item.Name, 1);
            }
            lv.EndUpdate();
            CurDir = newDir;
        }

    }
}