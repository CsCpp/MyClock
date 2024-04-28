namespace MyClock
{
    public partial class Form1 : Form
    {
        Thread secondsContingThread;
        Thread daysContingThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secondsContingThread = new Thread(new ThreadStart(CountSeconds));
            secondsContingThread.Start();

            daysContingThread=new Thread(new ThreadStart(CountDays));
            daysContingThread.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          CancellationToken.ReferenceEquals(this, secondsContingThread);
          CancellationToken.ReferenceEquals(this, daysContingThread);
           
        }
    }
}
