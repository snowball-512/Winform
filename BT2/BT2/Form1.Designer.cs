namespace BT2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtht = new System.Windows.Forms.TextBox();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.chkGT = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNN = new System.Windows.Forms.CheckBox();
            this.chkLT = new System.Windows.Forms.CheckBox();
            this.chkPT = new System.Windows.Forms.CheckBox();
            this.chkKhac = new System.Windows.Forms.CheckBox();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtfull = new System.Windows.Forms.RichTextBox();
            this.lblht = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // txtht
            // 
            this.txtht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtht.Location = new System.Drawing.Point(16, 39);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(296, 29);
            this.txtht.TabIndex = 2;
            // 
            // dtNS
            // 
            this.dtNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNS.Location = new System.Drawing.Point(16, 152);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(368, 29);
            this.dtNS.TabIndex = 3;
            // 
            // chkGT
            // 
            this.chkGT.AutoSize = true;
            this.chkGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGT.Location = new System.Drawing.Point(529, 39);
            this.chkGT.Name = "chkGT";
            this.chkGT.Size = new System.Drawing.Size(142, 28);
            this.chkGT.TabIndex = 4;
            this.chkGT.Text = "Giới tính Nam";
            this.chkGT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMon);
            this.groupBox1.Controls.Add(this.chkKhac);
            this.groupBox1.Controls.Add(this.chkPT);
            this.groupBox1.Controls.Add(this.chkLT);
            this.groupBox1.Controls.Add(this.chkNN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 302);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học yêu thích:";
            // 
            // chkNN
            // 
            this.chkNN.AutoSize = true;
            this.chkNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNN.Location = new System.Drawing.Point(22, 30);
            this.chkNN.Name = "chkNN";
            this.chkNN.Size = new System.Drawing.Size(185, 28);
            this.chkNN.TabIndex = 6;
            this.chkNN.Text = "Ngôn ngữ lập trình";
            this.chkNN.UseVisualStyleBackColor = true;
            // 
            // chkLT
            // 
            this.chkLT.AutoSize = true;
            this.chkLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLT.Location = new System.Drawing.Point(22, 87);
            this.chkLT.Name = "chkLT";
            this.chkLT.Size = new System.Drawing.Size(185, 28);
            this.chkLT.TabIndex = 7;
            this.chkLT.Text = "Lập trình nâng cao";
            this.chkLT.UseVisualStyleBackColor = true;
            // 
            // chkPT
            // 
            this.chkPT.AutoSize = true;
            this.chkPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPT.Location = new System.Drawing.Point(22, 144);
            this.chkPT.Name = "chkPT";
            this.chkPT.Size = new System.Drawing.Size(275, 28);
            this.chkPT.TabIndex = 8;
            this.chkPT.Text = "Phân tích thiết kế và hệ thống";
            this.chkPT.UseVisualStyleBackColor = true;
            // 
            // chkKhac
            // 
            this.chkKhac.AutoSize = true;
            this.chkKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKhac.Location = new System.Drawing.Point(22, 201);
            this.chkKhac.Name = "chkKhac";
            this.chkKhac.Size = new System.Drawing.Size(149, 28);
            this.chkKhac.TabIndex = 9;
            this.chkKhac.Text = "Môn học khác";
            this.chkKhac.UseVisualStyleBackColor = true;
            this.chkKhac.CheckedChanged += new System.EventHandler(this.chkKhac_CheckedChanged);
            // 
            // txtMon
            // 
            this.txtMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMon.Location = new System.Drawing.Point(33, 257);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(350, 29);
            this.txtMon.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(471, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnh
            // 
            this.btnAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.Location = new System.Drawing.Point(846, 593);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(136, 44);
            this.btnAnh.TabIndex = 7;
            this.btnAnh.Text = "Chọn ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(998, 593);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(132, 44);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Cập nhật";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtfull
            // 
            this.txtfull.Enabled = false;
            this.txtfull.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfull.Location = new System.Drawing.Point(6, 643);
            this.txtfull.Name = "txtfull";
            this.txtfull.Size = new System.Drawing.Size(1427, 148);
            this.txtfull.TabIndex = 10;
            this.txtfull.Text = "";
            // 
            // lblht
            // 
            this.lblht.AutoSize = true;
            this.lblht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblht.Location = new System.Drawing.Point(952, 449);
            this.lblht.Name = "lblht";
            this.lblht.Size = new System.Drawing.Size(0, 24);
            this.lblht.TabIndex = 11;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1442, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(29, 707);
            this.vScrollBar1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1212, 544);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lblht);
            this.Controls.Add(this.txtfull);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkGT);
            this.Controls.Add(this.dtNS);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.CheckBox chkGT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.CheckBox chkKhac;
        private System.Windows.Forms.CheckBox chkPT;
        private System.Windows.Forms.CheckBox chkLT;
        private System.Windows.Forms.CheckBox chkNN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.RichTextBox txtfull;
        private System.Windows.Forms.Label lblht;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

