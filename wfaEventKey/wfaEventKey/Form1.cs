namespace wfaEventKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown; //this ��� ��� ���������� �� �����
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                laText.Text = "������ ������� Enter";
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    laText.Text = "Left";
                    break;

                case Keys.Right:
                    laText.Text = "Right";
                    break;

                case Keys.Up:
                    laText.Text = "Up"; //����� �������� ���, �������� label1, �����, ����� ctrl+R+R
                    break;

                case Keys.Down:
                    laText.Text = "Down";
                    break;

                case Keys.Space:
                    if (e.Shift)
                    {
                        laText.Text = "Shift + Space";
                    }
                    else
                    {
                        laText.Text = "Space";
                    }
                    break;

                case Keys.Z:
                    laText.Text = e.Shift ? "Shift + Z" : "Z";
                    break;

                default:
                    laText.Text = $"������ ������� = {e.KeyCode}";
                    break;

            }
        }
    }
}