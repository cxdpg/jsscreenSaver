using jsscreenSaver;
using System;
using System.Windows.Forms;

namespace jscreenSaver
{
    public partial class InfomationForm : Form
    {
        int counter = 0;
        public InfomationForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1500;
            timer1.Start();
            txtAppInfo.WriteLine($"Current time: {DateTimeOffset.Now}");
            txtAppInfo.WriteLine($"Last input time: {InputTimer.GetLastInputTime()}");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                return;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var offset = InputTimer.GetInputIdleTime();
            counter++;
            if (this.Visible)
            {
                txtAppInfo.WriteLine($"{counter,08} Idle time: {offset}");
            }
            if (!jss.scr.Visible && offset.TotalSeconds > jss.userSetting.user_idle_timer)
            {
                jss.scr.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InfomationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
