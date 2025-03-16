namespace Cong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSothunhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void txtSothuhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSothunhat.Text) + Convert.ToInt32(txtSothuhai.Text);

            txtKetqua.Text = result.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSothunhat.Text) - Convert.ToInt32(txtSothuhai.Text);

            txtKetqua.Text = result.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSothunhat.Text) * Convert.ToInt32(txtSothuhai.Text);

            txtKetqua.Text = result.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            double result = Convert.ToInt32(txtSothunhat.Text) / Convert.ToInt32(txtSothuhai.Text);

            txtKetqua.Text = result.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtSothunhat.Clear();
            txtSothuhai.Clear();
            txtKetqua.Clear();
        }
    }
}
