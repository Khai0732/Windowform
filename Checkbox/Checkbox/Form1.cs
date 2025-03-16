namespace Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSothichcuaban_Click(object sender, EventArgs e)
        {
            string str = "";

            if (chkDimuasam.Checked == true)

            {

                str = chkDimuasam.Text + "\n";

            }

            if (chkNghenhac.Checked == true)

            {

                str = str + chkNghenhac.Text + "\n";

            }

            if (chkChoithethao.Checked == true)

            {

                str = str + chkChoithethao.Text + "\n";

            }

            if (chkXemphim.Checked == true)

            {

                str = str + chkXemphim.Text + "\n";

            }

            if (chkDidulich.Checked == true)

            {

                str = str + chkDidulich.Text;

            }



            if (str.Length > 0)

            {

                MessageBox.Show("Sở thích của bạn là: \n" + str);

            }

            else

            {

                MessageBox.Show("Không có sở thích nào bạn chọn!!");

            }
        }

        private void btnMaubanthich_Click(object sender, EventArgs e)
        {
            string str = "";

            if (rdoDo.Checked == true)

            {

                str = rdoDo.Text + "\n";

            }

            if (rdoHong.Checked == true)

            {

                str = rdoHong.Text + "\n";

            }

            if (rdoTim.Checked == true)

            {

                str = rdoTim.Text + "\n";

            }

            if (rdoTrang.Checked == true)

            {

                str = rdoTrang.Text + "\n";

            }
            
            if (rdoVang.Checked == true)

            {

                str = rdoVang.Text;

            }



            if (str.Length > 0)

            {

                MessageBox.Show("Màu bạn thích là: \n" + str);

            }

            else

            {

                MessageBox.Show("Không có màu nào bạn chọn!!");

            }
        }
    }
}
