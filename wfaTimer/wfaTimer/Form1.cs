namespace wfaTimer
{

    public partial class Form1 : Form
    {
        private const int SEC_MAX = 10;
        private System.Windows.Forms.Timer tmUp = new();
        private DateTime startTimerUp;
        private DateTime pauseTimerUp;

        public Form1()
        {
            InitializeComponent();

            tmUp.Interval = 100; // 1 сек = 1000 мс
            tmUp.Tick += TmUp_Tick; // активирует событие каждую 1 сек
            buUp.Click += Button1_Click;
            buUpPause.Click += BuUpPause_Click;
            pbUpSec.Maximum = SEC_MAX;
            pbUpMs.Maximum = SEC_MAX * 1000;

        }

        private void BuUpPause_Click(object? sender, EventArgs e)
        {
            if (tmUp.Enabled)
            {
                pauseTimerUp = DateTime.Now;
                tmUp.Stop();
            }
            else
            {
                startTimerUp = startTimerUp + (DateTime.Now - pauseTimerUp);
                tmUp.Start();
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            tmUp.Enabled = !tmUp.Enabled; // включаем, когда выключен; выключаем, когда включен
            startTimerUp = DateTime.Now;
        }

        private void TmUp_Tick(object? sender, EventArgs e)
        {
            // (1)
            //buUp.Text = (DateTime.Now - startTimerUp).ToString(@"hh\:mm\:ss\.fff");

            //(2)
            var x = (DateTime.Now - startTimerUp);
            if (x.TotalSeconds > SEC_MAX)
            {
                tmUp.Stop();
                x = TimeSpan.FromSeconds(SEC_MAX);
            }
            buUp.Text = x.ToString(@"hh\:mm\:ss\.fff");
            pbUpSec.Value = (int)x.TotalSeconds;
            pbUpMs.Value = (int)x.TotalMilliseconds;
        }
    }
}