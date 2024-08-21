using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongTyDuLich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtNgaysinh.Format = DateTimePickerFormat.Custom;
            dtNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtNgaysinh.ValueChanged += dateTimePicker1_ValueChanged;

            dtdi.Format = DateTimePickerFormat.Custom;
            dtdi.CustomFormat = "dd/MM/yyyy";
            dtdi.ValueChanged += dateTimePicker1_ValueChanged;

            dtve.Format = DateTimePickerFormat.Custom;
            dtve.ValueChanged += dateTimePicker1_ValueChanged;
            dtve.CustomFormat = "dd/MM/yyyy";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime dt= dtNgaysinh.Value;
            //Strin
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lsshow.Items.Add("Khách hàng: " + txtkh.Text);
            DateTime date = dtNgaysinh.Value;
            string formDate = date.ToString("dd/MM/yyyy");
            lsshow.Items.Add("Ngày sinh: " + formDate);
            lsshow.Items.Add("Địa chỉ: "+txtdc.Text);
            lsshow.Items.Add("Địa điểm xuất phát: " + lsdi.Text);
            lsshow.Items.Add("Địa điểm đến: " + lsden.Text);
         
            DateTime di = dtdi.Value;
            DateTime ve = dtve.Value;
            TimeSpan tong = ve - di;
            int tongngay = Math.Abs(tong.Days);
            txtsumday.Text = tongngay.ToString();

        }
    }
}
