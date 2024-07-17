namespace GkDe1
{
    partial class Form2
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTT = new System.Windows.Forms.Button();
            this.txtTongDt = new System.Windows.Forms.TextBox();
            this.txtTongSV = new System.Windows.Forms.TextBox();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTT);
            this.groupBox5.Controls.Add(this.txtTongDt);
            this.groupBox5.Controls.Add(this.txtTongSV);
            this.groupBox5.Controls.Add(this.txtTongKH);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(621, 263);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thống kê:";
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(273, 204);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(117, 33);
            this.btnTT.TabIndex = 11;
            this.btnTT.Text = "Thoát";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // txtTongDt
            // 
            this.txtTongDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongDt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTongDt.Enabled = false;
            this.txtTongDt.Location = new System.Drawing.Point(200, 129);
            this.txtTongDt.Name = "txtTongDt";
            this.txtTongDt.ReadOnly = true;
            this.txtTongDt.Size = new System.Drawing.Size(282, 27);
            this.txtTongDt.TabIndex = 10;
            this.txtTongDt.TextChanged += new System.EventHandler(this.txtTongDt_TextChanged);
            // 
            // txtTongSV
            // 
            this.txtTongSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongSV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTongSV.Enabled = false;
            this.txtTongSV.Location = new System.Drawing.Point(200, 78);
            this.txtTongSV.Name = "txtTongSV";
            this.txtTongSV.ReadOnly = true;
            this.txtTongSV.Size = new System.Drawing.Size(282, 27);
            this.txtTongSV.TabIndex = 9;
            this.txtTongSV.TextChanged += new System.EventHandler(this.txtTongSV_TextChanged);
            // 
            // txtTongKH
            // 
            this.txtTongKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongKH.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTongKH.Enabled = false;
            this.txtTongKH.Location = new System.Drawing.Point(200, 31);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.ReadOnly = true;
            this.txtTongKH.Size = new System.Drawing.Size(282, 27);
            this.txtTongKH.TabIndex = 8;
            this.txtTongKH.TextChanged += new System.EventHandler(this.txtTongKH_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tổng doanh thu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng số KH là SV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số KH:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kh,
            this.khsv,
            this.dt});
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(621, 325);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kh
            // 
            this.kh.HeaderText = "Tổng số KH";
            this.kh.Name = "kh";
            this.kh.ReadOnly = true;
            // 
            // khsv
            // 
            this.khsv.HeaderText = "Tổng số Kh là SV";
            this.khsv.Name = "khsv";
            this.khsv.ReadOnly = true;
            // 
            // dt
            // 
            this.dt.HeaderText = "Tổng doanh thu";
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTongDt;
        private System.Windows.Forms.TextBox txtTongSV;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn khsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
    }
}