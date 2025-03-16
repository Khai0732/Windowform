namespace Cuasodn
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lb_mk = new Label();
            txt_matkhau = new TextBox();
            lb_tendn = new Label();
            txt_tendangnhap = new TextBox();
            btn_dangnhap = new Button();
            btn_thoat = new Button();
            chk_hienthi = new CheckBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(196, 22);
            label1.Name = "label1";
            label1.Size = new Size(427, 67);
            label1.TabIndex = 0;
            label1.Text = "Cửa sổ đăng nhập";
            // 
            // lb_mk
            // 
            lb_mk.AutoSize = true;
            lb_mk.Location = new Point(97, 184);
            lb_mk.Name = "lb_mk";
            lb_mk.Size = new Size(86, 25);
            lb_mk.TabIndex = 1;
            lb_mk.Text = "Mật khẩu";
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(271, 181);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(253, 31);
            txt_matkhau.TabIndex = 2;
            txt_matkhau.KeyPress += txt_matkhau_KeyPress;
            // 
            // lb_tendn
            // 
            lb_tendn.AutoSize = true;
            lb_tendn.Location = new Point(97, 115);
            lb_tendn.Name = "lb_tendn";
            lb_tendn.Size = new Size(129, 25);
            lb_tendn.TabIndex = 1;
            lb_tendn.Text = "Tên đăng nhập";
            // 
            // txt_tendangnhap
            // 
            txt_tendangnhap.Location = new Point(271, 112);
            txt_tendangnhap.Name = "txt_tendangnhap";
            txt_tendangnhap.Size = new Size(253, 31);
            txt_tendangnhap.TabIndex = 2;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(231, 308);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(112, 34);
            btn_dangnhap.TabIndex = 3;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(412, 308);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(112, 34);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            // 
            // chk_hienthi
            // 
            chk_hienthi.AutoSize = true;
            chk_hienthi.Location = new Point(299, 243);
            chk_hienthi.Name = "chk_hienthi";
            chk_hienthi.Size = new Size(178, 29);
            chk_hienthi.TabIndex = 4;
            chk_hienthi.Text = "Hiển thị mật khẩu";
            chk_hienthi.UseVisualStyleBackColor = true;
            chk_hienthi.CheckedChanged += chk_hienthi_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chk_hienthi);
            Controls.Add(btn_thoat);
            Controls.Add(btn_dangnhap);
            Controls.Add(txt_tendangnhap);
            Controls.Add(lb_tendn);
            Controls.Add(txt_matkhau);
            Controls.Add(lb_mk);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_mk;
        private TextBox txt_matkhau;
        private Label lb_tendn;
        private TextBox txt_tendangnhap;
        private Button btn_dangnhap;
        private Button btn_thoat;
        private CheckBox chk_hienthi;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}
