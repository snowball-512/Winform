namespace BangKetQuaHocTap
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
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.dtSV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDiem = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtthilai = new System.Windows.Forms.TextBox();
            this.txtthi = new System.Windows.Forms.TextBox();
            this.txths2 = new System.Windows.Forms.TextBox();
            this.txths1 = new System.Windows.Forms.TextBox();
            this.txtmon = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(96, 17);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(121, 21);
            this.cbbLop.TabIndex = 1;
            // 
            // dtSV
            // 
            this.dtSV.AllowUserToAddRows = false;
            this.dtSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSV.Location = new System.Drawing.Point(30, 86);
            this.dtSV.Name = "dtSV";
            this.dtSV.Size = new System.Drawing.Size(375, 178);
            this.dtSV.TabIndex = 2;
            this.dtSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSV_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách sinh viên";
            // 
            // dtDiem
            // 
            this.dtDiem.AllowUserToAddRows = false;
            this.dtDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDiem.Location = new System.Drawing.Point(30, 315);
            this.dtDiem.Name = "dtDiem";
            this.dtDiem.Size = new System.Drawing.Size(375, 112);
            this.dtDiem.TabIndex = 4;
            this.dtDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDiem_CellClick);
            this.dtDiem.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDiem_CellLeave);
            this.dtDiem.SelectionChanged += new System.EventHandler(this.dtDiem_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh mục kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "BẢNG KẾT QUẢ HỌC TẬP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtthilai);
            this.groupBox1.Controls.Add(this.txtthi);
            this.groupBox1.Controls.Add(this.txths2);
            this.groupBox1.Controls.Add(this.txths1);
            this.groupBox1.Controls.Add(this.txtmon);
            this.groupBox1.Controls.Add(this.txtht);
            this.groupBox1.Controls.Add(this.txtmsv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(438, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtthilai
            // 
            this.txtthilai.Location = new System.Drawing.Point(260, 210);
            this.txtthilai.Name = "txtthilai";
            this.txtthilai.Size = new System.Drawing.Size(80, 20);
            this.txtthilai.TabIndex = 13;
            // 
            // txtthi
            // 
            this.txtthi.Location = new System.Drawing.Point(79, 210);
            this.txtthi.Name = "txtthi";
            this.txtthi.Size = new System.Drawing.Size(80, 20);
            this.txtthi.TabIndex = 12;
            // 
            // txths2
            // 
            this.txths2.Location = new System.Drawing.Point(260, 158);
            this.txths2.Name = "txths2";
            this.txths2.Size = new System.Drawing.Size(80, 20);
            this.txths2.TabIndex = 11;
            // 
            // txths1
            // 
            this.txths1.Location = new System.Drawing.Point(79, 158);
            this.txths1.Name = "txths1";
            this.txths1.Size = new System.Drawing.Size(80, 20);
            this.txths1.TabIndex = 10;
            // 
            // txtmon
            // 
            this.txtmon.Location = new System.Drawing.Point(79, 112);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(246, 20);
            this.txtmon.TabIndex = 9;
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(79, 65);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(246, 20);
            this.txtht.TabIndex = 8;
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(79, 29);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(100, 20);
            this.txtmsv.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Điểm thi lại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Điểm thi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điểm hs2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Điểm hs1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Môn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "MSV";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(456, 372);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(587, 372);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(713, 372);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtSV);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.DataGridView dtSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtthilai;
        private System.Windows.Forms.TextBox txtthi;
        private System.Windows.Forms.TextBox txths2;
        private System.Windows.Forms.TextBox txths1;
        private System.Windows.Forms.TextBox txtmon;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button button4;
    }
}

