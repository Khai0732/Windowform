using System.Windows.Forms;

namespace Cuasodn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_tendangnhap.Text) || !string.IsNullOrWhiteSpace(txt_matkhau.Text))

            {

                MessageBox.Show("Đăng nhập thành công !!!");

            }

            else

            {

                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");

            }
        }

        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void chk_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienthi.Checked == true)

            {

                txt_matkhau.PasswordChar = (char)0;

            }

            else

            {

                txt_matkhau.PasswordChar = '*';

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_tendangnhap, "Chỉ được nhập ký tự a-z và 0-9");

            toolTip2.SetToolTip(txt_matkhau, "Chỉ được nhập ký tự từ 0-9");

           // helpProvider1.HelpNamespace = "https://plpsoft.vn/30236-Bai-tap-C-Bai-5-Su-dung-ToolTip-HelpProvider-ErrorProvider-trong-C-windows-Form";
        }
    }
}
