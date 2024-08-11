using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace bt1TH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)) {
                MessageBox.Show("Hãy nhập vào tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form2 form2 = new Form2();
            form2.tendn = textBox1.Text;
            form2.mk = textBox2.Text;
            if (checkBox1.Checked)
            {
                form2.check = "Bạn có ghi nhớ mật khẩu";
            }
            form2.ShowDialog();
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += textBox1.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += textBox2.Text;
            if (checkBox1.Checked == true)
            {
                thongbao += "\n\rBạn có ghi nhớ mật khẩu.";

            }
            MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolTip1.Show("Thog bao");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            checkBox1.CheckState = CheckState.Indeterminate;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chán muốn dừng không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            var toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true,
                IsBalloon = true,
                ToolTipIcon = ToolTipIcon.Info,
                ToolTipTitle = "Loi nhap vao"
            };

            // Example tooltip text
            string body = "This is the tooltip text";

            // Show the tooltip at a specific location relative to textBox1
            Point point = new Point(20, 10); // Adjust the point as needed
            toolTip.Show(body, textBox1, point.X, point.Y, 5000);
        }
        
    }
}
