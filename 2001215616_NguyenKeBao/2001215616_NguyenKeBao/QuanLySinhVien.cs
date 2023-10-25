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
        Connect cn = new Connect();
        SqlConnection connsql;
        public QuanLySinhVien()
        {
            InitializeComponent();
            connsql = cn.conn;
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("Select * from TTSinhVien", connsql);
            var table = new DataTable();
            dap.Fill(table);
            comboBoxSV.DisplayMember = "ID";
            comboBoxSV.ValueMember = "ID";
            comboBoxSV.DataSource = table;
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                insertString = "Insert into TTSinhVien Values(" + text_id.Text + " ,N'" + text_Name.Text + "')";

                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
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
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string updateString;
                updateString = "update TTSinhVien set Name=N'" + text_Name.Text + "' where ID=" + text_id.Text + "";

                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
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
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string deleteString;
                deleteString = "delete TTSinhVien where ID=" + text_id.Text + "";

                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                connsql.Open();
                MessageBox.Show("Kết nối thành công");
            }
            catch {
                MessageBox.Show("Kết nối thất bại");
            }

        }

        private void comboBoxSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxSV.SelectedValue);
            var dap = new SqlDataAdapter("select Name from TTSinhVien where ID= " + id + "", connsql);
            var table = new DataTable();
            dap.Fill(table);
            dgvSinhVien.DataSource = table;
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hienthi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxSV.SelectedValue);
            var dap = new SqlDataAdapter("select * from TTSinhVien", connsql);
            var table = new DataTable();
            dap.Fill(table);
            hienthitatca.DataSource = table;
        }
    }
}
