using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string name = txtht.Text;
            string dt = DateTime.Now.ToString();
            string st = txtSt.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(st))
            {
                MessageBox.Show("Hay nhap vao cac truong", "Loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.Add(name);
            listBox1.Items.Add(dt);
            listBox1.Items .Add(st);
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
