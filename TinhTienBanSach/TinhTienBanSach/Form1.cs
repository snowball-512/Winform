using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienBanSach
{
    public partial class Form1 : Form
    {
        int sumKH = 0; int sumSV = 0; double sumDT = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            string kh = txtTenkh.Text;
            int slSach ;
            const int dgia = 20000;
            if(!int.TryParse(txtSL.Text, out slSach))
            {
                MessageBox.Show("Số lượng sách ko hợp lệ", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            double tt = slSach * dgia;
            if (chkSV.Checked)
            {
                tt = tt * 0.95;
                sumSV++;

            }
            txtTT.Text = tt.ToString("N0") +"VND";
            sumKH++;
            sumDT += tt;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtSL.Clear();
            txtTT.Clear();
            txtTenkh.Clear();
            chkSV.Checked = false;
            
        }

        private void txtTenkh_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongKh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            txtTongKh.Text = sumKH.ToString() + " khách";
            txtTongsv.Text = sumSV.ToString() +" sinh viên";
            txtTongDT.Text = sumDT.ToString("N0")+"VND";
        }
    }
}
