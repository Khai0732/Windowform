namespace Cong2so
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
            txtSth = new Label();
            txtSothuhai = new TextBox();
            txtTongla = new Label();
            txtKetQua = new TextBox();
            txtSnt = new Label();
            txtSothunhat = new TextBox();
            btnTinhtong = new Button();
            btnNhaplai = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 71);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH CỘNG 2 SỐ";
            // 
            // txtSth
            // 
            txtSth.AutoSize = true;
            txtSth.Location = new Point(65, 201);
            txtSth.Name = "txtSth";
            txtSth.Size = new Size(93, 25);
            txtSth.TabIndex = 1;
            txtSth.Text = "Số thứ hai";
            // 
            // txtSothuhai
            // 
            txtSothuhai.Location = new Point(194, 201);
            txtSothuhai.Name = "txtSothuhai";
            txtSothuhai.Size = new Size(330, 31);
            txtSothuhai.TabIndex = 2;
            // 
            // txtTongla
            // 
            txtTongla.AutoSize = true;
            txtTongla.Location = new Point(65, 280);
            txtTongla.Name = "txtTongla";
            txtTongla.Size = new Size(71, 25);
            txtTongla.TabIndex = 1;
            txtTongla.Text = "Tổng là";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(194, 280);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(330, 31);
            txtKetQua.TabIndex = 2;
            // 
            // txtSnt
            // 
            txtSnt.AutoSize = true;
            txtSnt.Location = new Point(65, 126);
            txtSnt.Name = "txtSnt";
            txtSnt.Size = new Size(105, 25);
            txtSnt.TabIndex = 1;
            txtSnt.Text = "Số thứ nhất";
            // 
            // txtSothunhat
            // 
            txtSothunhat.Location = new Point(194, 120);
            txtSothunhat.Name = "txtSothunhat";
            txtSothunhat.Size = new Size(330, 31);
            txtSothunhat.TabIndex = 2;
            txtSothunhat.TextChanged += txtSothunhat_TextChanged;
            // 
            // btnTinhtong
            // 
            btnTinhtong.Location = new Point(120, 360);
            btnTinhtong.Name = "btnTinhtong";
            btnTinhtong.Size = new Size(112, 34);
            btnTinhtong.TabIndex = 3;
            btnTinhtong.Text = "Tính Tổng";
            btnTinhtong.UseVisualStyleBackColor = true;
            btnTinhtong.Click += btnTinhtong_Click;
            // 
            // btnNhaplai
            // 
            btnNhaplai.Location = new Point(315, 360);
            btnNhaplai.Name = "btnNhaplai";
            btnNhaplai.Size = new Size(112, 34);
            btnNhaplai.TabIndex = 4;
            btnNhaplai.Text = "Nhập lại";
            btnNhaplai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(553, 360);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnNhaplai);
            Controls.Add(btnTinhtong);
            Controls.Add(txtKetQua);
            Controls.Add(txtTongla);
            Controls.Add(txtSothunhat);
            Controls.Add(txtSnt);
            Controls.Add(txtSothuhai);
            Controls.Add(txtSth);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtSth;
        private TextBox txtSothuhai;
        private Label txtTongla;
        private TextBox txtKetQua;
        private Label txtSnt;
        private TextBox txtSothunhat;
        private Button btnTinhtong;
        private Button btnNhaplai;
        private Button btnThoat;
    }
}
