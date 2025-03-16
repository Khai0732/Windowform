using System.Text;

namespace frmEmployeeDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EmployeeID = txtEmployeeID.Text;
            string EmployeeName = txtEmployeeName.Text;
            string Phone = mtxtPhone.Text;
            string Gender = (rdFemale.Checked ? "Female" : "Male");
            string Degree = cboDegree.Text;
            StringBuilder builder = new StringBuilder();
            builder.Append($"EmployeeID: {EmployeeID}\n");
            builder.Append($"EmployeeName: {EmployeeName}\n");
            builder.Append($"Phone:{Phone}\n");
            builder.Append($"Gender: {Gender}\n");
            builder.Append($"Degree: {Degree}");
            MessageBox.Show(builder.ToString(), "Employee Details");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
