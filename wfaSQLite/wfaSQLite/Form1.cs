namespace wfaSQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //установить через NuGet пакет sqlite-net

            db = new SQLiteConnection();
        }
    }
}