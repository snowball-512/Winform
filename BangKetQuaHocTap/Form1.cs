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
using System.Security.Cryptography;

namespace BangKetQuaHocTap
{
    public partial class Form1 : Form
    {
        int row = -1;
        SqlConnection conn;
        SqlDataAdapter adapter, adapter2;
        DataTable dt, dt2;
        SqlCommand cmd;

        private void dtSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row < dtSV.Rows.Count)
            {
                string selectMSv = dtSV.Rows[row].Cells[0].Value.ToString(); // Sử dụng chỉ số cột thay vì tên cột
                string sql = "SELECT msv AS 'Mã sinh viên', monhoc AS 'Môn học', diem_hs1 AS 'Điểm hệ số 1', diem_hs2 AS 'Điểm hệ số 2', diem_thi AS 'Điểm thi', diem_thi_lai AS 'Điểm thi lại' FROM diem WHERE msv = N'" + selectMSv + "' ";

                cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapsvter = new SqlDataAdapter(cmd);
                DataTable dtsv = new DataTable();
                adapsvter.Fill(dtsv);
                dtDiem.DataSource = dtsv;

                // Cập nhật các TextBox với dữ liệu từ dtDiem
                if (dtDiem.Rows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtDiem.Rows[0];
                    txtmsv.Text = dtSV.Rows[row].Cells[0].Value.ToString();
                    txtht.Text = dtSV.Rows[row].Cells[1].Value.ToString();
                    cbbLop.Text = dtSV.Rows[row].Cells[2].Value.ToString();

                    txtmon.Text = selectedRow.Cells[1].Value?.ToString() ;
                    txths1.Text = selectedRow.Cells[2].Value?.ToString();
                    txths2.Text = selectedRow.Cells[3].Value?.ToString();
                    txtthi.Text = selectedRow.Cells[3].Value?.ToString();
                    txtthilai.Text = selectedRow.Cells[4].Value?.ToString();
                }
            }
        }


        private void dtDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if(row>=0 && row < dtDiem.Rows.Count)
            {
                txtmon.Text = dtDiem.Rows[row].Cells[1].Value.ToString();
                txths1.Text = dtDiem.Rows[row].Cells[2].Value.ToString();
                txths2.Text = dtDiem.Rows[row].Cells[3].Value.ToString();
                txtthi.Text = dtDiem.Rows[row].Cells[4].Value.ToString();
                txtthilai.Text = dtDiem.Rows[row].Cells[5].Value.ToString();
            }
        }

        private void dtDiem_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtDiem_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string msv = txtmsv.Text;
            string ht = txtht.Text;
            string lop = cbbLop.Text;
            string monhoc = txtmon.Text;

            // Check if student exists
            string checkMSV = $"SELECT COUNT(*) FROM kqht WHERE msv = '{msv}'";
            SqlCommand checkcmd = new SqlCommand(checkMSV, conn);
            int count = (int)checkcmd.ExecuteScalar();

            // Add new student if not exists
            if (count == 0)
            {
                if (string.IsNullOrWhiteSpace(ht) || string.IsNullOrWhiteSpace(lop))
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin sinh viên.");
                    return;
                }
                string insertStudent = $"INSERT INTO kqht (msv, hoten, lop) VALUES ('{msv}', N'{ht}', N'{lop}')";
                new SqlCommand(insertStudent, conn).ExecuteNonQuery();
            }
         
                // Add grades
                if (string.IsNullOrWhiteSpace(txths1.Text) || string.IsNullOrWhiteSpace(txths2.Text) ||
                    string.IsNullOrWhiteSpace(txtthi.Text) || string.IsNullOrWhiteSpace(txtthilai.Text) ||
                    string.IsNullOrWhiteSpace(monhoc) ||
                    !float.TryParse(txths1.Text, out float hs1) ||
                    !float.TryParse(txths2.Text, out float hs2) ||
                    !float.TryParse(txtthi.Text, out float thi) ||
                    !float.TryParse(txtthilai.Text, out float thilai))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin điểm và đảm bảo điểm là số từ 0 đến 10.");
                    return;
                }

                string insertDiem = $"INSERT INTO diem (msv, monhoc, diem_hs1, diem_hs2, diem_thi, diem_thi_lai) VALUES ('{msv}', N'{monhoc}', {hs1}, {hs2}, {thi}, {thilai})";
                new SqlCommand(insertDiem, conn).ExecuteNonQuery();
            
            // Update data displays
            string updateStudentList = "SELECT msv AS 'Mã sinh viên', hoten AS 'Tên sinh viên', lop AS 'Lớp' FROM kqht";
            string updateStudentGrades = $"SELECT msv AS 'Mã sinh viên', monhoc AS 'Môn học', diem_hs1 AS 'Điểm hệ số 1', diem_hs2 AS 'Điểm hệ số 2', diem_thi AS 'Điểm thi', diem_thi_lai AS 'Điểm thi lại' FROM diem WHERE msv = '{msv}'";

            dt.Clear();
            new SqlDataAdapter(updateStudentList, conn).Fill(dt);
            dtSV.DataSource = dt;

            dt2.Clear();
            new SqlDataAdapter(updateStudentGrades, conn).Fill(dt2);
            dtDiem.DataSource = dt2;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string msv =txtmsv.Text;
            string ht =txtht.Text;
            string lop= cbbLop.Text;
            string mon = txtmon.Text;
            float hs1, hs2, thi, thilai;
            
            string updatestu = $"update kqht set hoten = N'{ht}', lop ='{lop}' where msv = '{msv}' ";
            new SqlCommand(updatestu, conn).ExecuteNonQuery();

         
                if (string.IsNullOrWhiteSpace(txths1.Text) ||
                string.IsNullOrWhiteSpace(txths2.Text) ||
                string.IsNullOrWhiteSpace(txtthi.Text) ||
                string.IsNullOrWhiteSpace(txtthilai.Text) ||
                !float.TryParse(txths1.Text, out hs1) ||
                !float.TryParse(txths2.Text, out hs2) ||
                !float.TryParse(txtthi.Text, out thi) ||
                !float.TryParse(txtthilai.Text, out thilai))
                {
                    MessageBox.Show("Hãy nhập điểm từ 0 đến 10", "Lỗi");
                    return;
                }
                string updiem = $"update diem set monhoc = N'{mon}', diem_hs1='{hs1}', diem_hs2='{hs2}', diem_thi='{thi}', diem_thi_lai='{thilai}' where msv = '{msv}'";
                new SqlCommand(updiem, conn).ExecuteNonQuery();
            
            string updatestulist = "select msv as 'Mã sinh viên', hoten as 'Tên sinh viên', lop as 'Lớp'from kqht";
            string updatediem = $"select msv as 'Mã sinh viên', monhoc as'Môn học', diem_hs1 as 'Điểm hệ số 1', diem_hs2 as'Điểm hệ số 2', diem_thi as 'Điểm thi', diem_thi_lai as 'Điểm thi lại'from diem where msv='{msv}' ";

            dt.Clear();
            new SqlDataAdapter(updatestulist, conn).Fill(dt);   
            dtSV.DataSource= dt;

            dt2.Clear();
            new SqlDataAdapter(updatediem, conn).Fill(dt2);
            dtDiem.DataSource= dt2;

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (row >= 0 && row < dtSV.Rows.Count)
            {
                string msv = dtSV.Rows[row].Cells[0].Value.ToString();

                // Check if related records exist in the 'diem' table for the selected student
                cmd.CommandText = "select count(*) from diem where msv = N'" + msv + "'";
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    if (row >= 0 && row < dtDiem.Rows.Count)
                    {
                        string mon = dtDiem.Rows[row].Cells[1].Value.ToString();

                        // Delete the selected score for the subject
                        cmd.CommandText = "delete from diem where msv = N'" + msv + "' ";
                        cmd.ExecuteNonQuery();

                        // Update dtDiem DataGridView
                        dt2.Clear();
                        adapter2 = new SqlDataAdapter("select msv as 'Mã sinh viên', monhoc as 'Môn học', diem_hs1 as 'Điểm hệ số 1', diem_hs2 as 'Điểm hệ số 2', diem_thi as 'Điểm thi', diem_thi_lai as 'Điểm thi lại' from diem  ", conn);
                        adapter2.Fill(dt2);
                        dtDiem.DataSource = dt2;

                        if (dt2.Rows.Count == 0)
                        {
                            MessageBox.Show("Không còn dữ liệu điểm");
                        }
                    }
                }

                // After deleting scores, check if there are any remaining scores for the student
                cmd.CommandText = "select count(*) from diem where msv = N'" + msv + "'";
                count = (int)cmd.ExecuteScalar();

                if (count == 0)
                {
                    // No remaining scores, delete the student record
                    cmd.CommandText = "delete from kqht where msv = N'" + msv + "'";
                    cmd.ExecuteNonQuery();

                    // Update dtSV DataGridView
                    dt.Clear();
                    adapter = new SqlDataAdapter("select msv as 'Mã sinh viên', hoten as 'Tên sinh viên', lop as 'Lớp' from kqht", conn);
                    adapter.Fill(dt);
                    dtSV.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không còn dữ liệu sinh viên");
                    }
                }
            }
        }




        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=dbkqht;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            conn = new SqlConnection(sql);

            conn.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter("Select msv as 'Mã sinh viên', hoten as 'Tên sinh viên',lop as 'Lớp' from kqht ", conn);
            adapter.Fill(dt);
            dtSV.DataSource = dt; 

            dt2 = new DataTable();
            adapter2 = new SqlDataAdapter("Select msv as 'Mã sinh viên', monhoc as 'Môn học', diem_hs1 as 'Điểm hệ số 1', diem_hs2 as 'Điểm hệ số 2', diem_thi as 'Điểm thi', diem_thi_lai as 'Điểm thi lại' from diem", conn);
            adapter2.Fill(dt2);
            dtDiem.DataSource = dt2;

            cmd =  new SqlCommand();
            cmd.Connection = conn;
            cbbLop.DataSource = dt;
            cmd = new SqlCommand("select distinct lop from kqht", conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dtLop = new DataTable();
            adapter.Fill(dtLop);

            cbbLop.DataSource = dtLop;
            cbbLop.DisplayMember = "lop";
            cbbLop.ValueMember = "lop";
        }
    }
}
