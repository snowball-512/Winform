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
namespace QuanLySanPham
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
            timesx.Format = DateTimePickerFormat.Custom;
            timesx.CustomFormat = "dd/MM/yyyy";
            timhh.Format = DateTimePickerFormat.Custom;
            timhh.CustomFormat = "dd/MM/yyyy";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=qlysp;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();


            dt = new DataTable();
            adapter = new SqlDataAdapter("select masp as 'MaSP', tensp as'TenSP', ngaysx as 'NgaySX', ngayhh as  'NgayHH', donvi as 'Đơn vị', dongia as 'Đơn giá', ghichu as'Ghi chú' from sanpham", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd = new SqlCommand();
            cmd.Connection = conn;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yy";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txtten.Text;
            string dv = txtdv.Text;
            decimal dgia = Convert.ToDecimal(txtgia.Text);
            string note = txtnote.Text;
            DateTime sx = timesx.Value;
            DateTime hh = timhh.Value;

            cmd.CommandText = "insert into sanpham values ('"+ma+"', N'"+ten+"', '"+sx+"', '"+hh+"', N'"+dv+"', '"+dgia+"', N'"+note+"') ";
            cmd.ExecuteNonQuery();

            dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter("select masp as 'MaSP', tensp as 'TenSP', format(ngaysx, 'dd/MM/yyyy') as 'NgaySX', format(ngayhh, 'dd/MM/yyyy') as 'NgayHH', donvi as 'Đơn vị', dongia as 'Đơn giá', ghichu as 'Ghi chú'from sanpham" ,conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            txtma.Clear();
            txtten.Clear();
            txtdv.Clear();
            txtgia.Clear();
            txtnote.Clear();
            openform2();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if(row>=0 && row<dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                string ten = txtten.Text;
                DateTime sx = timesx.Value;
                DateTime hh =timhh.Value;
                string dv = txtdv.Text;
                string gia = txtgia.Text;
                string note = txtnote.Text;
                cmd.CommandText = "update sanpham set tensp = N'"+ten+"', ngaysx='"+sx+"', ngayhh='"+hh+"', donvi=N'"+dv+"', dongia='"+gia+"', ghichu= N'"+note+"' where masp = '"+ma+"' ";
                cmd.ExecuteNonQuery();

                dt.Clear();
                dt = new DataTable();
                adapter = new SqlDataAdapter("select masp as 'MaSP',tensp as 'TenSP', format(ngaysx, 'dd/MM/yyyy') as 'NgaySX', format(ngayhh, 'dd/MM/yyyy') as 'NgayHH', donvi as 'Đơn vị', dongia as 'Đơn giá', ghichu as 'Ghi chú' from sanpham ", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                txtma.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtten.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                timesx.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                timhh.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                txtdv.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
                txtgia.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
                txtnote.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
                btndel.Enabled = true;
                btnedit.Enabled = true;
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                string ma = dataGridView1.Rows[row].Cells[0].Value.ToString();
                cmd.CommandText = "delete from sanpham where masp = '" + ma + "'";
                cmd.ExecuteNonQuery();

                dt.Clear();
                dt = new DataTable();
                adapter = new SqlDataAdapter("select masp as 'MaSP', tensp as 'TenSP', ngaysx as 'NgaySX', ngayhh as'NgayHH', donvi as 'Đơn vị', dongia as 'Đơn giá', ghichu as'Ghi chú' from sanpham",conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            txtdv.Clear();
            txtgia.Clear(); 
            txtma.Clear();
            txtnote.Clear();
            txtten.Clear();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string mattk = txttkma.Text;
            string ten = txttkten.Text;
            cmd.CommandText = "select masp as'MaSP', tensp as 'TenSP', ngaysx as'NgaySX', ngayhh as 'NgayHH', donvi as 'Đơn vị', dongia as 'Đơn giá', ghichu as 'Ghi chú' from sanpham where masp like '%" + mattk + "%' and tensp like N'%" + ten + "%'";
            cmd.ExecuteNonQuery();
            dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd.CommandText,conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count ==0)
            {
                MessageBox.Show("Không tìm thấy dl");
            }
            openform2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private  void openform2()
        {
            Form2 form2 = new Form2();
            form2.setDatasource(dt);
            form2.Show();
        }
    }
}
