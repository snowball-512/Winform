using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            string[] item = { "Nv a", "nvB", "item c" };
            comboBox1.Items.AddRange(item);
        }
      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            //int cscu = Convert.ToInt32(txtcscu.Text);
            //int csmoi = Convert.ToInt32(txtcsmoi.Text);
           
            if(!int.TryParse(txtcscu.Text, out int cscu) || !int.TryParse(txtcsmoi.Text, out int csmoi))
            {
                MessageBox.Show("Hãy nhập vào là số", "Lỗi");
                return;
            }
            const int dinhmuc = 50;
            int sokw = csmoi - cscu;
            int sovuot = sokw - 50;
            int sumtien;
            txtsokw.Text = sokw.ToString();
            if(sokw <= 50)
            {
                txtdinhmuc.Text = sokw.ToString();
                sumtien = sokw * 500;
                txtsumtien.Text = sumtien.ToString();
            }
            else
            {
                txtdinhmuc.Text = $"{dinhmuc}";
                txtvuot.Text = sovuot.ToString();
                sumtien = dinhmuc * 500 + sovuot * 1000;
                txtsumtien.Text = sumtien.ToString();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"{comboBox1.Text}\nSố kw tiêu thụ: {txtsokw.Text}\nTổng tiền: {txtsumtien.Text}";

        }
    }
}
