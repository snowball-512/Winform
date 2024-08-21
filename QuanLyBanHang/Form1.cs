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

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        int row = -1;
        SqlConnection conn;
        SqlDataAdapter adapter, adapterAdd;
        DataTable dt, dt2;
        SqlCommand cmd; 
        public Form1()
        {
            InitializeComponent();
            cbbTL.TextChanged +=new EventHandler(cbbTL_TextChanged);
        }

        private void dtAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //int id = Convert.ToInt32(dtAdd.Rows[row].Cells[0].Value.ToString());
            //string tenkhach = txttenkhach.Text;
            //string tenhang = dtAdd.Rows[row].Cells[1].Value.ToString();
            //decimal dgia = Convert.ToDecimal(dtAdd.Rows[row].Cells[2].Value.ToString());
            //string theloai = cbbTL.Text;
            //int sl = Convert.ToInt32(numSl.Value);
            //cmd.CommandText = "insert into banhang values tenkhach = N'" + tenkhach + "', theloai=N'" + theloai + "',tenhang =N'" + tenhang + "', sl = '" + sl + "', dongia = '" + dgia + "' ";
            //cmd.ExecuteNonQuery();
            //dt.Clear();
            //adapter = new SqlDataAdapter("select mahang as 'STT', tenhang as 'Tên hàng',  sl as 'Số lượng', dongia as 'Đơn giá'",conn);
            //adapter.Fill(dt);
            //dtShow.DataSource = dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rowAdd = dtAdd.SelectedCells[0].RowIndex;
            string tenkhach = txttenkhach.Text;
            string tenhang = dtAdd.Rows[rowAdd].Cells[1].Value.ToString();
            decimal dgia = Convert.ToDecimal(dtAdd.Rows[rowAdd].Cells[2].Value.ToString());
            string theloai = cbbTL.Text;
            int sl = Convert.ToInt32(numSl.Value);
            cmd.CommandText = "INSERT INTO banhang (tenkhach, theloai, tenhang, sl, dongia) VALUES (N'" + tenkhach + "', N'" + theloai + "', N'" + tenhang + "', " + sl + ", " + dgia + ")"; conn.Open();
            //conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            dt.Clear();
            adapter = new SqlDataAdapter("select mahang as 'STT', tenhang as 'Tên hàng',  sl as 'Số lượng', dongia as 'Đơn giá', (dongia*sl) as 'Thanh toán' from banhang " , conn);
            adapter.Fill(dt);
            dtShow.DataSource = dt;
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select sum(sl*dongia) as 'Thanh toán' from banhang where 1=1";
            conn.Open();
            decimal tong = (decimal)cmd.ExecuteScalar();
            conn.Close();
            txtTT.Text = tong.ToString("C");
            

        }

        private void cbbTL_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cbbTL_TextChanged(object sender, EventArgs e)
        {
            //if (row >= 0 && row < dtAdd.Rows.Count)
            //{
            //    string theloai = cbbTL.Text;
            //    string sql = "select mahang as 'STT', tenhang as 'Tên hàng', dongia as 'Đơn giá' from banhang where theloai like N'%" + theloai + "%'";
            //    cmd.CommandText = sql;

            //    dt2.Clear();
            //    adapter = new SqlDataAdapter(cmd);
            //    adapter.Fill(dt2);
            //    dtAdd.DataSource = dt2;
            //}
            string theloai = cbbTL.Text;
            string tenkhach = txttenkhach.Text;

            // Construct the SQL query for dtAdd
            string sql = "select mahang as 'STT', tenhang as 'Tên hàng', dongia as 'Đơn giá' from banhang where 1=1";
            if (!string.IsNullOrEmpty(theloai))
            {
                sql += " and theloai like N'%" + theloai + "%'";
            }

            if (!string.IsNullOrEmpty(tenkhach))
            {
                sql += " and tenkhach like N'%" + tenkhach + "%'";
            }

            // Execute the first query for dtAdd
            cmd.CommandText = sql;
            dt2.Clear();
            adapterAdd = new SqlDataAdapter(cmd);
            adapterAdd.Fill(dt2);
            dtAdd.DataSource = dt2;

            // Construct the SQL query for dtShow
            string sqlShow = "select mahang as 'STT', tenhang as 'Tên hàng', dongia as 'Đơn giá', sl as 'Số lượng',(dongia * sl) as 'Thanh toán' from banhang where 1=1";
            if (!string.IsNullOrEmpty(theloai))
            {
                sqlShow += " and theloai like N'%" + theloai + "%'";
            }

            if (!string.IsNullOrEmpty(tenkhach))
            {
                sqlShow += " and tenkhach like N'%" + tenkhach + "%'";
            }

            // Execute the second query for dtShow
            cmd.CommandText = sqlShow;
            dt.Clear();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dtShow.DataSource = dt;
        }

        private void txttenkhach_TextChanged(object sender, EventArgs e)
        {
            
             
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtShow.SelectedRows.Count > 0) {
                row=dtShow.SelectedRows[0].Index;
                if(row>=0 && row < dtShow.Rows.Count)
                {
                    string mahang = dtShow.Rows[row].Cells[0].Value.ToString();
                    cmd.CommandText = "delete from banhang where mahang ='" + mahang + "' ";
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    dt.Clear();
                    adapter = new SqlDataAdapter("select mahang as 'STT', tenhang as 'Tên hàng', dongia as'Đơn giá', sl as 'Số lượng', (dongia*sl) as 'Thanh toán' from banhang", conn);
                    adapter.Fill(dt);
                    dtShow.DataSource = dt;

                    dt2.Clear();
                    adapterAdd = new SqlDataAdapter("select mahang as 'STT', tenhang as'Tên hàng', dongia as 'Đơn giá' from banhang ",conn);
                    adapterAdd.Fill(dt2);
                    dtAdd.DataSource = dt2;
                }
                //dtAdd.DataSource = dt2;
            }
        }

        private void btnDellAll_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete from banhang";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            dt.Clear();
            adapter = new SqlDataAdapter("select mahang as 'STT', tenhang as'Tên hàng', dongia as'Đơn giá', sl as 'Số lượng', (dongia*sl) as 'Thanh toán' from banhang", conn);
            adapter.Fill(dt);
            dtShow.DataSource = dt;

            dt2.Clear();
            adapterAdd = new SqlDataAdapter("select mahang as 'STT', tenhang as 'Tên hàng', dongia as 'Đơn giá'  from banhang", conn);
            adapter.Fill(dt2);
            dtAdd.DataSource = dt2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=qlybanhang;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            dt=  new DataTable();
            adapter = new SqlDataAdapter("select mahang as 'STT', tenhang as 'Tên hàng', sl as 'Số lượng', dongia as 'Đơn giá', (sl*dongia) as  'Thanh toán' from banhang", conn);
            adapter.Fill(dt);
            dtShow.DataSource = dt;

            dt2=new DataTable();
            adapterAdd = new SqlDataAdapter("select mahang as 'STT', tenhang as 'Tên hàng', dongia as 'Đơn giá' from banhang", conn);
            adapterAdd.Fill(dt2);
            dtAdd.DataSource = dt2;

            cmd = new SqlCommand();
            cmd.Connection = conn;


            cmd = new SqlCommand("select distinct theloai from banhang", conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable theloai = new DataTable();
            adapter.Fill(theloai);
            cbbTL.DataSource = theloai;
            cbbTL.DisplayMember = "theloai";
            cbbTL.ValueMember = "theloai";

            cmd = new SqlCommand("select tenkhach from banhang",conn);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                txttenkhach.Text= read["tenkhach"].ToString();
            }
            read.Close();
            conn.Close();
        }

        private void cbbTL_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //if (row >= 0 && row < dtAdd.Rows.Count)
            //{
            //    string theloai = cbbTL.Text;
            //    string sql = "select mahang as 'STT', tenhang as 'Tên hàng', dongia as 'Đơn giá' from banhang where theloai like N'" + theloai + "'";
            //    cmd.CommandText = sql;

            //    dt2.Clear();
            //    adapter = new SqlDataAdapter(cmd.CommandText, conn);
            //    adapter.Fill(dt2);
            //    dtAdd.DataSource = dt2;
            //}
           
        }
        
    }
}
