using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienKemGki
{
    public partial class Form1 : Form
        
    {
        int sl;
        decimal dgia;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenhang = txtTenhang.Text;
            sl = Convert.ToInt32(txtSl.Text);
            dgia = Convert.ToInt32(((decimal)dgia).ToString());
            
            if(string.IsNullOrEmpty(tenhang))
            {
                MessageBox.Show("Tên hàng không đc đê trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!int.TryParse(txtSl.Text, out sl) || sl < 0)
            {
                MessageBox.Show("So lượng lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!decimal.TryParse(txtDgia.Text, out dgia) || dgia < 0)
            {
                MessageBox.Show("Đơn giá lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            decimal tt = dgia * sl;
            int ttInt = Convert.ToInt32(tt);
            txtTT.Text = ttInt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDgia.Clear();
            txtTT.Clear();
            txtSl.Clear();
            txtTenhang.Clear();
            txtTenhang.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Bạn có muốn đóng cửa sổ không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            Close();
        }
    }
}
