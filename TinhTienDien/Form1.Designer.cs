namespace TinhTienDien
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtcscu = new System.Windows.Forms.TextBox();
            this.txtdinhmuc = new System.Windows.Forms.TextBox();
            this.txtcsmoi = new System.Windows.Forms.TextBox();
            this.txtsokw = new System.Windows.Forms.TextBox();
            this.txtvuot = new System.Windows.Forms.TextBox();
            this.txtsumtien = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng tính tiền điện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chỉ số cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chỉ số mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Kw tiêu thụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "số kw trong định mức";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "số kw vượt định mức";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Định mức là 50kw";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Trong định mức là 500đ/1kw";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Vượt định mức là 1000đ/1kw";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng tiền phải trả";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtcscu
            // 
            this.txtcscu.Location = new System.Drawing.Point(95, 90);
            this.txtcscu.Name = "txtcscu";
            this.txtcscu.Size = new System.Drawing.Size(75, 20);
            this.txtcscu.TabIndex = 12;
            // 
            // txtdinhmuc
            // 
            this.txtdinhmuc.Location = new System.Drawing.Point(348, 90);
            this.txtdinhmuc.Name = "txtdinhmuc";
            this.txtdinhmuc.Size = new System.Drawing.Size(100, 20);
            this.txtdinhmuc.TabIndex = 13;
            // 
            // txtcsmoi
            // 
            this.txtcsmoi.Location = new System.Drawing.Point(95, 141);
            this.txtcsmoi.Name = "txtcsmoi";
            this.txtcsmoi.Size = new System.Drawing.Size(75, 20);
            this.txtcsmoi.TabIndex = 14;
            this.txtcsmoi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtsokw
            // 
            this.txtsokw.Location = new System.Drawing.Point(95, 177);
            this.txtsokw.Name = "txtsokw";
            this.txtsokw.Size = new System.Drawing.Size(75, 20);
            this.txtsokw.TabIndex = 15;
            this.txtsokw.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtvuot
            // 
            this.txtvuot.Location = new System.Drawing.Point(348, 141);
            this.txtvuot.Name = "txtvuot";
            this.txtvuot.Size = new System.Drawing.Size(100, 20);
            this.txtvuot.TabIndex = 16;
            // 
            // txtsumtien
            // 
            this.txtsumtien.Location = new System.Drawing.Point(12, 252);
            this.txtsumtien.Name = "txtsumtien";
            this.txtsumtien.Size = new System.Drawing.Size(140, 20);
            this.txtsumtien.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(219, 252);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 96);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(12, 304);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 19;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(95, 304);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 417);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtsumtien);
            this.Controls.Add(this.txtvuot);
            this.Controls.Add(this.txtsokw);
            this.Controls.Add(this.txtcsmoi);
            this.Controls.Add(this.txtdinhmuc);
            this.Controls.Add(this.txtcscu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtcscu;
        private System.Windows.Forms.TextBox txtdinhmuc;
        private System.Windows.Forms.TextBox txtcsmoi;
        private System.Windows.Forms.TextBox txtsokw;
        private System.Windows.Forms.TextBox txtvuot;
        private System.Windows.Forms.TextBox txtsumtien;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIn;
    }
}

