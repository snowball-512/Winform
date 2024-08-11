using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, tong, hieu, tich, thuong;
                double aint = Convert.ToDouble(txxta.Text);
                double bint = Convert.ToDouble(txtb.Text); 
                tong = aint + bint;
                hieu = aint - bint;
                tich = aint * bint;

                thuong = 0;
                if (bint != 0)
                {
                    thuong = aint / bint;
                    lblThuong.Text = thuong.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể chia cho số 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lblTong.Text = tong.ToString();
                lblHieu.Text = hieu.ToString();
                lblTich.Text = tich.ToString();
                
            }
            catch(FormatException) {
                MessageBox.Show("Hãy nhập số", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnout_Click(object sender, EventArgs e)
        {
            DialogResult kq= MessageBox.Show("Bạn có muốn đóng không ?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
