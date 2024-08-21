using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapDayTinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDaySo.Clear();  
            txtTc.Clear();
            txtTl.Clear();
            txtTong.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                int inputNum = form2.InputNum;
                DaySo(inputNum);
            }
           
        }
        private void DaySo(int number)
        {
            StringBuilder dayso = new StringBuilder();
            int sum = 0, sumc = 0, suml = 0 ;
            for (int i= 1; i <= number; i++)
            {
                dayso.Append(i + " ");
                sum += i;
                if (i % 2 == 0)
                {
                    sumc += i;
                }
                else
                {
                    suml += i;
                }
            }
            txtDaySo.Text = dayso.ToString();
            txtTong.Text = sum.ToString();
            txtTc.Text = sumc.ToString();
            txtTl.Text = suml.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Xác nhận đóng ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == close)
            {
                Close();
            }
        }

        private void txtDaySo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
