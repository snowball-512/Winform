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

namespace QuanLyKetQuaHocTap
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adaptersv, adapterdiem;
        DataTable dtsv, dtdiem;
        int row = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row= e.RowIndex; 
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                string msv = dataGridView1.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "Select msv as 'Mã sv', monhoc as'Môn học', hs1 as'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where msv = '"+msv+"'";

                conn.Open();
                cmd.ExecuteNonQuery();

                dtsv = new DataTable();
                adaptersv = new SqlDataAdapter(cmd.CommandText, conn);
                adaptersv.SelectCommand = cmd;
                adaptersv.Fill(dtsv);
                dataGridView2.DataSource = dtsv;
                txtmsv.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtht.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                if (dataGridView2.Rows.Count > 0)
                {
                    txtmon.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                    txths1.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                    txths2.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
                    txtdt.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
                    txttl.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();

                }

                conn.Close();
          
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if(row>=0 && row < dataGridView2.Rows.Count)
            {
                txtmon.Text = dataGridView2.Rows[row].Cells[1].Value.ToString();
                txths1.Text = dataGridView2.Rows[row].Cells[2].Value.ToString();
                txths2.Text = dataGridView2.Rows[row ].Cells[3].Value.ToString();
                txtdt.Text= dataGridView2.Rows[row].Cells[4].Value.ToString() ;
                txttl.Text = dataGridView2.Rows[row].Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bang sv
            string msv = txtmsv.Text;
            string ht = txtht.Text;
            string lop = comboBox1.Text;

            string checkmsv = "select count(*) from sv where msv = '" + msv + "'";
            conn.Open();
            SqlCommand check = new SqlCommand(checkmsv, conn);
            int countsv = (int)check.ExecuteScalar();
            ////them sv
            if (countsv == 0) 
            { 
                cmd.CommandText = "insert into sv values('" + msv + "', N'" + ht + "', N'" + lop + "'   )";
                cmd.ExecuteNonQuery();
            }
            //bảng sv
            dtsv.Clear();
            dtsv = new DataTable();
            adaptersv = new SqlDataAdapter("select msv as 'Mã sv', ht as 'Họ tên', lop as 'Lớp' from sv   ", conn);
            adaptersv.Fill(dtsv);
            dataGridView1.DataSource = dtsv;


            //diem
            string mon = txtmon.Text;
            float hs1, hs2, thi, thilai;
            if (string.IsNullOrWhiteSpace(txths1.Text) || !float.TryParse(txths1.Text, out hs1) || string.IsNullOrWhiteSpace(txths2.Text) || string.IsNullOrWhiteSpace(txtdt.Text) || string.IsNullOrWhiteSpace(txttl.Text) || !float.TryParse(txttl.Text, out thilai) || !float.TryParse(txtdt.Text, out thi)|| !float.TryParse(txths2.Text, out hs2))
            {
                MessageBox.Show("Hãy nhập vào là số");
                return;
            }
            if(hs1>10 || hs1<0 || hs2>10 || hs2<0 || thi>10|| thi<0|| thilai>10|| thilai<0)
            {
                MessageBox.Show("Nhập trong khoảng 0 đến 10");
                return;
            }

            ////them diem
            cmd.CommandText = "insert into diem values ( '"+msv+"', N'"+mon+"',  '"+hs1+"', '"+hs2+"', '"+thi+"', '"+thilai+"' )";
            cmd.ExecuteNonQuery();


            //bang diem
            dtdiem.Clear();
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter("select msv as 'Mã sv', monhoc as 'Môn học', hs1 as 'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where msv = '"+msv+"'  ",conn);
            adapterdiem.Fill(dtdiem);
            dataGridView2.DataSource = dtdiem; 
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ma = txtmsv.Text;
                string ht = txtht.Text;
                string lop = comboBox1.Text;

                cmd.CommandText = "update sv set ht =N'" + ht + "', lop = '" + lop + "' where msv ='" + ma + "'";
                conn.Open();
                cmd.ExecuteNonQuery();

                dtsv.Clear();
                dtsv = new DataTable();
                adaptersv = new SqlDataAdapter("select msv as 'Mã sv', ht as 'Họ tên', lop as 'Lớp' from sv  ", conn);
                adaptersv.Fill(dtsv);
                dataGridView1.DataSource = dtsv;

                    string mon = txtmon.Text;
                    float hs1, hs2, thi, thilai;
                    if(string.IsNullOrWhiteSpace(txths1.Text) ||
                        string.IsNullOrWhiteSpace(txths2.Text)|| 
                        string.IsNullOrWhiteSpace(txtdt.Text)||
                        string.IsNullOrWhiteSpace(txttl.Text) || 
                        !float.TryParse(txths1.Text, out hs1)|| 
                        !float.TryParse(txths2.Text, out hs2)|| 
                        !float.TryParse(txtdt.Text, out thi)||
                        !float.TryParse(txttl.Text, out thilai))
                    {
                        MessageBox.Show("Hãy nhập vào là số");
                        conn.Close();
                        return;
                    } 
                    if(hs1>10||hs1<0|| hs2>10||hs2<0|| thi > 10 || thi < 0 || thilai > 10 || thilai < 0)
                    {
                        MessageBox.Show("Hãy nhập vào trong khoảng 0 đến 10");
                        conn.Close();
                        return; 
                    }
                    cmd.CommandText = "update diem set hs1 = N'" + hs1 + "', hs2='" + hs2 + "', thi = '" + thi + "', thilai = '" + thilai + "'  where monhoc = N'" + mon + "' and  msv ='" + ma + "' ";
                    cmd.ExecuteNonQuery();

                    dtdiem.Clear();
                    dtdiem = new DataTable();
                    adapterdiem = new SqlDataAdapter("select msv as'Mã sv', monhoc as'Môn học', hs1 as'Điểm hs1', hs2 as'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where msv ='"+ma+"'",conn);
                    adapterdiem.Fill(dtdiem);
                    dataGridView2.DataSource = dtdiem;

            
            conn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = txtmsv.Text;
            string mon = txtmon.Text;
            conn.Open();
            cmd.CommandText = "delete from diem where monhoc = N'" + mon + "' and msv = '" + ma + "'";
            cmd.ExecuteNonQuery();

            dtdiem.Clear();
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter("select msv as 'Mã sv', monhoc as'Môn học', hs1 as 'Điểm hs1', hs2 as'Điểm hs2', thi as 'Thi', thilai as'Thi lại' from diem where msv = '" + ma + "'", conn);
            adapterdiem.Fill(dtdiem);
            dataGridView2.DataSource = dtdiem;
            conn.Close( );  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tk = comboBox1.Text;
            if(dataGridView1.DataSource is DataTable dt){
                dt.DefaultView.RowFilter = string.Empty;
                if (!string.IsNullOrEmpty(tk))
                {
                    dt.DefaultView.RowFilter = $"[Lớp] like '%{tk}%'";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=banghtap;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            //bảng sv
            dtsv = new DataTable();
            adaptersv = new SqlDataAdapter("select msv as 'Mã sv', ht as 'Họ tên', lop as 'Lớp' from sv", conn);
            adaptersv.Fill(dtsv);
            dataGridView1.DataSource = dtsv;

            //bảng diem
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter("select msv as 'Mã sv', monhoc as 'Môn học', hs1 as 'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem   ",conn);
            adapterdiem.Fill(dtdiem);
            dataGridView2.DataSource = dtdiem;
            string countsv = "select count(*) from sv";
            cmd = new SqlCommand(countsv, conn);
            int count = (int)cmd.ExecuteScalar();
            label3.Text = "Có " + count.ToString() + " sinh viên";

            cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Close();
        }
    }
}
