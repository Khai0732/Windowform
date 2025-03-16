namespace ProgressBar_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            lbl_gio.Text = String.Format("{0:hh:mm:ss tt}", dt);

            lbl_ngaythang.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            progressBar1.Increment(1);

            lbl_complete.Text = "Connecting to from " + progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)

            {

                timer2.Enabled = false;

                frm.ShowDialog();

            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)

            {

                progressBar1.Enabled = false;

                timer2.Start();

                timer1.Start();

            }

            else

            {

                progressBar1.Enabled = true;

                timer2.Stop();

                timer1.Stop();

            }
        }
    }
}
