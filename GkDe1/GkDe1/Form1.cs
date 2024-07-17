using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GkDe1
{
    public partial class Form1 : Form
    {
        private int totalCustomers = 0;
        private int totalStudentCustomers = 0;
        private int totalRevenue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTT_Enter(object sender, EventArgs e)
        {

        }

        private void txtTenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSlsach_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenkh.Text))
            {
                MessageBox.Show("Tên khách hàng không được rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkh.Focus();
                return;
            }
            if(!int.TryParse(txtSlsach.Text, out int slSach) || slSach <= 0)
            {
                MessageBox.Show("Số lượng sách là số nguyên và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSlsach.Focus();
                return;
            }
            const int donGia = 20000;
            int thanhtien = slSach * donGia;
            if (ckSV.Checked)
            {
                thanhtien = (int)(thanhtien * 0.95);
            }
            txtThanhtien.Text = thanhtien.ToString();
            totalCustomers++;
            if (ckSV.Checked)
            {
                totalStudentCustomers++;
            }
            totalRevenue += thanhtien;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtThanhtien.Clear();
            txtSlsach.Clear();
            txtTenkh.Clear();
            ckSV.Checked = false;
            txtTenkh.Focus() ;

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            txtTongKH.Text = totalCustomers.ToString();
            txtTongSV.Text = totalStudentCustomers.ToString();
            txtTongDt.Text = totalRevenue.ToString();
            Form2 form2 = new Form2
            { 
                tongKH = totalCustomers,
                tongKHSV = totalStudentCustomers,
                tongDT = totalRevenue
            };
            form2.Show();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            var kq= MessageBox.Show("Bạn có muốn đóng không", "Xác nhận", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtTongKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongDt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
