namespace Combobox_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhapthongtin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHoten.Text))

            {

                lstBox_hienthi.Items.Add(txtHoten.Text);

                txt_hienthi.Text = lstBox_hienthi.Items.Count.ToString();

                txtHoten.Clear();

                txtHoten.Focus();

            }

            else

                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private void btnxoadangchon_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);

            if (lstBox_hienthi.SelectedItems.Count != 0)

            {

                lstBox_hienthi.Items.Remove(lstBox_hienthi.SelectedItems[0]);

            }

            txt_hienthi.Text = (a - 1).ToString();
        }

        private void btnxoadau_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);

            lstBox_hienthi.Items.RemoveAt(0);

            txt_hienthi.Text = (a - 1).ToString();
        }



        private void btnxoacuoi_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_hienthi.Text);

            lstBox_hienthi.Items.RemoveAt(lstBox_hienthi.Items.Count - 1);

            txt_hienthi.Text = (a - 1).ToString();
        }

        private void btnXoatatca_Click(object sender, EventArgs e)
        {
            lstBox_hienthi.Items.Clear();

            txt_hienthi.Text = "0";
        }
    }
}
