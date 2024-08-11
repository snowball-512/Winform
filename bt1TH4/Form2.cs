using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1TH4
{
    public partial class Form2 : Form
    {
        public string tendn { get; set; }
        public string mk {  get; set; }
        public string check {  get; set; }

        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void lbldn_Click(object sender, EventArgs e)
        {
        }
        public class Hoandoi {
            public (int, int) hoanvi(int soa, int sob)
            {
                int temp = soa;
                soa = sob;
                sob = temp;
                return (soa, sob);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text, out int soa) || !int.TryParse(textBox2.Text,out int sob))
            {
                MessageBox.Show("Nhập vào là số", "Lỗi");
                return;
            }
            var hoandoi = new Hoandoi();
            (int swappeda, int swappedb) = hoandoi.hoanvi(soa, sob);
           textBox1.Text = swappeda.ToString();
            textBox2.Text = swappedb.ToString();
         
         

        }
    }
}
