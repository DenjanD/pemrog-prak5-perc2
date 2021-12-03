namespace P5_2_1204039
{
    public partial class DigitalClock : UserControl
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        public bool Timer1_Enabled
        {
            get
            {
                return Timer1.Enabled;
            }
            set
            {
                Timer1.Enabled = value;
            }
        }

        //create and expose a LocalTimeLabel_BackColor property
        public Color LocalTimeLabel_BackColor
        {
            get
            {
                return LocalTimeLabel.BackColor;
            }
            set
            {
                LocalTimeLabel.BackColor = value;
            }
        }

        //event handler RaiseTime1_Tick
        public event System.EventHandler RaiseTimer1_Tick;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LocalTimeLabel.Text = System.DateTime.Now.ToString();
            if (RaiseTimer1_Tick != null)
                RaiseTimer1_Tick(sender, e);
        }
    }
}