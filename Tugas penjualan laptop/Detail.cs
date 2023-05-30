using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_penjualan_laptop
{
    public partial class Detail : Form
    {
        private string connstring = String.Format("Server=localhost;Port=5432;User Id=postgres;Password=Unumber1;Database=JualLaptop;");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;
        public Detail()
        {
            InitializeComponent();
        }
        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"select * from Select_detail()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView1.DataSource = null; // reser data grid view
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Detail_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtboxiddetail.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_detail_transaksi"].Value.ToString();
                txtboxidtransaksi.Text = dataGridView1.Rows[e.RowIndex].Cells["idtransaksi"].Value.ToString();
                txtboxidlaptop.Text = dataGridView1.Rows[e.RowIndex].Cells["Idlaptop"].Value.ToString();
                txtboxjumlah.Text = dataGridView1.Rows[e.RowIndex].Cells["jumlah_dibeli"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxiddetail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
