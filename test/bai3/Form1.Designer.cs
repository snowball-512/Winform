namespace bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBac1 = new System.Windows.Forms.RadioButton();
            this.rdBac2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btbOut = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBac2);
            this.groupBox1.Controls.Add(this.rdBac1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdBac1
            // 
            this.rdBac1.AutoSize = true;
            this.rdBac1.Location = new System.Drawing.Point(39, 30);
            this.rdBac1.Name = "rdBac1";
            this.rdBac1.Size = new System.Drawing.Size(106, 21);
            this.rdBac1.TabIndex = 0;
            this.rdBac1.TabStop = true;
            this.rdBac1.Text = "Giải pt bậc 1";
            this.rdBac1.UseVisualStyleBackColor = true;
            this.rdBac1.CheckedChanged += new System.EventHandler(this.rdBac1_CheckedChanged);
            // 
            // rdBac2
            // 
            this.rdBac2.AutoSize = true;
            this.rdBac2.Location = new System.Drawing.Point(39, 66);
            this.rdBac2.Name = "rdBac2";
            this.rdBac2.Size = new System.Drawing.Size(106, 21);
            this.rdBac2.TabIndex = 1;
            this.rdBac2.TabStop = true;
            this.rdBac2.Text = "Giải pt bậc 2";
            this.rdBac2.UseVisualStyleBackColor = true;
            this.rdBac2.CheckedChanged += new System.EventHandler(this.rdBac2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả";
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.Location = new System.Drawing.Point(342, 186);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(101, 61);
            this.btnGiai.TabIndex = 6;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btbOut
            // 
            this.btbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbOut.Location = new System.Drawing.Point(342, 291);
            this.btbOut.Name = "btbOut";
            this.btbOut.Size = new System.Drawing.Size(101, 28);
            this.btbOut.TabIndex = 7;
            this.btbOut.Text = "Thoát";
            this.btbOut.UseVisualStyleBackColor = true;
            this.btbOut.Click += new System.EventHandler(this.btbOut_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(77, 196);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(259, 20);
            this.txta.TabIndex = 8;
            this.txta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(77, 260);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(259, 20);
            this.txtb.TabIndex = 9;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(77, 318);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(259, 20);
            this.txtc.TabIndex = 10;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(77, 380);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(366, 20);
            this.txtd.TabIndex = 11;
            this.txtd.TextChanged += new System.EventHandler(this.txtd_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btbOut);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBac1;
        private System.Windows.Forms.RadioButton rdBac2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btbOut;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.Button button1;
    }
}

