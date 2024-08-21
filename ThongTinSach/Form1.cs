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
namespace ThongTinSach
{
    public partial class Form1 : Form
    {
        int row = -1;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter; 
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=qlysach;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();

            //dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter("select ma as 'Mã sách', tieude as 'Tiêu đề', format(gia,'N0') as'Giá', sl as'Số lượng', loaisach as 'Loại sách', (gia*sl) as 'Thanh toán' from sach", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText ="select distinct loaisach from sach";
            adapter = new SqlDataAdapter(cmd);
            DataTable loaisach=  new DataTable();
            adapter = new SqlDataAdapter(cmd.CommandText, conn);
            adapter.Fill(loaisach);
            comboBox1.DataSource = loaisach;
            comboBox1.ValueMember = "loaisach";
            comboBox1.DisplayMember = "loaisach";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loaisach  = comboBox1.Text;
            string masach =txtma.Text;
            string tieude = txttieude.Text;
            decimal gia = Convert.ToDecimal(txtgia.Text);
            int sl = Convert.ToInt32(txtsl.Text);
            cmd.CommandText = "insert into sach values ('"+masach+"', N'"+tieude+"', '"+gia+"','"+sl+"', N'"+loaisach+"')";
            cmd.ExecuteNonQuery();

            dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter("select ma as 'Mã sách', tieude as 'Tiêu đề', format(gia,'N0') as 'Giá', sl as 'Số lượng', loaisach as 'Loại sách', (gia*sl) as'Thanh toán' from sach",conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                string ma= dataGridView1.Rows[row].Cells[0].Value.ToString() ;
                string tieude = txttieude.Text; 
                decimal gia = Convert.ToDecimal (txtgia.Text);
                string tien = gia.ToString("N0");
                int sl = Convert.ToInt32(txtsl.Text);
                string loaisach = comboBox1.Text;
                cmd.CommandText = "update sach set tieude =N'"+tieude+"', gia = '"+gia+"', sl = '"+sl+"', loaisach = N'"+loaisach+"' where ma = '"+ma+"' ";
                cmd.ExecuteNonQuery();  
                dt.Clear(); dt = new DataTable();
                adapter = new SqlDataAdapter("select ma as 'Mã sách', tieude as 'Tiêu đề', format(gia,'N0') as 'Giá', sl as 'Số lượng',loaisach as 'Loại sách' , (gia*sl) as 'Thanh toán' from sach",conn);

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "delete from sach where ma = '" + ma + "'";
                cmd.ExecuteNonQuery();
                dt.Clear(); dt = new DataTable();
                adapter = new SqlDataAdapter("select ma as 'Mã sách', tieude as 'Tiêu đề', format(gia,'N0') as'Giá', sl as 'Số lượng', loaisach as'Loại sách', (gia*sl) as 'Thanh toán' from sach",conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void txttieude_TextChanged(object sender, EventArgs e)
        {
            string tk = txttieude.Text;
            if(dataGridView1.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Empty;
                if (!string.IsNullOrEmpty(tk))
                {
                    dt.DefaultView.RowFilter = $"[Tiêu đề] like '%{tk}%'" ;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                txtma.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txttieude.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txtgia.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                txtsl.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            if(dataGridView1.DataSource is DataTable dt)
                {
                    dt.DefaultView.RowFilter =string.Empty;
                }
            }
        }
    }
}
