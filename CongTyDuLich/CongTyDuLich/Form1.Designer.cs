namespace CongTyDuLich
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
            this.txtkh = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtsumday = new System.Windows.Forms.TextBox();
            this.lsshow = new System.Windows.Forms.ListBox();
            this.lsdi = new System.Windows.Forms.ListBox();
            this.lsden = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnres = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.dtdi = new System.Windows.Forms.DateTimePicker();
            this.dtve = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công ty du lịch tâm gà";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa điểm đi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa điểm đến";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày đi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày về";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tổng số ngày";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtkh
            // 
            this.txtkh.Location = new System.Drawing.Point(191, 61);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(242, 20);
            this.txtkh.TabIndex = 1;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(191, 165);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(242, 20);
            this.txtdc.TabIndex = 3;
            // 
            // txtsumday
            // 
            this.txtsumday.Location = new System.Drawing.Point(569, 306);
            this.txtsumday.Name = "txtsumday";
            this.txtsumday.Size = new System.Drawing.Size(199, 20);
            this.txtsumday.TabIndex = 11;
            this.txtsumday.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lsshow
            // 
            this.lsshow.FormattingEnabled = true;
            this.lsshow.Location = new System.Drawing.Point(471, 61);
            this.lsshow.Name = "lsshow";
            this.lsshow.Size = new System.Drawing.Size(297, 225);
            this.lsshow.TabIndex = 12;
            // 
            // lsdi
            // 
            this.lsdi.FormattingEnabled = true;
            this.lsdi.Items.AddRange(new object[] {
            "HCM",
            "Hà Nội",
            "Vũng Tàu"});
            this.lsdi.Location = new System.Drawing.Point(42, 238);
            this.lsdi.Name = "lsdi";
            this.lsdi.Size = new System.Drawing.Size(189, 134);
            this.lsdi.TabIndex = 4;
            // 
            // lsden
            // 
            this.lsden.FormattingEnabled = true;
            this.lsden.Items.AddRange(new object[] {
            "Hàn Quốc",
            "Thái Lan",
            "Úc"});
            this.lsden.Location = new System.Drawing.Point(254, 238);
            this.lsden.Name = "lsden";
            this.lsden.Size = new System.Drawing.Size(189, 134);
            this.lsden.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(477, 369);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 8;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnres
            // 
            this.btnres.Location = new System.Drawing.Point(602, 369);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(75, 23);
            this.btnres.TabIndex = 9;
            this.btnres.Text = "Reset";
            this.btnres.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(713, 369);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 10;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtNgaysinh.Location = new System.Drawing.Point(191, 113);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(242, 20);
            this.dtNgaysinh.TabIndex = 2;
            this.dtNgaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtdi
            // 
            this.dtdi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtdi.Location = new System.Drawing.Point(42, 400);
            this.dtdi.Name = "dtdi";
            this.dtdi.Size = new System.Drawing.Size(189, 20);
            this.dtdi.TabIndex = 6;
            this.dtdi.FormatChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtve
            // 
            this.dtve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtve.Location = new System.Drawing.Point(254, 400);
            this.dtve.Name = "dtve";
            this.dtve.Size = new System.Drawing.Size(189, 20);
            this.dtve.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkh);
            this.Controls.Add(this.dtve);
            this.Controls.Add(this.dtdi);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsden);
            this.Controls.Add(this.lsdi);
            this.Controls.Add(this.lsshow);
            this.Controls.Add(this.txtsumday);
            this.Controls.Add(this.txtdc);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtsumday;
        private System.Windows.Forms.ListBox lsshow;
        private System.Windows.Forms.ListBox lsdi;
        private System.Windows.Forms.ListBox lsden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.DateTimePicker dtdi;
        private System.Windows.Forms.DateTimePicker dtve;
    }
}

