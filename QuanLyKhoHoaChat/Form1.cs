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

namespace QuanLyKhoHoaChat
{
    public partial class Form1 : Form
    {
        int row = -1;
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=qlykho;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            dt = new DataTable();
            data();
            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd = new SqlCommand("select distinct nhacc from kho", conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dtNcc = new DataTable();  
            adapter.Fill(dtNcc);
            cbncc.DataSource = dtNcc;
            cbncc.DisplayMember = "nhacc";
            cbncc.ValueMember = "nhacc";
        }
        private void data()
        {
        dt.Clear();
            adapter = new SqlDataAdapter("select ma as'Mã', nhacc as 'Nhà cung cấp', xuatxu as 'Xuất xứ', dongia as 'Đơn giá', sl as 'Số lượng' from kho ", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row=e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                txtma.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtxx.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                cbncc.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txtgia.Text= dataGridView1.Rows[row].Cells[3].Value.ToString();
               txtsl.Value = Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value.ToString());
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma= txtma.Text;  
            string xx= txtxx.Text;  
            string nhacc =  cbncc.Text;
            decimal dgia=0;
            int sl = Convert.ToInt32(txtsl.Text);
            string checkMa = "select count (*) from kho where ma = '" + ma + "'";
            SqlCommand macheck = new SqlCommand(checkMa, conn);
            int count = (int)macheck.ExecuteScalar();
            if (string.IsNullOrWhiteSpace(txtgia.Text) || !decimal.TryParse(txtgia.Text, out dgia))
            {
                // Nếu không nhập giá, để dgia giữ giá trị mặc định (0)
                if (!string.IsNullOrWhiteSpace(txtgia.Text))
                {
                    MessageBox.Show("Giá phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (count == 0)
            {
               

                cmd.CommandText = "insert into kho values ('" + ma + "', N'" + nhacc + "', N'" + xx + "', '" + dgia + "', '" + sl + "' )";
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Mã đã tồn tại");
            }

            
            data();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                string ma = txtma.Text;
                string ncc = cbncc.Text;
                int sl = Convert.ToInt32(txtsl.Text);
                string xx = txtxx.Text;
                decimal dgia=0;
                if(string.IsNullOrWhiteSpace(txtgia.Text)|| !decimal.TryParse(txtgia.Text, out dgia))
                {
                    if (!string.IsNullOrWhiteSpace(txtgia.Text))
                    {
                        txtgia.Focus();
                        MessageBox.Show("Hãy nhập giá là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                cmd.CommandText = "update kho set nhacc =N'"+ncc+"', xuatxu = N'"+xx+"', dongia = '"+dgia+"', sl = '"+sl+"' where ma = '"+ma+"' ";
                cmd.ExecuteNonQuery();
                data();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "delete from kho where ma ='" + ma + "'";
                cmd.ExecuteNonQuery();
                data();
                txtxx.Clear();
                txtgia.Clear();
                txtsl.Value = 0;
                txtma.Clear();

            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu","Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
