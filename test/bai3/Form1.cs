using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdBac1.CheckedChanged += new EventHandler(RadioButton_CheckedChange);
            rdBac2.CheckedChanged += new EventHandler(RadioButton_CheckedChange);

        }
        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            if (rdBac1.Checked)
            {
                txtc.Enabled = true;
                txtc.ReadOnly = true;
                txtc.BackColor = SystemColors.Control;
            }
            else if (rdBac2.Checked)
            {
                txtc.Enabled = true;
                txtc.ReadOnly = false;
                txtc.BackColor = SystemColors.Window;
            }
        }

        private void rdBac1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBac2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a,b,c,x;
            if (double.TryParse(txta.Text, out a) )
            {
                int inta = Convert.ToInt32(a);
            }
            else
            {
                MessageBox.Show("Hãy nhập vào là số", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if(double.TryParse(txtb.Text, out b))
            {
                int intb = Convert.ToInt32(b);
            }
            else
            {
                MessageBox.Show("Hãy nhập vào là số", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (rdBac2.Checked)
            {
                if (double.TryParse(txtc.Text, out c))
                {
                    int intc = Convert.ToInt32(c);
                }
                else
                {
                    MessageBox.Show("Hãy nhập vào là số", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                double delta = Math.Pow(b,2) - 4 * a * c;
                if (delta < 0)
                {
                    txtd.Text = "Pt vô nghiệm";
                }
                else if(delta == 0)
                {
                    x = -b/(2*a);
                    txtd.Text = "Pt có nghiệm kép: x =" + x.ToString();
                }
                else
                {
                    double x1 = (-b+ Math.Sqrt(delta))/ (2*a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtd.Text = "Pt có 2 nghiệm là x1 = " + x1.ToString() + ", x2 = "+ x2.ToString();
                }
            }
         
            if (rdBac1.Checked)
            {
                if (a == 0)
                {
                    if(b == 0)
                    {
                        txtd.Text = "Pt vô nghiệm";
                    }
                    else
                    {
                        txtd.Text = "Pt vô số nghiệm";
                    }
                }
                else
                {
                    x = -b / a;
                    txtd.Text = "Pt có 1 nghiệm: x = "+x.ToString();
                }
            }
            
        }

        private void btbOut_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đóng ko ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtd.Clear();
            rdBac1.Checked = false;
            rdBac2.Checked = false;
        }
    }
}
