namespace DichVukhambenh
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.lstChon = new System.Windows.Forms.ListBox();
            this.lstDachon = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnaddall = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.btndelall = new System.Windows.Forms.Button();
            this.btndel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch Vụ Khám Bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chọn dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dịch vụ đã chọn";
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(129, 58);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(337, 20);
            this.txtht.TabIndex = 6;
            // 
            // txtngay
            // 
            this.txtngay.Location = new System.Drawing.Point(52, 115);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(87, 20);
            this.txtngay.TabIndex = 7;
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(216, 115);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(90, 20);
            this.txtthang.TabIndex = 8;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(376, 115);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(90, 20);
            this.txtnam.TabIndex = 9;
            // 
            // lstChon
            // 
            this.lstChon.FormattingEnabled = true;
            this.lstChon.Items.AddRange(new object[] {
            "Siêu âm",
            "Thử máu",
            "Nội soi",
            "X-Quang"});
            this.lstChon.Location = new System.Drawing.Point(16, 223);
            this.lstChon.Name = "lstChon";
            this.lstChon.Size = new System.Drawing.Size(163, 134);
            this.lstChon.TabIndex = 10;
            this.lstChon.SelectedIndexChanged += new System.EventHandler(this.lstChon_SelectedIndexChanged);
            // 
            // lstDachon
            // 
            this.lstDachon.FormattingEnabled = true;
            this.lstDachon.Location = new System.Drawing.Point(272, 223);
            this.lstDachon.Name = "lstDachon";
            this.lstDachon.Size = new System.Drawing.Size(163, 134);
            this.lstDachon.TabIndex = 11;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(40, 378);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 12;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(203, 378);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 13;
            this.btnRes.Text = "Reset";
            this.btnRes.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(360, 378);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 14;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 407);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 129);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(272, 155);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // btnaddall
            // 
            this.btnaddall.Location = new System.Drawing.Point(191, 232);
            this.btnaddall.Name = "btnaddall";
            this.btnaddall.Size = new System.Drawing.Size(75, 23);
            this.btnaddall.TabIndex = 18;
            this.btnaddall.Text = ">>";
            this.btnaddall.UseVisualStyleBackColor = true;
            this.btnaddall.Click += new System.EventHandler(this.btnaddall_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Location = new System.Drawing.Point(191, 261);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(75, 23);
            this.btnadd1.TabIndex = 19;
            this.btnadd1.Text = ">";
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // btndelall
            // 
            this.btndelall.Location = new System.Drawing.Point(191, 290);
            this.btndelall.Name = "btndelall";
            this.btndelall.Size = new System.Drawing.Size(75, 23);
            this.btndelall.TabIndex = 20;
            this.btndelall.Text = "<<";
            this.btndelall.UseVisualStyleBackColor = true;
            this.btndelall.Click += new System.EventHandler(this.btndelall_Click);
            // 
            // btndel1
            // 
            this.btndel1.Location = new System.Drawing.Point(191, 319);
            this.btndel1.Name = "btndel1";
            this.btndel1.Size = new System.Drawing.Size(75, 23);
            this.btndel1.TabIndex = 21;
            this.btndel1.Text = "<";
            this.btndel1.UseVisualStyleBackColor = true;
            this.btndel1.Click += new System.EventHandler(this.btndel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 546);
            this.Controls.Add(this.btndel1);
            this.Controls.Add(this.btndelall);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.btnaddall);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lstDachon);
            this.Controls.Add(this.lstChon);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.txtngay);
            this.Controls.Add(this.txtht);
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
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtngay;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.ListBox lstChon;
        private System.Windows.Forms.ListBox lstDachon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnaddall;
        private System.Windows.Forms.Button btnadd1;
        private System.Windows.Forms.Button btndelall;
        private System.Windows.Forms.Button btndel1;
    }
}

