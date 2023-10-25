using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001215616_NguyenKeBao
{
    public partial class QuanLySinhVien : Form
    {
        SqlConnection conn;       
        string constr = "Data Source= A209PC06;Initial Catalog= QL_SinhVien;Integrated Security = true";
        public QuanLySinhVien()
        {
            InitializeComponent();
            conn = new SqlConnection(constr);
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString;
                insertString = "Insert into TTSinhVien Values(" + text_id.Text + " ,N'" + text_Name.Text + "')";

                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string updateString;
                updateString = "update TTSinhVien set Name=N'" + text_Name.Text + "' where ID=" + text_id.Text + "";

                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Sửa thành công!");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string deleteString;
                deleteString = "delete TTSinhVien where ID=" + text_id.Text + "";

                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void hienthi_Click(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("Select * from TTSinhVien",conn);
            var table = new DataTable();
            dap.Fill(table);
            dgvSinhVien.DataSource = table;

        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Kết nối thành công");
            }
            catch {
                MessageBox.Show("Kết nối thất bại");
            }

        }
    }
}
