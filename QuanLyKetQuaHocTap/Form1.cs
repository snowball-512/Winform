using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKetQuaHocTap
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
            foreach(Form f in this.MdiChildren)
            {
                f.Close();

            }
            Form2 form2 = new Form2();
            form2.Show();
            form2.MdiParent = this;

        }
    }
}
