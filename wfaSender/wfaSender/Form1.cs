namespace wfaSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += ButtonAll_Click;
            button2.Click += ButtonAll_Click;
            checkBox1.Click += ButtonAll_Click;
        }

        private void ButtonAll_Click(object? sender, EventArgs e)
        {
            //MessageBox.Show(button1.Text);
            
            Button? button = (Button)sender;
            MessageBox.Show(button.Text);

            //TODO

        }
    }
}