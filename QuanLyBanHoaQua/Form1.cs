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
namespace QuanLyBanHoaQua
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=snowball;Initial Catalog=qlbanhang;Integrated Security=True";
           
            conn=  new SqlConnection(sql);
            conn.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter("select mahang as 'STT', tensp as 'Tên sản phẩm', dongia as 'Đơn giá', sl as 'Số lượng', (dongia * sl) as 'Thành tiền' from banhang", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand();
            cmd.Connection = conn;
            if (dt != null)
            {
                decimal sum = 0;
                foreach(DataRow row in dt.Rows)
                {
                    if (row["Thành tiền"] != DBNull.Value)
                    {
                        sum += Convert.ToDecimal(row["Thành tiền"]);

                    }
                    
                }
                txtt.Text = sum.ToString();
            }
            conn.Close();


        }

        private void txttra_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Na": txtgia.Text = "2000"; break;
                case "Vải": txtgia.Text = "3000"; break;
                case "Nhãn": txtgia.Text = "1500"; break;
                case "Mít": txtgia.Text = "2507"; break;
                case "Đào": txtgia.Text = "3890"; break;
                case "Dưa vàng": txtgia.Text = "3600"; break;
                case "Bơ": txtgia.Text = "7000";break;
            }
//            Na
//Vải
//Nhãn
//Mít
//Đào
//Dưa vàng
//Bơ
        }


        private void txtgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tensp = comboBox1.Text;
            decimal dgia = Convert.ToDecimal(txtgia.Text);
            int sl = Convert.ToInt32(numericUpDown1.Value);

            cmd.CommandText = "insert into banhang values (N'"+tensp+"', '"+dgia+"', '"+sl+"')";
            conn.Open();
            cmd.ExecuteNonQuery();

            dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter(" select mahang as 'STT', tensp as 'Tên sản phẩm', dongia as'Đơn giá', sl as 'Số lượng', (dongia * sl) as 'Thành tiền' from banhang",conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            string tt = "select sum(dongia*sl) as 'Thành tiền' from banhang";
            SqlCommand sumcmd = new SqlCommand(tt, conn);
            object kq = sumcmd.ExecuteScalar();
            txtt.Text = kq.ToString();
          
            Form2 f2 = new Form2(dt);
            f2.Show();
            conn.Close();
        }

        private void txtt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal tt = Convert.ToDecimal(txtt.Text);
            decimal tiendua;
            if (string.IsNullOrWhiteSpace(txtdua.Text))
            {
                MessageBox.Show("Hãy nhập vào là số");
                return;
            }
            if (!decimal.TryParse(txtdua.Text, out tiendua))
            {
                MessageBox.Show("Hãy nhập vào là số");
                return;
            }
            if (tt > tiendua)
            {
                decimal kh = tt / tiendua;
                txttra.Text = kh.ToString();
            }
            else
            {
                decimal kh = tiendua-tt;
                txttra.Text  ="Kh thừa: " + kh.ToString();
            }

            
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(row>=0&& row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "delete from banhang where mahang = '" + ma + "'";
                conn.Open();
                cmd.ExecuteNonQuery();

                dt.Clear();
                dt = new DataTable();
                adapter = new SqlDataAdapter("select mahang as 'STT', tensp as 'Tên sản phẩm', dongia as 'Đơn giá', sl as 'Số lượng', (dongia * sl) as'Thành tiền' from banhang    ",conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if(row>=0  && row < dataGridView1.Rows.Count)
            {
                conn.Open();
                comboBox1.Text = dataGridView1.Rows[row].Cells[1].Value.ToString(); 
                txtgia.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                numericUpDown1.Value = Convert.ToDecimal(dataGridView1.Rows[row].Cells[3].Value.ToString());
            }  
            conn.Close() ;
        }
    }
}
