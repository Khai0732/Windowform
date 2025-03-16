namespace Cong
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
            lbKetqua = new Label();
            txtKetqua = new TextBox();
            lbSothuhai = new Label();
            txtSothuhai = new TextBox();
            lbSothunhat = new Label();
            txtSothunhat = new TextBox();
            btncong = new Button();
            btntru = new Button();
            btnnhan = new Button();
            btnchia = new Button();
            btnxoa = new Button();
            SuspendLayout();
            // 
            // lbKetqua
            // 
            lbKetqua.AutoSize = true;
            lbKetqua.Location = new Point(68, 332);
            lbKetqua.Name = "lbKetqua";
            lbKetqua.Size = new Size(72, 25);
            lbKetqua.TabIndex = 0;
            lbKetqua.Text = "Kết quả";
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(206, 326);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.Size = new Size(355, 31);
            txtKetqua.TabIndex = 1;
            // 
            // lbSothuhai
            // 
            lbSothuhai.AutoSize = true;
            lbSothuhai.Location = new Point(68, 155);
            lbSothuhai.Name = "lbSothuhai";
            lbSothuhai.Size = new Size(93, 25);
            lbSothuhai.TabIndex = 0;
            lbSothuhai.Text = "Số thứ hai";
            // 
            // txtSothuhai
            // 
            txtSothuhai.Location = new Point(206, 149);
            txtSothuhai.Name = "txtSothuhai";
            txtSothuhai.Size = new Size(355, 31);
            txtSothuhai.TabIndex = 1;
            txtSothuhai.KeyPress += txtSothuhai_KeyPress;
            // 
            // lbSothunhat
            // 
            lbSothunhat.AutoSize = true;
            lbSothunhat.Location = new Point(68, 80);
            lbSothunhat.Name = "lbSothunhat";
            lbSothunhat.Size = new Size(105, 25);
            lbSothunhat.TabIndex = 0;
            lbSothunhat.Text = "Số thứ nhất";
            // 
            // txtSothunhat
            // 
            txtSothunhat.Location = new Point(206, 74);
            txtSothunhat.Name = "txtSothunhat";
            txtSothunhat.Size = new Size(355, 31);
            txtSothunhat.TabIndex = 1;
            txtSothunhat.KeyPress += txtSothunhat_KeyPress;
            // 
            // btncong
            // 
            btncong.Location = new Point(79, 240);
            btncong.Name = "btncong";
            btncong.Size = new Size(82, 34);
            btncong.TabIndex = 2;
            btncong.Text = "+";
            btncong.UseVisualStyleBackColor = true;
            btncong.Click += btncong_Click;
            // 
            // btntru
            // 
            btntru.Location = new Point(194, 240);
            btntru.Name = "btntru";
            btntru.Size = new Size(82, 34);
            btntru.TabIndex = 3;
            btntru.Text = "-";
            btntru.UseVisualStyleBackColor = true;
            btntru.Click += btntru_Click;
            // 
            // btnnhan
            // 
            btnnhan.Location = new Point(326, 240);
            btnnhan.Name = "btnnhan";
            btnnhan.Size = new Size(82, 34);
            btnnhan.TabIndex = 3;
            btnnhan.Text = "*";
            btnnhan.UseVisualStyleBackColor = true;
            btnnhan.Click += btnnhan_Click;
            // 
            // btnchia
            // 
            btnchia.Location = new Point(453, 240);
            btnchia.Name = "btnchia";
            btnchia.Size = new Size(82, 34);
            btnchia.TabIndex = 3;
            btnchia.Text = "/";
            btnchia.UseVisualStyleBackColor = true;
            btnchia.Click += btnchia_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(586, 240);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(82, 34);
            btnxoa.TabIndex = 3;
            btnxoa.Text = "Del";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnxoa);
            Controls.Add(btnchia);
            Controls.Add(btnnhan);
            Controls.Add(btntru);
            Controls.Add(btncong);
            Controls.Add(txtSothunhat);
            Controls.Add(lbSothunhat);
            Controls.Add(txtSothuhai);
            Controls.Add(lbSothuhai);
            Controls.Add(txtKetqua);
            Controls.Add(lbKetqua);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbKetqua;
        private TextBox txtKetqua;
        private Label lbSothuhai;
        private TextBox txtSothuhai;
        private Label lbSothunhat;
        private TextBox txtSothunhat;
        private Button btncong;
        private Button btntru;
        private Button btnnhan;
        private Button btnchia;
        private Button btnxoa;
    }
}
