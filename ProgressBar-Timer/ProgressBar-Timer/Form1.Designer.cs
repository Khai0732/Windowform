namespace ProgressBar_Timer
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
            lbl_gio = new Label();
            lbl_ngaythang = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnHienthi = new Button();
            progressBar1 = new ProgressBar();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lbl_complete = new Label();
            SuspendLayout();
            // 
            // lbl_gio
            // 
            lbl_gio.AutoSize = true;
            lbl_gio.Location = new Point(245, 35);
            lbl_gio.Name = "lbl_gio";
            lbl_gio.Size = new Size(59, 25);
            lbl_gio.TabIndex = 0;
            lbl_gio.Text = "label1";
            // 
            // lbl_ngaythang
            // 
            lbl_ngaythang.AutoSize = true;
            lbl_ngaythang.Location = new Point(477, 35);
            lbl_ngaythang.Name = "lbl_ngaythang";
            lbl_ngaythang.Size = new Size(59, 25);
            lbl_ngaythang.TabIndex = 0;
            lbl_ngaythang.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnHienthi
            // 
            btnHienthi.Location = new Point(94, 114);
            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(174, 34);
            btnHienthi.TabIndex = 1;
            btnHienthi.Text = "Hiển thị ngày giờ";
            btnHienthi.UseVisualStyleBackColor = true;
            btnHienthi.Click += btnHienthi_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(335, 117);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(363, 34);
            progressBar1.TabIndex = 2;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 37);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 3;
            label1.Text = "Bây giờ là:";
            // 
            // lbl_complete
            // 
            lbl_complete.AutoSize = true;
            lbl_complete.Location = new Point(459, 78);
            lbl_complete.Name = "lbl_complete";
            lbl_complete.Size = new Size(59, 25);
            lbl_complete.TabIndex = 4;
            lbl_complete.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_complete);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btnHienthi);
            Controls.Add(lbl_ngaythang);
            Controls.Add(lbl_gio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_gio;
        private Label lbl_ngaythang;
        private System.Windows.Forms.Timer timer1;
        private Button btnHienthi;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private Label lbl_complete;
    }
}
