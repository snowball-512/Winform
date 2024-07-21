namespace TinhTienBanSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSV = new System.Windows.Forms.CheckBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKT = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongsv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongKh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSV);
            this.groupBox1.Controls.Add(this.txtTT);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtTenkh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn:";
            // 
            // chkSV
            // 
            this.chkSV.AutoSize = true;
            this.chkSV.Location = new System.Drawing.Point(165, 150);
            this.chkSV.Name = "chkSV";
            this.chkSV.Size = new System.Drawing.Size(15, 14);
            this.chkSV.TabIndex = 7;
            this.chkSV.UseVisualStyleBackColor = true;
            this.chkSV.CheckedChanged += new System.EventHandler(this.chkSV_CheckedChanged);
            // 
            // txtTT
            // 
            this.txtTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTT.Location = new System.Drawing.Point(165, 191);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(282, 23);
            this.txtTT.TabIndex = 6;
            this.txtTT.TextChanged += new System.EventHandler(this.txtTT_TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(165, 98);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(282, 23);
            this.txtSL.TabIndex = 5;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(165, 44);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(282, 23);
            this.txtTenkh.TabIndex = 4;
            this.txtTenkh.TextChanged += new System.EventHandler(this.txtTenkh_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thành Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khách Hàng là SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKT);
            this.groupBox2.Controls.Add(this.btnTk);
            this.groupBox2.Controls.Add(this.btnTiep);
            this.groupBox2.Controls.Add(this.btnTT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnKT
            // 
            this.btnKT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKT.Location = new System.Drawing.Point(383, 22);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(115, 42);
            this.btnKT.TabIndex = 3;
            this.btnKT.Text = "Kết Thúc";
            this.btnKT.UseVisualStyleBackColor = true;
            this.btnKT.Click += new System.EventHandler(this.btnKT_Click);
            // 
            // btnTk
            // 
            this.btnTk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTk.Location = new System.Drawing.Point(262, 22);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(115, 42);
            this.btnTk.TabIndex = 2;
            this.btnTk.Text = "Thống Kê";
            this.btnTk.UseVisualStyleBackColor = true;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTiep.Location = new System.Drawing.Point(141, 22);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(115, 42);
            this.btnTiep.TabIndex = 1;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnTT
            // 
            this.btnTT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTT.Location = new System.Drawing.Point(20, 23);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(115, 42);
            this.btnTT.TabIndex = 0;
            this.btnTT.Text = "Thanh Toán";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongDT);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTongsv);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTongKh);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống Kê:";
            // 
            // txtTongDT
            // 
            this.txtTongDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongDT.Location = new System.Drawing.Point(165, 114);
            this.txtTongDT.Name = "txtTongDT";
            this.txtTongDT.Size = new System.Drawing.Size(282, 23);
            this.txtTongDT.TabIndex = 12;
            this.txtTongDT.TextChanged += new System.EventHandler(this.txtTongDT_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tổng doanh thu:";
            // 
            // txtTongsv
            // 
            this.txtTongsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongsv.Location = new System.Drawing.Point(165, 67);
            this.txtTongsv.Name = "txtTongsv";
            this.txtTongsv.Size = new System.Drawing.Size(282, 23);
            this.txtTongsv.TabIndex = 10;
            this.txtTongsv.TextChanged += new System.EventHandler(this.txtTongsv_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tổng số KH là SV:";
            // 
            // txtTongKh
            // 
            this.txtTongKh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongKh.Location = new System.Drawing.Point(165, 22);
            this.txtTongKh.Name = "txtTongKh";
            this.txtTongKh.Size = new System.Drawing.Size(282, 23);
            this.txtTongKh.TabIndex = 8;
            this.txtTongKh.TextChanged += new System.EventHandler(this.txtTongKh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tổng số KH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TIỀN BÁN SÁCH";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKT;
            this.ClientSize = new System.Drawing.Size(542, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSV;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Button btnKT;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.TextBox txtTongDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongsv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongKh;
        private System.Windows.Forms.Label label6;
    }
}

