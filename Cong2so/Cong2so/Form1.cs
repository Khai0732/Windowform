namespace Cong2so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhtong_Click(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            try
            {
                so1 = double.Parse(txtSothunhat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập số thứ nhất không đúng \n" + ex.Message);
            }
            try
            {
                so2 = double.Parse(txtSothuhai.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập số thứ hai không đúng \n" + ex.Message);
            }
            //so1= double.Parse(txtSothunhat.Text);
            //so2 = double.Parse(txtSothuhai.Text);
            double tong = so1 + so2;
            txtKetQua.Text = tong.ToString();

        }

        private void txtSothunhat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
