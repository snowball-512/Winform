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

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        int dongHt = -1;
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
            rbNam.Checked = true;
            string sql = "Data Source=SNOWBALL;Initial Catalog=ks;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter("Select makh as 'Stt', tenkh as'Tên khách hàng', CASE WHEN gioitinh = 0 THEN N'Nữ' WHEN gioitinh = 1 THEN 'Nam'       ELSE 'Không xác định'   END AS 'Giới tính', loaiphong as 'Loại phòng', sophongthue as 'Số phòng cần thuê'from khachsan", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd = new SqlCommand();
            cmd.Connection = conn;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //dongHt = e.RowIndex;
            //if(dongHt >=0 && dongHt < dataGridView1.Rows.Count)
            //{
            //    txttenkh.Text = dataGridView1.Rows[dongHt].Cells[1].Value.ToString();
            //    string gt = dataGridView1.Rows[dongHt].Cells[2].Value.ToString();
            //    if (gt == "Nam") rbNam.Checked = true;
            //    else
            //    {
            //        rbNu.Checked = true;
            //    }
            //    cbbLoaiphong.Text = dataGridView1.Rows[dongHt].Cells[3].Value.ToString();
            //    txtsophong.Text = dataGridView1.Rows[dongHt].Cells[4].Value.ToString();
            //}
        }
        public void new_adapter()
        {
            dt.Clear();
            adapter = new SqlDataAdapter("Select makh as 'Stt', tenkh as'Tên khách hàng', CASE WHEN gioitinh = 0 THEN N'Nữ' WHEN gioitinh = 1 THEN 'Nam' ELSE 'Không xác định' END AS 'Giới tính', loaiphong as 'Loại phòng', sophongthue as 'Số phòng cần thuê' from khachsan", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txttenkh.Text;
            int gt = rbNam.Checked ? 1 : 0;
            string loaiphong = cbbLoaiphong.Text;
            if (!int.TryParse(txtsophong.Text, out int sophong))
            {
                txtsophong.Focus();
                MessageBox.Show("Hãy nhập vào là số");
                return;
            }

            cmd.CommandText = "insert into khachsan values (N'" + ten + "', N'" + gt + "', N'" + loaiphong + "', N'" + sophong + "')";
            cmd.ExecuteNonQuery();

            // Clear the search text box
            tkkh.Clear();

            // Reload the entire table data
            new_adapter();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dongHt>=0 && dongHt < dataGridView1.Rows.Count)
            {
                string ten = txttenkh.Text;
                int gt = rbNam.Checked ? 1 : 0;
                string loaiphong = cbbLoaiphong.Text;
                if(!int.TryParse(txtsophong.Text, out int sophong)){
                    txtsophong.Focus();
                    MessageBox.Show("Hãy nhập vào là số");
                    return;
                    
                }
                cmd.CommandText = "update khachsan set tenkh = N'" + ten + "', gioitinh = N'" + gt + "', loaiphong = N'" + loaiphong + "', sophongthue='" + sophong + "' where tenkh = N'" + ten + "'";
                cmd.ExecuteNonQuery();
                dt.Clear();
                new_adapter();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dongHt>=0 && dongHt < dataGridView1.Rows.Count){
                string makh= dataGridView1.Rows[dongHt].Cells[0].Value.ToString();
                cmd.CommandText = "delete from khachsan where makh = N'"+makh+"'";
                cmd.ExecuteNonQuery();
                new_adapter();


            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dl");
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            
                string tenKhachHang = tkkh.Text;
                string sql = "select makh as 'Stt', tenkh as'Tên khách hàng', " +
                             "CASE WHEN gioitinh = 0 THEN N'Nữ' WHEN gioitinh = 1 THEN N'Nam' ELSE N'Không xác định' END AS 'Giới tính', " +
                             "loaiphong as 'Loại phòng', sophongthue as 'Số phòng cần thuê' " +
                             "from khachsan where tenkh like N'%" + tenKhachHang + "%'";

                cmd.CommandText = sql;
                dt.Clear();
                adapter = new SqlDataAdapter(cmd.CommandText, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay");
                new_adapter();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDataInMessageBox();
        }
        private void ShowDataInMessageBox()
        {
            StringBuilder sb = new StringBuilder();

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Loop through each cell in the row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Append the cell value to the StringBuilder, followed by a tab for separation
                    sb.Append(cell.Value + "\t");
                }

                // Append a new line after each row
                sb.AppendLine();
            }

            // Show the constructed string in a MessageBox
            MessageBox.Show(sb.ToString(), "DataGridView Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongHt = e.RowIndex;
            if(dongHt >=0 && dongHt < dataGridView1.Rows.Count)
            {
                txttenkh.Text = dataGridView1.Rows[dongHt].Cells[1].Value.ToString();
                string gt = dataGridView1.Rows[dongHt].Cells[2].Value.ToString();
                if (gt == "Nam") rbNam.Checked = true;
                else  rbNu.Checked = true;
                cbbLoaiphong.Text = dataGridView1.Rows[dongHt].Cells[3].Value.ToString();
                txtsophong.Text = dataGridView1.Rows[dongHt].Cells[4].Value.ToString();


            }
        }
    }
}
