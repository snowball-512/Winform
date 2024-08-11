using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chkKhac.CheckedChanged += new EventHandler(chkKhac_CheckedChanged);
            
        }


        //private void btnAnh_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog op = new OpenFileDialog();
        //    if(op.ShowDialog() == DialogResult.OK)
        //    {
        //        string select = op.FileName;
        //        pictureBox1.Image = Image.FromFile(select); 
        //    }
        //}
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(op.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            else
            {
                using (Form2 inputForm = new Form2("Enter Image URL:"))
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        string imageUrl = inputForm.UserInput;
                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            try
                            {
                                using (WebClient client = new WebClient())
                                {
                                    byte[] imageData = client.DownloadData(imageUrl);
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error downloading image: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }




        private void btnUp_Click(object sender, EventArgs e)
        {
            string ht = txtht.Text;
            if (string.IsNullOrEmpty(ht))
            {
                MessageBox.Show("Hãy nhập vào họ tên", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            lblht.Text = ht;
            string dt = dtNS.Value.ToString("dd/MM/yyyy");
            string subjects = "";

            // Add selected subjects to the variable based on checked checkboxes
            if (chkNN.Checked)
                subjects += chkNN.Text + ", ";
            if (chkLT.Checked)
                subjects += chkLT.Text + ", ";
            if (chkPT.Checked)
                subjects += chkPT.Text + ", ";
            if (chkKhac.Checked)
            {
                if (txtMon.Text.Length > 0)
                {
                    subjects += txtMon.Text + ", ";
                }
            }
            if (chkGT.Checked)
            {
                if (subjects.Length > 0)
                {
                    subjects = subjects.TrimEnd(',', ' ');
                    txtfull.Text = $"Anh {ht}, Ngày sinh: {dt}, Môn học yêu thích: {subjects}";
                }
                else
                {
                    txtfull.Text = $"Anh {ht}, Ngày sinh: {dt}, Vui lòng chọn môn yêu thích";
                }
            }
            else
            {
                if (subjects.Length > 0)
                {
                    subjects = subjects.TrimEnd(',', ' ');
                    txtfull.Text = $"Chị {ht}, Ngày sinh: {dt}, Môn học yêu thích: {subjects}";
                }
                else
                {
                    txtfull.Text = $"Chị {ht}, Ngày sinh: {dt}, Vui lòng chọn môn học yêu thích";
                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtNS.Format = DateTimePickerFormat.Custom;
            dtNS.CustomFormat = "dd/MM/yyyy";

            txtMon.ReadOnly = !chkKhac.Checked;

        }

        private void chkKhac_CheckedChanged(object sender, EventArgs e)
        {
          txtMon.ReadOnly = !chkKhac.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
