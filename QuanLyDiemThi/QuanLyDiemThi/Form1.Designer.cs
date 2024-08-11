namespace QuanLyDiemThi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.txtanh = new System.Windows.Forms.TextBox();
            this.cbmsv = new System.Windows.Forms.ComboBox();
            this.dgvql = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbpl = new System.Windows.Forms.ComboBox();
            this.btntk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.msvtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.httk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toantk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vantk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nntk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtbtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.van = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtbql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btndel);
            this.tabPage1.Controls.Add(this.btnedit);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.dgvql);
            this.tabPage1.Controls.Add(this.cbmsv);
            this.tabPage1.Controls.Add(this.txtanh);
            this.tabPage1.Controls.Add(this.txtvan);
            this.tabPage1.Controls.Add(this.txttoan);
            this.tabPage1.Controls.Add(this.txtht);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btntk);
            this.tabPage2.Controls.Add(this.cbpl);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm văn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm ngoại ngữ";
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(501, 12);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(265, 20);
            this.txtht.TabIndex = 5;
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(94, 62);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(217, 20);
            this.txttoan.TabIndex = 6;
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(402, 62);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(138, 20);
            this.txtvan.TabIndex = 7;
            // 
            // txtanh
            // 
            this.txtanh.Location = new System.Drawing.Point(687, 62);
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(79, 20);
            this.txtanh.TabIndex = 8;
            // 
            // cbmsv
            // 
            this.cbmsv.FormattingEnabled = true;
            this.cbmsv.Location = new System.Drawing.Point(79, 12);
            this.cbmsv.Name = "cbmsv";
            this.cbmsv.Size = new System.Drawing.Size(259, 21);
            this.cbmsv.TabIndex = 9;
            // 
            // dgvql
            // 
            this.dgvql.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvql.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msv,
            this.tensv,
            this.toan,
            this.van,
            this.anh,
            this.dtbql});
            this.dgvql.Location = new System.Drawing.Point(4, 153);
            this.dgvql.Name = "dgvql";
            this.dgvql.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvql.Size = new System.Drawing.Size(785, 271);
            this.dgvql.TabIndex = 10;
            this.dgvql.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvql_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(253, 116);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(377, 116);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 12;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(501, 116);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 13;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phân loại sinh viên";
            // 
            // cbpl
            // 
            this.cbpl.FormattingEnabled = true;
            this.cbpl.Location = new System.Drawing.Point(198, 43);
            this.cbpl.Name = "cbpl";
            this.cbpl.Size = new System.Drawing.Size(285, 21);
            this.cbpl.TabIndex = 1;
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(545, 43);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(93, 23);
            this.btntk.TabIndex = 2;
            this.btntk.Text = "thống kê";
            this.btntk.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msvtk,
            this.httk,
            this.toantk,
            this.vantk,
            this.nntk,
            this.dtbtk});
            this.dataGridView1.Location = new System.Drawing.Point(3, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(785, 271);
            this.dataGridView1.TabIndex = 11;
            // 
            // msvtk
            // 
            this.msvtk.HeaderText = "Mã SV";
            this.msvtk.Name = "msvtk";
            // 
            // httk
            // 
            this.httk.HeaderText = "Họ tên SV";
            this.httk.Name = "httk";
            // 
            // toantk
            // 
            this.toantk.HeaderText = "Điểm toán";
            this.toantk.Name = "toantk";
            // 
            // vantk
            // 
            this.vantk.HeaderText = "Điểm văn";
            this.vantk.Name = "vantk";
            // 
            // nntk
            // 
            this.nntk.HeaderText = "Điểm ngoại ngữ";
            this.nntk.Name = "nntk";
            // 
            // dtbtk
            // 
            this.dtbtk.HeaderText = "Điểm trung bình";
            this.dtbtk.Name = "dtbtk";
            // 
            // msv
            // 
            this.msv.HeaderText = "Mã SV";
            this.msv.Name = "msv";
            // 
            // tensv
            // 
            this.tensv.HeaderText = "Họ tên SV";
            this.tensv.Name = "tensv";
            // 
            // toan
            // 
            this.toan.HeaderText = "Điểm toán";
            this.toan.Name = "toan";
            // 
            // van
            // 
            this.van.HeaderText = "Điểm văn";
            this.van.Name = "van";
            // 
            // anh
            // 
            this.anh.HeaderText = "Điểm ngoại ngữ";
            this.anh.Name = "anh";
            // 
            // dtbql
            // 
            this.dtbql.HeaderText = "Điểm trung bình";
            this.dtbql.Name = "dtbql";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtanh;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvql;
        private System.Windows.Forms.ComboBox cbmsv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn msvtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn httk;
        private System.Windows.Forms.DataGridViewTextBoxColumn toantk;
        private System.Windows.Forms.DataGridViewTextBoxColumn vantk;
        private System.Windows.Forms.DataGridViewTextBoxColumn nntk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtbtk;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.ComboBox cbpl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn van;
        private System.Windows.Forms.DataGridViewTextBoxColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtbql;
    }
}

