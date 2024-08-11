using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangKetQuaHocTap
{
    public partial class Formcha : Form
    {
        public Formcha()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Formcha_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            // Create and show a new Form2
            Form1 f2 = new Form1();
            f2.MdiParent = this; // Set this form (Form1) as the MDI parent
            f2.Show();
        }
    }
}
