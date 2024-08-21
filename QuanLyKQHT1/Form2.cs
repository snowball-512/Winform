using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace QuanLyKQHT1
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adaptersv, adapterdiem;
        DataTable dtsv, dtdiem;
        int row = -1;

        private void btnadd_Click(object sender, EventArgs e)
        {
            string msv = txtmsv.Text;
            string ht = txtht.Text;
            string dc = txtdc.Text;
            string lop = cbblop.Text;
            string gt;
            if (rdnam.Checked == true) gt = "Nam";
            else gt = "Nữ";
            string sqlChkmsv = "select count(*) from sv where msv ='" + msv + "'";
            conn.Open();
            cmd = new SqlCommand(sqlChkmsv, conn);
            int chkmsv = (int)cmd.ExecuteScalar();
            if (chkmsv == 0) {
                cmd.CommandText = "insert into sv values ('" + msv + "', N'" + ht + "', N'" + dc + "', N'" + gt + "' , N'" + lop + "'  ) ";
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Msv đã tồn tại");
            }
            dtsv.Clear();
            dtsv = new DataTable();
            adaptersv = new SqlDataAdapter(" select msv as 'Mã sv', ht as 'Họ tên', dc as 'Địa chỉ', gtinh as'Giới tính', lop as 'Lớp' from sv ", conn);
            adaptersv.Fill(dtsv);
            dataGridViewSV.DataSource = dtsv;

            string sqlcountsv = "select count(*) from sv";
            cmd = new SqlCommand(sqlcountsv, conn);
            int counsv = (int)cmd.ExecuteScalar();
            lblcountsv.Text = "Có " + counsv.ToString() + " sinh viên";


            //string mon = cbbmon.Text;
            //float hs1, hs2, thi, thilai;
            //if (string.IsNullOrWhiteSpace(txths1.Text)
            //    || string.IsNullOrWhiteSpace(txths2.Text)
            //    || string.IsNullOrWhiteSpace(txtthi.Text)
            //    ||string.IsNullOrWhiteSpace(txtthilai.Text)
            //    ||!float.TryParse(txths1.Text,out hs1)
            //    ||!float.TryParse (txths2.Text,out hs2)
            //    ||!float.TryParse(txtthi.Text, out thi)
            //    ||!float.TryParse(txtthilai.Text,out thilai)
            //    )
            //{
            //    MessageBox.Show("Hãy nhập vào là số trong khoảng 0 đến 10");
            //    return;
            //}
            //if (hs1 > 10 || hs1 < 0 || hs2 > 10 || hs2 < 0 || thi > 10 || thi < 0 || thilai > 10 || thilai < 0)
            //{
            //    MessageBox.Show("Hãy nhập vào là số trong khoảng 0 đến 10");
            //    return;
            //}
            //cmd.CommandText = "insert into diem values('"+msv+"', N'"+mon+"', '"+hs1+"','"+hs2+"', '"+thi+"', '"+thilai+"' )";
            //cmd.ExecuteNonQuery();

            //dtdiem = new DataTable();
            //adapterdiem = new SqlDataAdapter(" select msv as 'Mã sv', mon as 'Môn học', hs1 as 'Điểm hs1', hs2 as'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where msv = '"+msv+"' ",conn);
            //adapterdiem.Fill(dtdiem);
            //dataGridViewDiem.DataSource = dtdiem;

            conn.Close();
        }

        private void dataGridViewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            if (row >= 0 && row < dataGridViewSV.Rows.Count)
            {
                string msv = dataGridViewSV.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "Select msv as 'Mã sv', mon as'Môn học', hs1 as'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where msv = '" + msv + "'";

                conn.Open();
                cmd.ExecuteNonQuery();

                dtsv = new DataTable();
                adaptersv = new SqlDataAdapter(cmd.CommandText, conn);
                adaptersv.SelectCommand = cmd;
                adaptersv.Fill(dtsv);
                dataGridViewDiem.DataSource = dtsv;

                txtmsv.Text = dataGridViewSV.Rows[row].Cells[0].Value.ToString();
                txtht.Text = dataGridViewSV.Rows[row].Cells[1].Value.ToString();
                txtdc.Text = dataGridViewSV.Rows[row].Cells[2].Value.ToString();
                string gt = dataGridViewSV.Rows[row].Cells[3].Value.ToString();
                if (gt == "Nam") rdnam.Checked = true;
                else rdnu.Checked = true;
                cbblop.Text = dataGridViewSV.Rows[row].Cells[4].Value.ToString();
                if (dataGridViewDiem.Rows.Count > 0)
                {
                    cbbmon.Text = dataGridViewDiem.Rows[0].Cells[1].Value.ToString();
                    txths1.Text = dataGridViewDiem.Rows[0].Cells[2].Value.ToString();
                    txths2.Text = dataGridViewDiem.Rows[0].Cells[3].Value.ToString();
                    txtthi.Text = dataGridViewDiem.Rows[0].Cells[4].Value.ToString();
                    txtthilai.Text = dataGridViewDiem.Rows[0].Cells[5].Value.ToString();
                }
                conn.Close();

            }
            
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            string sql = "Data Source=snowball;Initial Catalog=qlkqht1;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();

            //sv
            dtsv = new DataTable();
            adaptersv = new SqlDataAdapter("select msv as 'Mã sv', ht as 'Họ tên', gtinh as 'Giới tính', dc as 'Địa chỉ' , lop as 'Lớp' from sv   ",conn);
            adaptersv.Fill(dtsv);
            dataGridViewSV.DataSource = dtsv;


            //diem
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter("select msv as'Mã sv', mon as 'Môn học', hs1 as 'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as'Điểm thi lại' from diem  ", conn);
            adapterdiem.Fill(dtdiem);
            dataGridViewDiem.DataSource = dtdiem;


            string countsv = "select count(*) from sv";
            cmd= new SqlCommand(countsv,conn);
            int count = (int)cmd.ExecuteScalar();
            lblcountsv.Text = "Có " + count.ToString() + " sinh viên";

            string countmon = "select msv, count(*) as mon from diem group by msv ";
            SqlDataAdapter adcountmon = new SqlDataAdapter(countmon,conn);
            DataTable dtcountmon = new DataTable();
            adcountmon.Fill(dtcountmon); 
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dtcountmon.Rows)
            {
                string msv = row["Mã sv"].ToString();
                int sodiem = Convert.ToInt32(row["Môn học"]);
                sb.AppendLine("Có " + sodiem.ToString() + " điểm môn");
            }
            lblcountmon.Text = sb.ToString();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Close();
        }
    }
}
