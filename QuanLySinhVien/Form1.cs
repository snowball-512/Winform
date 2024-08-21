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
namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        int row = -1;
        SqlDataAdapter adapter; 
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=qlsvtl;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();

            dt = new DataTable();
            adapter = new SqlDataAdapter("select masv as 'Mã sinh viên', tensv as 'Tên sinh viên', nsinh as 'Ngày sinh', diachi as 'Địa chỉ' from sinhvien", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row= e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                txtma.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtten.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ma=txtma.Text;
            string ten = txtten.Text;
            DateTime ns = dateTimePicker1.Value;
            string dc = comboBox1.Text;
            cmd.CommandText = "insert into sinhvien values ('"+ma+"', N'"+ten+"', '"+ns+"', N'"+dc+"')";
            cmd.ExecuteNonQuery();

            dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter("select masv as 'Mã sinh viên', tensv as 'Tên sinh viên', nsinh as 'Ngáy sinh', diachi as 'Địa chỉ' from sinhvien",conn);
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
            //dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                string ten = txtten.Text;
                string dc = comboBox1.Text;
                string nsinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                cmd.CommandText = "update sinhvien set tensv=N'" + ten + "', nsinh = '" + nsinh + "', diachi =N'" + dc + "' where masv= '" + ma + "' ";
                cmd.ExecuteNonQuery();

                dt.Clear();
                dt = new DataTable();
                adapter = new SqlDataAdapter("select masv as'Mã sinh viên', tensv as 'Tên sinh viên', nsinh as 'Ngày sinh', diachi as 'Địa chỉ' from sinhvien",conn);
                adapter.Fill(dt);
                dataGridView1.DataSource= dt;
                dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(row>=0 &&  row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "delete from sinhvien where masv ='" + ma + "'";
                cmd.ExecuteNonQuery();
                dt.Clear();
                dt = new DataTable();
                adapter = new SqlDataAdapter("select masv as 'Mã sinh viên', tensv as 'Tên sinh viên', nsinh as 'Ngày sinh', diachi as 'Địa chỉ' from sinhvien ", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource= dt;
                //dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void tkten_TextChanged(object sender, EventArgs e)
        {
            string tk = tkten.Text;
            cmd.CommandText = "select masv as'Mã sinh viên', tensv as 'Tên sinh viên', nsinh as'Ngày sinh', diachi as 'Địa chỉ' from sinhvien where tensv like '" + tk + "'";
            cmd.ExecuteNonQuery();
            dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd.CommandText, conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không tìm thấy dữ liệu");
            //}
        }
    }
}
