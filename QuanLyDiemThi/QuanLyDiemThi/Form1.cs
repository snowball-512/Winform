using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDiemThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = "Data Source=SNOWBALL;Initial Catalog=qldiem; Integrated Security=True";
        SqlConnection conn = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                string sql = "select * from qlydiemsv";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    dgvql.Rows.Add(row["msv"], row["tensv"], row["toan"], row["van"], row["anh"]);
                }

                cbmsv.DataSource = dt;
                cbmsv.DisplayMember = "msv";
                cbmsv.ValueMember = "msv";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

       

        private void dgvql_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Changed from e.RowIndex == 0 to e.RowIndex >= 0 to ensure correct row index
            {
                DataGridViewRow row = dgvql.Rows[e.RowIndex];
                MessageBox.Show("Selected MSV: " + row.Cells["msv"].Value.ToString());
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into qlydiemsv (tensv, toan, van, anh) values(N'" + txtht.Text + "', '"+ txttoan.Text+"', '"+txtvan.Text+"', '"+txtanh.Text+"')"; 
            cmd.ExecuteNonQuery();
        }
    }
}
