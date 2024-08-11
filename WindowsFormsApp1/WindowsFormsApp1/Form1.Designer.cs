namespace WindowsFormsApp1
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
            this.txxta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblHieu = new System.Windows.Forms.Label();
            this.lblTich = new System.Windows.Forms.Label();
            this.lblThuong = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính toán với số nguyên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hiệu a-b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng a+b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tích a*b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thương a/b";
            // 
            // txxta
            // 
            this.txxta.Location = new System.Drawing.Point(194, 66);
            this.txxta.Multiline = true;
            this.txxta.Name = "txxta";
            this.txxta.Size = new System.Drawing.Size(292, 32);
            this.txxta.TabIndex = 7;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(194, 120);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(292, 32);
            this.txtb.TabIndex = 8;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(135, 173);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(0, 13);
            this.lblTong.TabIndex = 9;
            // 
            // lblHieu
            // 
            this.lblHieu.AutoSize = true;
            this.lblHieu.Location = new System.Drawing.Point(135, 224);
            this.lblHieu.Name = "lblHieu";
            this.lblHieu.Size = new System.Drawing.Size(0, 13);
            this.lblHieu.TabIndex = 10;
            // 
            // lblTich
            // 
            this.lblTich.AutoSize = true;
            this.lblTich.Location = new System.Drawing.Point(135, 282);
            this.lblTich.Name = "lblTich";
            this.lblTich.Size = new System.Drawing.Size(0, 13);
            this.lblTich.TabIndex = 11;
            // 
            // lblThuong
            // 
            this.lblThuong.AutoSize = true;
            this.lblThuong.Location = new System.Drawing.Point(135, 334);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(0, 13);
            this.lblThuong.TabIndex = 12;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(590, 73);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(98, 40);
            this.btnTinh.TabIndex = 13;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(590, 115);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(98, 40);
            this.btnout.TabIndex = 14;
            this.btnout.Text = "Thoát";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 381);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblThuong);
            this.Controls.Add(this.lblTich);
            this.Controls.Add(this.lblHieu);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txxta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txxta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblHieu;
        private System.Windows.Forms.Label lblTich;
        private System.Windows.Forms.Label lblThuong;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnout;
    }
}

