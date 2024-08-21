using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCanBo
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
            foreach(Form f in this.MdiChildren)
            {
                f.Close(); 
            }
            Form1 f1 = new Form1();
            f1.Show();
            f1.MdiParent = this;

        }
    }
}
