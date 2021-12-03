namespace P5_2_1204039_TestClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void digitalClock1_RaiseTimer1_Tick(object sender, EventArgs e)
        {
            UniversalTimeLabel.Text = DateTime.Now.ToUniversalTime().ToString();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            digitalClock1.Timer1_Enabled = !(digitalClock1.Timer1_Enabled);
        }
    }
}