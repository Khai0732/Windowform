namespace Combobox_Listbox
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
            label1 = new Label();
            lbHoten = new Label();
            txtHoten = new TextBox();
            btnNhapthongtin = new Button();
            lstBox_hienthi = new ListBox();
            label3 = new Label();
            txt_hienthi = new TextBox();
            btnxoadangchon = new Button();
            btnxoadau = new Button();
            btnxoacuoi = new Button();
            btnXoatatca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F);
            label1.Location = new Point(128, 29);
            label1.Name = "label1";
            label1.Size = new Size(514, 62);
            label1.TabIndex = 0;
            label1.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            // 
            // lbHoten
            // 
            lbHoten.AutoSize = true;
            lbHoten.Location = new Point(12, 121);
            lbHoten.Name = "lbHoten";
            lbHoten.Size = new Size(66, 25);
            lbHoten.TabIndex = 1;
            lbHoten.Text = "Họ tên";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(84, 121);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(215, 31);
            txtHoten.TabIndex = 2;
            // 
            // btnNhapthongtin
            // 
            btnNhapthongtin.Location = new Point(41, 219);
            btnNhapthongtin.Name = "btnNhapthongtin";
            btnNhapthongtin.Size = new Size(228, 34);
            btnNhapthongtin.TabIndex = 3;
            btnNhapthongtin.Text = "Nhập thông tin";
            btnNhapthongtin.UseVisualStyleBackColor = true;
            btnNhapthongtin.Click += btnNhapthongtin_Click;
            // 
            // lstBox_hienthi
            // 
            lstBox_hienthi.FormattingEnabled = true;
            lstBox_hienthi.ItemHeight = 25;
            lstBox_hienthi.Location = new Point(329, 104);
            lstBox_hienthi.Name = "lstBox_hienthi";
            lstBox_hienthi.Size = new Size(446, 179);
            lstBox_hienthi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 313);
            label3.Name = "label3";
            label3.Size = new Size(227, 25);
            label3.TabIndex = 5;
            label3.Text = "Tổng số người đã khai báo";
            // 
            // txt_hienthi
            // 
            txt_hienthi.Location = new Point(587, 313);
            txt_hienthi.Name = "txt_hienthi";
            txt_hienthi.Size = new Size(188, 31);
            txt_hienthi.TabIndex = 6;
            // 
            // btnxoadangchon
            // 
            btnxoadangchon.Location = new Point(333, 369);
            btnxoadangchon.Name = "btnxoadangchon";
            btnxoadangchon.Size = new Size(223, 34);
            btnxoadangchon.TabIndex = 7;
            btnxoadangchon.Text = "Xóa thông tin đang chọn";
            btnxoadangchon.UseVisualStyleBackColor = true;
            btnxoadangchon.Click += btnxoadangchon_Click;
            // 
            // btnxoadau
            // 
            btnxoadau.Location = new Point(587, 369);
            btnxoadau.Name = "btnxoadau";
            btnxoadau.Size = new Size(188, 34);
            btnxoadau.TabIndex = 7;
            btnxoadau.Text = "Xóa thông tin đầu";
            btnxoadau.UseVisualStyleBackColor = true;
            btnxoadau.Click += btnxoadau_Click;
            // 
            // btnxoacuoi
            // 
            btnxoacuoi.Location = new Point(587, 426);
            btnxoacuoi.Name = "btnxoacuoi";
            btnxoacuoi.Size = new Size(188, 34);
            btnxoacuoi.TabIndex = 7;
            btnxoacuoi.Text = "Xóa thông tin cuối";
            btnxoacuoi.UseVisualStyleBackColor = true;
            btnxoacuoi.Click += btnxoacuoi_Click;
            // 
            // btnXoatatca
            // 
            btnXoatatca.Location = new Point(333, 426);
            btnXoatatca.Name = "btnXoatatca";
            btnXoatatca.Size = new Size(223, 34);
            btnXoatatca.TabIndex = 7;
            btnXoatatca.Text = "Xóa tất cả thông tin";
            btnXoatatca.UseVisualStyleBackColor = true;
            btnXoatatca.Click += btnXoatatca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(btnXoatatca);
            Controls.Add(btnxoadau);
            Controls.Add(btnxoacuoi);
            Controls.Add(btnxoadangchon);
            Controls.Add(txt_hienthi);
            Controls.Add(label3);
            Controls.Add(lstBox_hienthi);
            Controls.Add(btnNhapthongtin);
            Controls.Add(txtHoten);
            Controls.Add(lbHoten);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbHoten;
        private TextBox txtHoten;
        private Button btnNhapthongtin;
        private ListBox lstBox_hienthi;
        private Label label3;
        private TextBox txt_hienthi;
        private Button btnxoadangchon;
        private Button btnxoadau;
        private Button btnxoacuoi;
        private Button btnXoatatca;
    }
}
