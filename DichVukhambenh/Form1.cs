using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DichVukhambenh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in lstChon.SelectedItems)
            {
                lstDachon.Items.Add(item);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string ht = txtht.Text;
            if (string.IsNullOrEmpty(ht))
            {
                MessageBox.Show("Hãy nhập vào họ tên", "Lỗi");
                return;
            }
            if (!int.TryParse(txtngay.Text, out int day) || !int.TryParse(txtthang.Text, out int month) || !int.TryParse(txtnam.Text, out int nam))
            {
                MessageBox.Show("Hãy nhập vào là số", "Lỗi");
                return;
            }

            string dsdv = "";
            foreach (var item in lstDachon.Items)
            {
                if (dsdv.Length > 0)
                {
                    dsdv += ", ";
                }
                dsdv += item.ToString();
            }

            richTextBox1.Text = $"Họ tên: {ht} \n Ngày sinh: {txtngay.Text}/{txtthang.Text}/{txtnam.Text} \n Dịch vụ đã chọn: {dsdv}\n thời gian: { dateTimePicker1.Text} { dateTimePicker2.Text} " ;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnaddall_Click(object sender, EventArgs e)
        {
           
            foreach (string item in lstChon.Items)
            {
                lstDachon.Items.Add(item);
            }
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            foreach(string item in lstChon.SelectedItems)
            {
                lstDachon.Items.Add(item);
            }
        }

        private void btndelall_Click(object sender, EventArgs e)
        {
            lstDachon.Items.Clear();
        }

        private void btndel1_Click(object sender, EventArgs e)
        {
            List<string> itemsToRemove = new List<string>();

            // Add selected items to the list
            foreach (string item in lstDachon.SelectedItems)
            {
                itemsToRemove.Add(item);
            }

            // Remove each item from the ListBox
            foreach (string item in itemsToRemove)
            {
                lstDachon.Items.Remove(item);
            }
        }
    }
}
