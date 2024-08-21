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
namespace QLKQHT3
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adaptersv, adapterdiem;
        SqlCommand cmd;
        DataTable dtsv, dtdiem;
        int row = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            row = e.RowIndex;
            if(row>=0 && row < dataGridView1.Rows.Count ) 
            {

                //gọi msv
                string msv = dataGridView1.Rows[row].Cells[0].Value.ToString();
                //commandtext hiển thị ds môn theo msv
                cmd.CommandText = "Select masv as 'Mã sv', mon as 'Môn', hs1 as 'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where masv = '" + msv + "'";
                cmd.ExecuteNonQuery();//thực thi lệnh

                //tạo bảng dl
                dtsv = new DataTable();
                adaptersv = new SqlDataAdapter(cmd.CommandText, conn); //dataapdater (commandtext,conn)
                adaptersv.SelectCommand = cmd;//selectcommand=  cmd
                adaptersv.Fill(dtsv);
                dataGridView2.DataSource = dtsv;//hiển thị dl sv lên bảng2
                txtmsv.Text = msv;
                txtht.Text = dataGridView1.Rows[row].Cells["Họ tên"].Value.ToString();
                string gt = dataGridView1.Rows[row].Cells[2].Value.ToString();
                if (gt == "Nam") rdnam.Checked = true;
                else rdnu.Checked = true;
                cbblop.Text= dataGridView1.Rows[row].Cells[3].Value.ToString();
                if (dataGridView2.Rows.Count > 0)
                {
                    cbbmon.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                    txths1.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                    txths2.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
                    txtthi.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
                    txtthilai.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();

                }

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row=e.RowIndex;
            if(row>=0 && row < dataGridView2.Rows.Count && row< dataGridView1.Rows.Count)
            { 
                cbbmon.Text = dataGridView2.Rows[row].Cells[1].Value.ToString() ;
                txths1.Text = dataGridView2.Rows[row].Cells[2] .Value.ToString() ;
                txths2.Text = dataGridView2.Rows[row].Cells[3].Value.ToString() ;
                txtthi.Text = dataGridView2.Rows[row].Cells[4].Value.ToString() ;
                txtthilai.Text= dataGridView2.Rows[row].Cells[5].Value.ToString() ;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //thêm sv
            string msv = txtmsv.Text;
            string ht = txtht.Text;
            string lop = cbblop.Text;
            string gt = "";
            if (rdnam.Checked == true) gt = "Nam";
            else gt = "Nữ";
            //kiểm tra tồn tại msv giống nhau ko
            string checkmsv = "select count(*) from sv where masv = '" + msv + "'";//lệnh sql
            SqlCommand cndmsv = new SqlCommand(checkmsv,conn);//lệnh sqlcommand check,côn
            int countmsv = (int)cndmsv.ExecuteScalar();

            if (string.IsNullOrEmpty(txtmsv.Text) || string.IsNullOrEmpty(txtht.Text))
            {
                MessageBox.Show("Hãy nhập vào thông tin sinh viên");
                return;
            }
            //nếu countsv = 0 thì có thể thêm ko thì trùng
            if (countmsv == 0)
            {
                cmd.CommandText = "insert into sv values('"+msv+"', N'"+ht+"', N'"+lop+"', N'"+gt+"'  )";
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Mã sinh viên đã tồn tại. Chuyển sang thêm điểm");
            }
            //hiển thị lên bảng datagird1
            dtsv.Clear();
            dtsv = new DataTable();
            adaptersv = new SqlDataAdapter("select masv as'Mã sv', ht as 'Họ tên', gt as 'Giới tính', lop as'Lớp' from sv",conn);
            adaptersv.Fill(dtsv);
            dataGridView1.DataSource = dtsv;
            

            //thêm điểm
            string mon = cbbmon.Text;
            float hs1, hs2, thi, thilai;
            if( !float.TryParse(txths1.Text, out hs1)
                || !float.TryParse(txths2.Text, out hs2) 
                ||!float.TryParse(txtthi.Text, out thi)
                ||!float.TryParse(txtthilai.Text, out thilai))
            {
                MessageBox.Show("Hãy nhập vào là số trong khoảng 0 đến 10");
                return;
            }
            if (hs1 > 10 || hs1 < 0 || hs2 > 10 || hs2 < 0 || thi > 10 || thi < 0 || thilai > 10 || thilai < 0)
            {
                MessageBox.Show("Hãy nhập vào là số trong khoảng 0 đến 10");
                return; 
            }

            //check tồn tại môn học
            string sqlcheckmon = "select count(*) from diem where mon =N'" + mon + "' and masv = '" + msv + "' ";
            SqlCommand cmdcheckmon = new SqlCommand(sqlcheckmon, conn);
            int countmon = (int)cmdcheckmon.ExecuteScalar();
            if(countmon == 0)
            {
                cmd.CommandText = "insert into diem values('" + msv + "', N'" + mon + "', '" + hs1 + "' , '" + hs2 + "', '" + thi + "', '" + thilai + "'  )";
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Môn học đã tồn tại");
            }
            //hiển thị dl lên datagird2
            dtdiem.Clear();
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter("select masv as 'Mã sv', mon as 'Môn', hs1 as'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where masv = '"+msv+"'   ", conn);
            adapterdiem.Fill(dtdiem);
            dataGridView2.DataSource = dtdiem;

            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            //sửa sv
            string msv = txtmsv.Text;
            string ht = txtht.Text;
            string gt;
            if (rdnam.Checked ==true) gt = "Nam";
            else gt= "Nữ";
            string lop = cbblop.Text;

            //lệnh để update sv
            cmd.CommandText = "update sv set ht=N'" + ht + "', gt= N'" + gt + "', lop= N'" + lop + "' where masv = '" + msv + "'";
            cmd.ExecuteNonQuery();
            // hiển thị dl ra bảng datagird1
            dtsv.Clear();
            dtsv = new DataTable();
            adaptersv = new SqlDataAdapter(" select masv as 'Mã sv', ht as 'Họ tên', gt as 'Giới tính', lop as 'Lớp' from sv  ", conn);
            adaptersv.Fill(dtsv);
            dataGridView1.DataSource = dtsv;
          
            //sửa điểm, môn
            string mon = cbbmon.Text;
            float hs1, hs2, thi, thilai;
            if (string.IsNullOrWhiteSpace(txths1.Text)
                || string.IsNullOrWhiteSpace(txths2.Text)
                || string.IsNullOrWhiteSpace(txtthi.Text)
                ||string.IsNullOrWhiteSpace(txtthilai.Text)
                || !float.TryParse(txths1.Text, out hs1)
                || !float.TryParse(txths2.Text, out hs2)
                || !float.TryParse(txtthi.Text, out thi)
                || !float.TryParse(txtthilai.Text, out thilai))
            {
                MessageBox.Show("Hãy nhập vào là số trong khoảng 0 đến 10");
                return;
            }
            if (hs1 > 10 || hs1 < 0 || hs2 > 10 || hs2 < 0 || thi > 10 || thi < 0 || thilai > 10 || thilai < 0)
            {
                MessageBox.Show("Hãy nhập vào là số trong khoảng 0 đến 10");
                return;
            }

            //check tồn tại môn
            string sqlcheckmon = "select count(*) from diem where mon='" + mon + "' and masv=  '" + msv + "'";
            SqlCommand cmdcheckmon = new SqlCommand(sqlcheckmon, conn);
            int countmon = (int)cmdcheckmon.ExecuteScalar();
            if (countmon > 0)
            {
                //update môn nếu count>0 thì update môn
                cmd.CommandText = "update diem set  mon = N'" + mon + "', hs1 = '" + hs1 + "', hs2 = '" + hs2 + "', thi = '" + thi + "', thilai = '" + thilai + "' where masv= '" + msv + "' ";
                cmd.ExecuteNonQuery();
            }
            else
            {
                //còn ko thì môn tồn tại thi chuyển sang cập nhật điểm
                MessageBox.Show("Môn học đã tồn tại và chuyển sang cập nhật điểm");
                cmd.CommandText = "update diem set hs1 = '" + hs1 + "', hs2 = '" + hs2 + "', thi = '" + thi + "', thilai = '" + thilai + "' where masv= '" + msv + "' and  mon = N'" + mon + "'";
                cmd.ExecuteNonQuery();
            
            }
            //hiển thị lên datagirviw2
            dtdiem.Clear();
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter(" select masv as 'Mã sv',mon as 'Môn', hs1 as 'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where masv = '"+msv+"' ",conn);
            adapterdiem.Fill(dtdiem);
            dataGridView2.DataSource= dtdiem;
            

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string msv = txtmsv.Text;
            string mon = cbbmon.Text;
            cmd.CommandText = "delete from diem where masv = '" + msv + "'  ";
            cmd.ExecuteNonQuery();

            dtdiem.Clear();
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter("select masv as 'Mã sv', mon as 'Môn', hs1 as 'Điểm hs1', hs2 as 'Điểm hs2', thi as 'Điểm thi', thilai as 'Điểm thi lại' from diem where masv = '" + msv + "'", conn);
            adapterdiem.Fill(dtdiem);
            dataGridView2.DataSource= dtdiem;
        }

        private void txtmsv_TextChanged(object sender, EventArgs e)
        {
            //string tk = txtmsv.Text;
            //if (dataGridView1.DataSource is DataTable dt)
            //{
            //    dt.DefaultView.RowFilter = string.Empty;
            //    if (!string.IsNullOrEmpty(tk))
            //    {
            //        dt.DefaultView.RowFilter = $"[Mã sv] like '%{tk}%'";
            //    }
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tk = txttk.Text;
            if(dataGridView1.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Empty;
                if (!string.IsNullOrEmpty(tk))
                {
                    dt.DefaultView.RowFilter = $"[Mã sv] like '%{tk}%'";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(dtdiem);
            f3.ShowDialog();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=snowball;Initial Catalog=qlkqht3;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();

            //bảng sv
            dtsv = new DataTable();
            adaptersv = new SqlDataAdapter("select masv as 'Mã sv', ht as 'Họ tên', gt as 'Giới tính', lop as 'Lớp' from sv ", conn);
            adaptersv.Fill(dtsv);
            dataGridView1.DataSource = dtsv;

            //bảng điểm
            dtdiem = new DataTable();
            adapterdiem = new SqlDataAdapter("select masv 'Mã sv', mon as 'Môn', hs1 as 'Điểm hs1' ,  hs2 as 'Điểm hs2', thi as'Điểm thi', thilai as 'Điểm thi lại' from diem",conn  );
            adapterdiem.Fill(dtdiem);
            dataGridView2.DataSource = dtdiem;

            string sqlcountsv = "select count(*) from sv";
            SqlCommand cmdcountsv = new SqlCommand(sqlcountsv, conn);
            int countsv = (int)cmdcountsv.ExecuteScalar();

            lblcountsv.Text = "Có" + countsv.ToString() + " sinh viên";
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                string msv = dataGridView2.Rows[row].Cells[0].Value.ToString();
                string sqlcountmon = "select count(*) from diem where masv = '" + msv + "'";
                SqlCommand cmdmon = new SqlCommand(sqlcountmon, conn);
                int countmon = (int)cmdmon.ExecuteScalar();
                lblcountmon.Text = "Có " + countmon.ToString() + " điểm môn";
            }

            adaptersv = new SqlDataAdapter("select distinct lop from sv",conn);
            DataTable lop = new DataTable();
            adaptersv.Fill(lop);
            cbblop.DataSource = lop;
            cbblop.DisplayMember = "lop";
            cbblop.ValueMember = "lop";


            cmd = new SqlCommand();
            cmd.Connection = conn;
   
               
        }
    }
}
