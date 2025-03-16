namespace frmEmployeeDetails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            lbEmpID = new Label();
            txtEmployeeID = new TextBox();
            lbDegree = new Label();
            lbPhone = new Label();
            lbEmpName = new Label();
            txtEmployeeName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            gbGender = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            lbGender = new Label();
            cboDegree = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 25F);
            lbTitle.Location = new Point(124, 53);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(405, 67);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Employee Details\r\n";
            // 
            // lbEmpID
            // 
            lbEmpID.AutoSize = true;
            lbEmpID.Location = new Point(68, 162);
            lbEmpID.Name = "lbEmpID";
            lbEmpID.Size = new Size(113, 25);
            lbEmpID.TabIndex = 1;
            lbEmpID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(243, 162);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(376, 31);
            txtEmployeeID.TabIndex = 2;
            // 
            // lbDegree
            // 
            lbDegree.AutoSize = true;
            lbDegree.Location = new Point(68, 462);
            lbDegree.Name = "lbDegree";
            lbDegree.Size = new Size(69, 25);
            lbDegree.TabIndex = 1;
            lbDegree.Text = "Degree";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(68, 322);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(62, 25);
            lbPhone.TabIndex = 1;
            lbPhone.Text = "Phone";
            // 
            // lbEmpName
            // 
            lbEmpName.AutoSize = true;
            lbEmpName.Location = new Point(68, 241);
            lbEmpName.Name = "lbEmpName";
            lbEmpName.Size = new Size(142, 25);
            lbEmpName.TabIndex = 1;
            lbEmpName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(243, 241);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(376, 31);
            txtEmployeeName.TabIndex = 2;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(243, 316);
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(376, 31);
            mtxtPhone.TabIndex = 3;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdFemale);
            gbGender.Controls.Add(rdMale);
            gbGender.Location = new Point(243, 375);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(376, 62);
            gbGender.TabIndex = 4;
            gbGender.TabStop = false;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(211, 24);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(93, 29);
            rdFemale.TabIndex = 0;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(16, 24);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(75, 29);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(68, 399);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(69, 25);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            // 
            // cboDegree
            // 
            cboDegree.FormattingEnabled = true;
            cboDegree.Items.AddRange(new object[] { "Engineer" });
            cboDegree.Location = new Point(243, 462);
            cboDegree.Name = "cboDegree";
            cboDegree.Size = new Size(376, 33);
            cboDegree.TabIndex = 6;
            cboDegree.SelectedIndexChanged += cboDegree_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(244, 522);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(454, 522);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 587);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboDegree);
            Controls.Add(lbGender);
            Controls.Add(gbGender);
            Controls.Add(mtxtPhone);
            Controls.Add(txtEmployeeName);
            Controls.Add(lbEmpName);
            Controls.Add(lbPhone);
            Controls.Add(lbDegree);
            Controls.Add(txtEmployeeID);
            Controls.Add(lbEmpID);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Form1";
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbEmpID;
        private TextBox txtEmployeeID;
        private Label lbDegree;
        private Label lbPhone;
        private Label lbEmpName;
        private TextBox txtEmployeeName;
        private MaskedTextBox mtxtPhone;
        private GroupBox gbGender;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label lbGender;
        private ComboBox cboDegree;
        private Button btnSave;
        private Button btnCancel;
    }
}
