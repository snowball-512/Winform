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
    public partial class Form2 : Form
    {
        public int tongKH {  get; set; }
        public int tongKHSV { get; set; }
        public int tongDT { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtTongKH.Text= tongKH.ToString(); 
            txtTongSV.Text= tongKHSV.ToString();
            txtTongDt.Text= tongDT.ToString();
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(tongKH, tongKHSV, tongDT);
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

        private void btnTT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
