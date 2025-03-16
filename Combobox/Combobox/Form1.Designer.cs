namespace Combobox
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
            lb_doimau = new Label();
            lbChonmau = new Label();
            cbo_color = new ComboBox();
            btn_doimau = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // lb_doimau
            // 
            lb_doimau.AutoSize = true;
            lb_doimau.Font = new Font("Segoe UI", 25F);
            lb_doimau.Location = new Point(178, 41);
            lb_doimau.Name = "lb_doimau";
            lb_doimau.Size = new Size(381, 67);
            lb_doimau.TabIndex = 0;
            lb_doimau.Text = "Chào mừng bạn";
            // 
            // lbChonmau
            // 
            lbChonmau.AutoSize = true;
            lbChonmau.Location = new Point(91, 143);
            lbChonmau.Name = "lbChonmau";
            lbChonmau.Size = new Size(94, 25);
            lbChonmau.TabIndex = 1;
            lbChonmau.Text = "Chọn màu";
            // 
            // cbo_color
            // 
            cbo_color.FormattingEnabled = true;
            cbo_color.Items.AddRange(new object[] { "Yellow", "Red ", "Blue", "Black" });
            cbo_color.Location = new Point(243, 143);
            cbo_color.Name = "cbo_color";
            cbo_color.Size = new Size(365, 33);
            cbo_color.TabIndex = 2;
            cbo_color.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_doimau
            // 
            btn_doimau.Location = new Point(196, 281);
            btn_doimau.Name = "btn_doimau";
            btn_doimau.Size = new Size(112, 34);
            btn_doimau.TabIndex = 3;
            btn_doimau.Text = "Đổi màu";
            btn_doimau.UseVisualStyleBackColor = true;
            btn_doimau.Click += btn_doimau_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(415, 281);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(112, 34);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_doimau);
            Controls.Add(cbo_color);
            Controls.Add(lbChonmau);
            Controls.Add(lb_doimau);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_doimau;
        private Label lbChonmau;
        private ComboBox cbo_color;
        private Button btn_doimau;
        private Button btn_thoat;
    }
}
