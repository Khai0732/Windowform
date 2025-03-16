namespace HoTen
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
            lbHovaten = new Label();
            txtHovaten = new TextBox();
            btnHienthi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lbHovaten
            // 
            lbHovaten.AutoSize = true;
            lbHovaten.Location = new Point(72, 65);
            lbHovaten.Name = "lbHovaten";
            lbHovaten.Size = new Size(90, 25);
            lbHovaten.TabIndex = 0;
            lbHovaten.Text = "Họ và Tên";
            // 
            // txtHovaten
            // 
            txtHovaten.Location = new Point(210, 59);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(377, 31);
            txtHovaten.TabIndex = 1;
            // 
            // btnHienthi
            // 
            btnHienthi.Location = new Point(252, 142);
            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(112, 34);
            btnHienthi.TabIndex = 2;
            btnHienthi.Text = "Hiển Thị";
            btnHienthi.UseVisualStyleBackColor = true;
            btnHienthi.Click += btnHienthi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(445, 142);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnHienthi);
            Controls.Add(txtHovaten);
            Controls.Add(lbHovaten);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHovaten;
        private TextBox txtHovaten;
        private Button btnHienthi;
        private Button btnThoat;
    }
}
