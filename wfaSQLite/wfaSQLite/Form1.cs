namespace wfaSQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //���������� ����� NuGet ����� sqlite-net

            db = new SQLiteConnection();
        }
    }
}