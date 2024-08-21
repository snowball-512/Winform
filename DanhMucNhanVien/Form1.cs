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
namespace DanhMucNhanVien
{
    public partial class Form1 : Form
    {
        int row = -1;
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=dvnk;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();

            dt = new DataTable();
            adapter = new SqlDataAdapter("select makh as 'Mã KH', ht as 'Họ tên', nsinh as 'Ngày sinh', dc as 'Địa chỉ', dvsd as 'Dịch vụ sử dụng' from nk", conn); 
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cmd = new SqlCommand();
            cmd.Connection = conn;  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ht = txtht.Text;
            DateTime ns = dateTimePicker1.Value;
            string dc= txtdc.Text;
            string dv;
            if (rdCaoVoi.Checked == true) dv = "Cạo vôi";
            else if (rdTaytrang.Checked == true) dv = "Tẩy trắng";
            else dv = "Trám răng";
            cmd.CommandText = "insert into nk values ('" + ma + "', N'" + ht + "', '" + ns + "', N'" + dc + "', N'"+dv+"')";
            cmd.ExecuteNonQuery();

            resetdata();
            txtma.Clear();
            txtdc.Clear();
            txtht.Clear();
            rdCaoVoi.Checked = false;
            rdTaytrang.Checked = false;
            rdtram.Checked = false;

        }
        public void resetdata()
        {
            dt.Clear();
            dt= new DataTable();
            adapter = new SqlDataAdapter("select makh as 'Mã KH', ht as 'Họ tên', nsinh as 'Ngày sinh', dc as 'Địa chỉ', dvsd as 'Dịch vụ sử dụng' from nk", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                txtma.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtht.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                txtdc.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                string dv = dataGridView1.Rows[row].Cells["Dịch vụ sử dụng"].Value.ToString();
                if(dv=="Cạo vôi") rdCaoVoi.Checked = true;  
                else if(dv=="Tẩy trắng") rdTaytrang.Checked = true;
                else rdtram.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                string ht = txtht.Text;
                DateTime ns = dateTimePicker1.Value;
                string dc = txtdc.Text;
                string dv = "";
                if (rdCaoVoi.Checked == true) dv = "Cạo vôi";
                else if (rdTaytrang.Checked == true) dv = "Tẩy trắng";
                else dv = "Trám răng";
                cmd.CommandText = "update nk set ht=N'" + ht + "', nsinh = '" + ns + "', dc =N'" + dc + "', dvsd =N'" + dv + "' where makh= '" + ma + "' ";
                cmd.ExecuteNonQuery();
                resetdata();
                txtma.Clear();
                txtdc.Clear();
                txtht.Clear();
                rdCaoVoi.Checked = false;
                rdTaytrang.Checked = false;
                rdtram.Checked = false;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "delete from nk where makh= '" + ma + "' ";
                cmd.ExecuteNonQuery();
                resetdata();
                txtma.Clear();
                txtdc.Clear();
                txtht.Clear();
                rdCaoVoi.Checked = false;
                rdTaytrang.Checked = false;
                rdtram.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtht.Clear();
            txtdc.Clear();
            rdCaoVoi.Checked = false;
            rdTaytrang.Checked=false;
            rdtram.Checked = false;
            txtma.Focus();
        }

        private void txttkten_TextChanged(object sender, EventArgs e)
        {
            
            string tk = txttkten.Text;
            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Empty;
                if (!string.IsNullOrEmpty(tk))
                {
                    dt.DefaultView.RowFilter = $"[Họ tên]  like '%{tk}%' or [Mã KH]  like '%{tk}%'";

                }
            }
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
