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
//using QuanLyBanHang;
using QuanLyNhanSu;

//using System.Data;


namespace QuanLyNhanSu
{
    public partial class ThanNhan : Form
    {
        public ThanNhan()
        {
            InitializeComponent();
        }

        public void load()
        {
            connect.openketnoi();
            dataGridView1.DataSource = connect.gettable("select * from ThanNhan");
            connect.dongketnoi();
        }
        private void ThanNhan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataGridView1.CurrentCell.RowIndex;            
            textBox1.Text = dataGridView1.Rows[t].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[t].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[t].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[t].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[t].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.openketnoi();
            string filter = "[dbo].[ThanNhan_NV]'" + textBox1.Text + "'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                connect.openketnoi();
                connect.executeQuery("delete from ThanNhan where TenTN= N'" + textBox2.Text + "' ");
                load();
                connect.dongketnoi();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.openketnoi();
                connect.executeQuery(" ThemThanNhan_NV '" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "','" + textBox4.Text + "',N'" + textBox5.Text + "' ");
                load();
                connect.dongketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            connect.openketnoi();
            connect.executeQuery("update ThanNhan set GioiTinh=N'" + textBox3.Text  +"',NgaySinh='" + DateTime.Parse(textBox4.Text) +  "',QuanHe=N'" + textBox5.Text + "' where TenTN=N'" +textBox2.Text + "'");
            load();
            connect.dongketnoi();
        }
    }   
}