using Npgsql;
using System.Data;

namespace Tugas_penjualan_laptop
{
    public partial class FormPL : Form
    {
        private string connstring = String.Format("Server=localhost;Port=5432;User Id=postgres;Password=Unumber1;Database=JualLaptop;");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;
        public FormPL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
            txtboxsearch.TextChanged += txtboxsearch_TextChanged;
        }
        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"select * from Select_laptop()";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtboxIDLaptop.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Laptop"].Value.ToString();
                txtboxNama.Text = dataGridView1.Rows[e.RowIndex].Cells["Nama"].Value.ToString();
                txtboxHarga.Text = dataGridView1.Rows[e.RowIndex].Cells["Harga"].Value.ToString();
                txtboxStok.Text = dataGridView1.Rows[e.RowIndex].Cells["Stokk"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTransaksi frmTransaksi = new frmTransaksi();
            frmTransaksi.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from Insert_laptop(:_nama_laptop, :_harga_laptop, :_stok)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_nama_laptop", txtboxNama.Text);
                    cmd.Parameters.AddWithValue("_harga_laptop", int.Parse(txtboxHarga.Text));
                    cmd.Parameters.AddWithValue("_stok", int.Parse(txtboxStok.Text));
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Berhasil menambahkan data baru yeay");
                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menanbahkan data hiiks2");
                    }

                    MessageBox.Show("insert Berhasil!!!");
                    Select();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("GaGal insert!! Error: " + ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0)
            {
                MessageBox.Show("Pilih Fans mana yang mau di update");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from Update_laptop (:_IDLaptop, :_nama_laptop, :_harga_laptop, :_stok)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_IDLaptop", int.Parse(dataGridView1.Rows[rowIndex].Cells["ID_Laptop"].Value.ToString()));
                cmd.Parameters.AddWithValue("_nama_laptop", txtboxNama.Text);
                cmd.Parameters.AddWithValue("_harga_laptop", int.Parse(txtboxHarga.Text));
                cmd.Parameters.AddWithValue("_stok", int.Parse(txtboxStok.Text));
                result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Berhasil memperbarui data yeay");
                    Select();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data hiiks2");
                }
                MessageBox.Show("Update Berhasil!!!");
                Select();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("GaGal update!! Error: " + ex.Message);
            }

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
                sql = @"select * from Delete_laptop(:_IDLaptop)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_IDLaptop", int.Parse(dataGridView1.Rows[rowIndex].Cells["ID_Laptop"].Value.ToString()));
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


        private void txtboxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            txtboxIDLaptop.Text = txtboxNama.Text = txtboxHarga.Text = txtboxStok.Text = null;
            txtboxNama.Select();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            Select();
            btnRefresh.Click += btnRefresh_Click;
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

        private void txtboxsearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtboxsearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    conn.Open();
                    if (int.TryParse(searchTerm, out int numericValue))
                    {
                        sql = $"select * from laptop where harga_laptop = {numericValue} or stok = {numericValue}";
                    }
                    else
                    {
                        sql = $"select * from laptop where nama_laptop ilike '%{searchTerm}%'";
                    }

                    cmd = new NpgsqlCommand(sql, conn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                Select(); // Load all data
            }

        }

        private void txtboxStok_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnweather_Click(object sender, EventArgs e)
        {
            frmweather frmweather = new frmweather();
            frmweather.ShowDialog();
        }

    
    }
}