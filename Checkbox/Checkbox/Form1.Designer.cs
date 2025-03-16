namespace Checkbox
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
            gbMau = new GroupBox();
            rdoDo = new RadioButton();
            rdoTrang = new RadioButton();
            rdoVang = new RadioButton();
            rdoHong = new RadioButton();
            rdoTim = new RadioButton();
            gbSothich = new GroupBox();
            chkNghenhac = new CheckBox();
            chkXemphim = new CheckBox();
            chkChoithethao = new CheckBox();
            chkDimuasam = new CheckBox();
            chkDidulich = new CheckBox();
            btnSothichcuaban = new Button();
            btnMaubanthich = new Button();
            gbMau.SuspendLayout();
            gbSothich.SuspendLayout();
            SuspendLayout();
            // 
            // gbMau
            // 
            gbMau.Controls.Add(rdoDo);
            gbMau.Controls.Add(rdoTrang);
            gbMau.Controls.Add(rdoVang);
            gbMau.Controls.Add(rdoHong);
            gbMau.Controls.Add(rdoTim);
            gbMau.Location = new Point(390, 42);
            gbMau.Name = "gbMau";
            gbMau.Size = new Size(300, 319);
            gbMau.TabIndex = 0;
            gbMau.TabStop = false;
            gbMau.Text = "Màu bạn thích";
            // 
            // rdoDo
            // 
            rdoDo.AutoSize = true;
            rdoDo.Location = new Point(47, 48);
            rdoDo.Name = "rdoDo";
            rdoDo.Size = new Size(61, 29);
            rdoDo.TabIndex = 0;
            rdoDo.TabStop = true;
            rdoDo.Text = "Đỏ";
            rdoDo.UseVisualStyleBackColor = true;
            // 
            // rdoTrang
            // 
            rdoTrang.AutoSize = true;
            rdoTrang.Location = new Point(47, 101);
            rdoTrang.Name = "rdoTrang";
            rdoTrang.Size = new Size(80, 29);
            rdoTrang.TabIndex = 0;
            rdoTrang.TabStop = true;
            rdoTrang.Text = "Trắng";
            rdoTrang.UseVisualStyleBackColor = true;
            // 
            // rdoVang
            // 
            rdoVang.AutoSize = true;
            rdoVang.Location = new Point(47, 154);
            rdoVang.Name = "rdoVang";
            rdoVang.Size = new Size(77, 29);
            rdoVang.TabIndex = 0;
            rdoVang.TabStop = true;
            rdoVang.Text = "Vàng";
            rdoVang.UseVisualStyleBackColor = true;
            // 
            // rdoHong
            // 
            rdoHong.AutoSize = true;
            rdoHong.Location = new Point(47, 207);
            rdoHong.Name = "rdoHong";
            rdoHong.Size = new Size(82, 29);
            rdoHong.TabIndex = 0;
            rdoHong.TabStop = true;
            rdoHong.Text = "Hồng";
            rdoHong.UseVisualStyleBackColor = true;
            // 
            // rdoTim
            // 
            rdoTim.AutoSize = true;
            rdoTim.Location = new Point(47, 260);
            rdoTim.Name = "rdoTim";
            rdoTim.Size = new Size(66, 29);
            rdoTim.TabIndex = 0;
            rdoTim.TabStop = true;
            rdoTim.Text = "Tím";
            rdoTim.UseVisualStyleBackColor = true;
            // 
            // gbSothich
            // 
            gbSothich.Controls.Add(chkNghenhac);
            gbSothich.Controls.Add(chkXemphim);
            gbSothich.Controls.Add(chkChoithethao);
            gbSothich.Controls.Add(chkDimuasam);
            gbSothich.Controls.Add(chkDidulich);
            gbSothich.Location = new Point(37, 42);
            gbSothich.Name = "gbSothich";
            gbSothich.Size = new Size(300, 319);
            gbSothich.TabIndex = 0;
            gbSothich.TabStop = false;
            gbSothich.Text = "Sở thích của bạn";
            // 
            // chkNghenhac
            // 
            chkNghenhac.AutoSize = true;
            chkNghenhac.Location = new Point(29, 48);
            chkNghenhac.Name = "chkNghenhac";
            chkNghenhac.Size = new Size(123, 29);
            chkNghenhac.TabIndex = 0;
            chkNghenhac.Text = "Nghe nhạc";
            chkNghenhac.UseVisualStyleBackColor = true;
            // 
            // chkXemphim
            // 
            chkXemphim.AutoSize = true;
            chkXemphim.Location = new Point(29, 101);
            chkXemphim.Name = "chkXemphim";
            chkXemphim.Size = new Size(120, 29);
            chkXemphim.TabIndex = 0;
            chkXemphim.Text = "Xem phim";
            chkXemphim.UseVisualStyleBackColor = true;
            // 
            // chkChoithethao
            // 
            chkChoithethao.AutoSize = true;
            chkChoithethao.Location = new Point(29, 154);
            chkChoithethao.Name = "chkChoithethao";
            chkChoithethao.Size = new Size(145, 29);
            chkChoithethao.TabIndex = 0;
            chkChoithethao.Text = "Chơi thể thao";
            chkChoithethao.UseVisualStyleBackColor = true;
            // 
            // chkDimuasam
            // 
            chkDimuasam.AutoSize = true;
            chkDimuasam.Location = new Point(29, 207);
            chkDimuasam.Name = "chkDimuasam";
            chkDimuasam.Size = new Size(133, 29);
            chkDimuasam.TabIndex = 0;
            chkDimuasam.Text = "Đi mua sắm";
            chkDimuasam.UseVisualStyleBackColor = true;
            // 
            // chkDidulich
            // 
            chkDidulich.AutoSize = true;
            chkDidulich.Location = new Point(29, 260);
            chkDidulich.Name = "chkDidulich";
            chkDidulich.Size = new Size(112, 29);
            chkDidulich.TabIndex = 0;
            chkDidulich.Text = "Đi du lịch";
            chkDidulich.UseVisualStyleBackColor = true;
            // 
            // btnSothichcuaban
            // 
            btnSothichcuaban.Location = new Point(91, 390);
            btnSothichcuaban.Name = "btnSothichcuaban";
            btnSothichcuaban.Size = new Size(177, 34);
            btnSothichcuaban.TabIndex = 1;
            btnSothichcuaban.Text = "Sở thích của bạn";
            btnSothichcuaban.UseVisualStyleBackColor = true;
            btnSothichcuaban.Click += btnSothichcuaban_Click;
            // 
            // btnMaubanthich
            // 
            btnMaubanthich.Location = new Point(474, 390);
            btnMaubanthich.Name = "btnMaubanthich";
            btnMaubanthich.Size = new Size(158, 34);
            btnMaubanthich.TabIndex = 1;
            btnMaubanthich.Text = "Màu bạn thích";
            btnMaubanthich.UseVisualStyleBackColor = true;
            btnMaubanthich.Click += btnMaubanthich_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMaubanthich);
            Controls.Add(btnSothichcuaban);
            Controls.Add(gbSothich);
            Controls.Add(gbMau);
            Name = "Form1";
            Text = "Form1";
            gbMau.ResumeLayout(false);
            gbMau.PerformLayout();
            gbSothich.ResumeLayout(false);
            gbSothich.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMau;
        private GroupBox gbSothich;
        private CheckBox chkNghenhac;
        private CheckBox chkXemphim;
        private CheckBox chkChoithethao;
        private CheckBox chkDimuasam;
        private CheckBox chkDidulich;
        private RadioButton rdoDo;
        private RadioButton rdoTrang;
        private RadioButton rdoVang;
        private RadioButton rdoHong;
        private RadioButton rdoTim;
        private Button btnSothichcuaban;
        private Button btnMaubanthich;
    }
}
