using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GkiDvuKhamBenh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void txtHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void ltDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ltDv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var selectedItem in ltDv.SelectedItems)
            {
                ltDs.Items.Add(selectedItem.ToString());
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string ht = txtHT.Text;
            int ngay, thang, nam;
            bool validDate = int.TryParse(txtNgay.Text, out ngay) && ngay>=1 && ngay<=31;
            bool validMon = int.TryParse(txtThang.Text, out thang) && thang>=1 && thang<=12;
            bool validYear = int.TryParse(txtNam.Text, out nam);
            if (!validDate || !validMon || !validYear )
            {
                MessageBox.Show("Hãy nhập ngày tháng năm sinh");
                return;
            }
           
            if (string.IsNullOrWhiteSpace(txtHT.Text) || string.IsNullOrEmpty(txtNgay.Text) || string.IsNullOrEmpty(txtThang.Text) || string.IsNullOrEmpty(txtNam.Text))
            {
                MessageBox.Show("Không được để trống");
                return;
               
            }
            string result = "Dịch vụ đã chọn: ";
            string date = $"{ngay}/{thang}/{nam}";
            lsShow.Items.Add ($"Họ tên: {ht}");
            lsShow.Items.Add($"Ngày sinh: {date}");
            if (ltDs.Items.Count == 0)
            {
                lsShow.Items.Add("Không có dịch vụ nào được chọn");
            }
            else
            {
                var sb= new StringBuilder();
                foreach(var item in ltDs.Items)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(", ");
                    }
                    sb.Append(item.ToString());
                }
                lsShow.Items.Add(result+sb.ToString());
            }
            
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            txtHT.Clear();
            txtNgay.Clear();
            txtThang.Clear();
            txtNam.Clear();
            ltDs.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát không?", "Xác nhận thoát",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lsShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
