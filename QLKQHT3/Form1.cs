using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKQHT3
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
                f.Close();
            }
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
