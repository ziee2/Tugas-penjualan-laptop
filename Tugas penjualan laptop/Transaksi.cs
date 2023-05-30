using Microsoft.VisualBasic;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tugas_penjualan_laptop
{
    public partial class frmTransaksi : Form
    {
        private string connstring = String.Format("Server=localhost;Port=5432;User Id=postgres;Password=Unumber1;Database=JualLaptop;");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;
        public frmTransaksi()
        {
            InitializeComponent();
        }

        private void frmTransaksi_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }
        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"select * from Select_transaksi()";
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
        private void btndetail_Click(object sender, EventArgs e)
        {
            Detail Detail = new Detail();
            Detail.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtboxidtransaksi.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Transaksi"].Value.ToString();
                txtboxnamapembeli.Text = dataGridView1.Rows[e.RowIndex].Cells["Nama_Pembeli"].Value.ToString();
                txtboxtanggal.Text = dataGridView1.Rows[e.RowIndex].Cells["Tanggal"].Value.ToString();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            this.Close();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from Insert_transaksi(:_NamaPembeli)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_NamaPembeli", txtboxnamapembeli.Text);
                cmd.ExecuteScalar();
                conn.Close();

                conn.Open();
                sql = @"select * from insert_detail(:_id_transaksi, :_id_laptop, :_jumlah)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_transaksi", int.Parse(txtboxidtransaksi.Text));
                cmd.Parameters.AddWithValue("_id_laptop", int.Parse(txtboxidlaptop.Text));
                cmd.Parameters.AddWithValue("_jumlah", int.Parse(txtboxjumlah.Text));
                cmd.ExecuteScalar();
                conn.Close();

                conn.Open();
                sql = $"UPDATE laptop SET stok = stok - (SELECT jumlah FROM detail_transaksi WHERE id_transaksi = {txtboxidtransaksi.Text}) WHERE IDLaptop = {txtboxidlaptop.Text}";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                MessageBox.Show("Transaksi berhasil!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtboxidtransaksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Pilih mana yang mau di hapus");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from Delete_transaksi(:_IDTransaksi)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_IDTransaksi", int.Parse(dataGridView1.Rows[rowIndex].Cells["ID_Transaksi"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Hapus Bwerhasil!!");
                    rowIndex = -1;

                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Hapus gagal!! Error: " + ex.Message);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            Select();
            btnrefresh.Click += btnrefresh_Click;
        }
        private void RefreshDataGridView()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            conn.Close();
        }
    }
}
