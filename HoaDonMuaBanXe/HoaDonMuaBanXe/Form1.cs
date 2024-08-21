using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDonMuaBanXe
{
    public partial class Form1 : Form
    {
        int sumKh=0, sumDen=0;
        double sumDt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double phuthu, giatien, thue, tt=0;
            //int giatienint = Convert.ToInt32(txtGia.Text);
            if(!int.TryParse(txtGia.Text, out int giatienint))
            {
                MessageBox.Show("Vui lòng nhập số cho trường này!", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtGia.Text)){
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return ;
            }
            thue = 0.08*giatienint;
            txtThue.Text = thue.ToString();
            if (rdDen.Checked)
            {
                phuthu = 0.05* giatienint;
                txtPt.Text = phuthu.ToString();
                tt = phuthu + thue + giatienint;
                txtTT.Text = tt.ToString();
                sumDen++;

            }
            else if (rdkhac.Checked)
            {
                phuthu = 0;
                txtPt.Text = phuthu.ToString();
                tt = phuthu + thue + giatienint;
                txtTT.Text = tt.ToString();
            }
            sumDt += tt;
            string ht = txtHt.Text;
            string dc=  txtDc.Text;

            //int Dt = Convert.ToInt32(txtDt.Text);
            if (string.IsNullOrEmpty(txtDt.Text))
            {
                MessageBox.Show("Hãy nhập vào sđt","Lỗi",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return ;
            }
            sumKh++;
            
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {

        }

        private void bntTK_Click(object sender, EventArgs e)
        {
            txtSumden.Text = sumDen.ToString();
            txtsumKH.Text = sumKh.ToString();
            txtsumdt.Text = sumDt.ToString();
        }

        private void btnKt_Click(object sender, EventArgs e)
        {

        }
    }
}
