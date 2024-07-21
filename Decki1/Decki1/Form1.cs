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

namespace Decki1
{
    public partial class Form1 : Form
    {
        string connstr = @"Data Source=SNOWBALL;Initial Catalog=qlbh;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt= new DataTable();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn=new SqlConnection(connstr);
            conn.Open();
            LoadData();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from banhang";
            //cmd.ExecuteNonQuery();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            //SqlDataReader reader= cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    string mahang = reader.GetString(0);
            //    dt.Rows.Add(mahang);
            //    string tenkh = reader.GetString(1);
            //    string tenhang = reader.GetString(2);
            //    string sl = reader.GetString(3);
            //    string dongia = reader.GetString(4);
            //}

         
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
