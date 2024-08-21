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
namespace QuanLyChucVu
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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(row>0 && row < dataGridView1.Rows.Count)
            {
                string mnv = dataGridView1.Rows[row].Cells["mnv"].Value.ToString();
                cmd.CommandText = "delete from chucdanh where mnv = '" + mnv + "'";
                cmd.ExecuteNonQuery();
                dt.Clear();
                dt = new DataTable();
                adapter = new SqlDataAdapter("select mnv, ten as 'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh', format(nsinh, 'dd/MM/yyyy') as 'Ngày sinh'from chucdanh", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["mnv"].Visible = false;
                textBox1.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                listBox1.ClearSelected();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=SNOWBALL;Initial Catalog=quanlychucdanh;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
           
            dt = new DataTable();
            adapter = new SqlDataAdapter("select mnv, ten as 'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh', format(nsinh,'dd/MM/yyyy') as 'Ngày sinh' from chucdanh ",conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand("select distinct quequan from chucdanh",conn);
            adapter = new SqlDataAdapter( cmd);
            DataTable quequan = new DataTable();
            adapter.Fill(quequan);
            comboBox1.DataSource = quequan;
            comboBox1.DisplayMember = "quequan";
            comboBox1.ValueMember = "quequan";
            dataGridView1.Columns["mnv"].Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ht = textBox1.Text;
            string gt;
            if (radioButton1.Checked) gt = "Nam";
            else gt = "Nữ";
            string que = comboBox1.Text;
            string chucdanh = "";
            for(int i=0; i<listBox1.SelectedItems.Count; i++)
            {
                chucdanh += listBox1.SelectedItems[i].ToString() + ".";
            }
            string nsinh= dateTimePicker1.Text;
            cmd.CommandText = "insert into chucdanh values ( N'"+ht+"', N'"+gt+"',  N'"+que+"', N'"+chucdanh+"','"+nsinh+"')";
            cmd.ExecuteNonQuery();
            dt.Clear();
            dt = new DataTable();
            adapter = new SqlDataAdapter("select mnv, ten as 'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh', format(nsinh,'dd/MM/yyyy') as 'Ngày sinh'from chucdanh", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["mnv"].Visible=false;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if(row>=0 && row < dataGridView1.Rows.Count)
            {
                textBox1.Text = dataGridView1.Rows[row].Cells["Tên"].Value.ToString();
                string gt = dataGridView1.Rows[row].Cells["Giới tính"].Value.ToString();
                if (gt =="Nam") radioButton1.Checked =true;
                else radioButton2.Checked=true;
                string chucdanh = dataGridView1.Rows[row].Cells["Chức danh"].Value.ToString();
                string quequan = dataGridView1.Rows[row].Cells["Quê quán"].Value.ToString() ;
                listBox1.ClearSelected();
                string[] items = chucdanh.Split('.');
                foreach(string item in items)
                {
                   
                    string i = item.Trim();
                    if (!string.IsNullOrWhiteSpace(i))
                    {
                        
                        for(int j =0; j < listBox1.Items.Count; j++)
                        {
                            if (listBox1.Items[j].ToString() == item)
                            {
                                listBox1.SetSelected(j, true);
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                string mnv = dataGridView1.Rows[row].Cells["mnv"].Value.ToString();
                string ht = textBox1.Text;
                string gt;
                if (radioButton1.Checked) gt = "Nam";
                else gt = "Nữ";
                string que = comboBox1.Text;
                string chucdanh = "";
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    chucdanh += listBox1.SelectedItems[i].ToString() + ".";
                }
                string nsinh = dateTimePicker1.Text;
                cmd.CommandText = "update chucdanh set ten = N'" + ht + "', gioitinh = N'" + gt + "', quequan = N'" + que + "', chucdanh = N'" + chucdanh + "', nsinh = '" + nsinh + "' where mnv = '"+mnv+"'";
                cmd.ExecuteNonQuery();
                dt.Clear();
                dt = new DataTable();
                adapter = new SqlDataAdapter("select mnv,  ten as 'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh',format( nsinh,'dd/MM/yyyy') as 'Ngày sinh' from chucdanh", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                string chucdanh = "";
                for(int i=0; i<listBox1.SelectedItems.Count; i++)
                {
                    chucdanh += listBox1.SelectedItems[i].ToString()+".";
                }
            if (chucdanh.EndsWith("."))
            {
                chucdanh = chucdanh.Remove(chucdanh.Length - 1);
            }
                cmd.CommandText = "select mnv, ten as 'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh', format( nsinh,'dd/MM/yyyy') as 'Ngày sinh' from chucdanh where chucdanh like N'%"+chucdanh+"%'";
                //cmd.ExecuteNonQuery();  
                dt.Clear(); dt = new DataTable();
                adapter = new SqlDataAdapter("select mnv , ten as'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh',format( nsinh, dd/MM/yyyy) as 'Ngày sinh' from chucdanh where chucdanh like N'%"+chucdanh+"%'",conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            
        }
    }
}
