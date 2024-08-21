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

namespace QuanLyCanBo
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int row = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=snowball;Initial Catalog=qlcb;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();

            dt = new DataTable();
            adapter = new SqlDataAdapter("select macb as'Mã CB', ht as 'Họ tên', nsinh as'Ngày sinh', gt as 'Giới tính', email as 'Email',phone as 'Phone' from canbo   ",conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            cmd = new SqlCommand();
            cmd.Connection = conn;  
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ht = txtten.Text;
            string gt;
            if (rdNam.Checked == true) gt = "Nma";
            else gt = "Nữ";
            string mail = txtmail.Text;
            int  phone = Convert.ToInt32(txtphone.Text);
            DateTime ns = dateTimePicker1.Value;
            conn.Open();
            string sql = "select count(*) from canbo where macb ='" + ma + "'";
            SqlCommand checkcma = new SqlCommand(sql, conn);
            checkcma.ExecuteNonQuery();
            int count = (int)checkcma.ExecuteScalar();
            if(count == 0)
            {
                cmd.CommandText = "insert into canbo values('"+ma+"', N'"+ht+"', N'"+gt+"', '"+mail+"', '"+ns+"', '"+phone+"')";
                cmd.ExecuteNonQuery();

                dt = new DataTable();
                adapter = new SqlDataAdapter("select macb as 'Mã CB',  ht as 'Họ tên', nsinh as 'Ngày sinh', gt as 'Giới tính', email as 'Email', phone as 'Phone' from canbo ",conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Bạn đã nhập trùng mã");
            }
            conn.Close();
        }
    }
}
