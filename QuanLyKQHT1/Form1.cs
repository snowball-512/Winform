using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKQHT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form2 f in this.MdiChildren)
            {
                if (f is Form2)
                {
                    f.Close();
                }
            }
            Form2 form2 = new Form2();
            
            form2.MdiParent = this;
            form2.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form3 f in this.MdiChildren)
            {
                if (f is Form3)
                {
                    f.Close();
                }

            }
            Form3 f3 =new Form3();
            f3.MdiParent = this;
            f3.Show();
        }
    }
}
