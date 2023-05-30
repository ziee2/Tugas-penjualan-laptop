namespace Tugas_penjualan_laptop
{
    partial class FormPL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPL));
            btnTransaksi = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            btnweather = new Button();
            btnRefresh = new Button();
            btnClearS = new Button();
            txtboxsearch = new TextBox();
            lblsearch = new Label();
            pictureBox1 = new PictureBox();
            txtboxStok = new TextBox();
            txtboxHarga = new TextBox();
            txtboxNama = new TextBox();
            txtboxIDLaptop = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTransaksi
            // 
            btnTransaksi.Location = new Point(443, 536);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(721, 41);
            btnTransaksi.TabIndex = 0;
            btnTransaksi.Text = "transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(593, 12);
            label1.Name = "label1";
            label1.Size = new Size(347, 55);
            label1.TabIndex = 1;
            label1.Text = "Laptop product";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(443, 95);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(721, 423);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1262, 12);
            button1.Name = "button1";
            button1.Size = new Size(26, 29);
            button1.TabIndex = 3;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnweather);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnClearS);
            panel1.Controls.Add(txtboxsearch);
            panel1.Controls.Add(lblsearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtboxStok);
            panel1.Controls.Add(txtboxHarga);
            panel1.Controls.Add(txtboxNama);
            panel1.Controls.Add(txtboxIDLaptop);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnTransaksi);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 631);
            panel1.TabIndex = 4;
            // 
            // btnweather
            // 
            btnweather.Location = new Point(30, 543);
            btnweather.Name = "btnweather";
            btnweather.Size = new Size(359, 34);
            btnweather.TabIndex = 20;
            btnweather.Text = "weathering";
            btnweather.UseVisualStyleBackColor = true;
            btnweather.Click += btnweather_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1052, 55);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClearS
            // 
            btnClearS.Location = new Point(122, 351);
            btnClearS.Name = "btnClearS";
            btnClearS.Size = new Size(86, 34);
            btnClearS.TabIndex = 18;
            btnClearS.Text = "Clear";
            btnClearS.UseVisualStyleBackColor = true;
            btnClearS.Click += btnSave_Click;
            // 
            // txtboxsearch
            // 
            txtboxsearch.Location = new Point(559, 50);
            txtboxsearch.Name = "txtboxsearch";
            txtboxsearch.Size = new Size(351, 31);
            txtboxsearch.TabIndex = 17;
            txtboxsearch.TextChanged += txtboxsearch_TextChanged;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Location = new Point(471, 50);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(64, 25);
            lblsearch.TabIndex = 16;
            lblsearch.Text = "Search";
            lblsearch.Click += lblsearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtboxStok
            // 
            txtboxStok.Location = new Point(122, 314);
            txtboxStok.Name = "txtboxStok";
            txtboxStok.Size = new Size(267, 31);
            txtboxStok.TabIndex = 13;
            txtboxStok.TextChanged += txtboxStok_TextChanged;
            // 
            // txtboxHarga
            // 
            txtboxHarga.Location = new Point(122, 258);
            txtboxHarga.Name = "txtboxHarga";
            txtboxHarga.Size = new Size(267, 31);
            txtboxHarga.TabIndex = 12;
            // 
            // txtboxNama
            // 
            txtboxNama.Location = new Point(122, 201);
            txtboxNama.Name = "txtboxNama";
            txtboxNama.Size = new Size(267, 31);
            txtboxNama.TabIndex = 11;
            txtboxNama.TextChanged += txtboxNama_TextChanged;
            // 
            // txtboxIDLaptop
            // 
            txtboxIDLaptop.Location = new Point(122, 139);
            txtboxIDLaptop.Name = "txtboxIDLaptop";
            txtboxIDLaptop.Size = new Size(267, 31);
            txtboxIDLaptop.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 314);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 9;
            label5.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 258);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 8;
            label4.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 201);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 139);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 6;
            label2.Text = "IDLaptop";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(89, 426);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(96, 41);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(191, 426);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 41);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(293, 426);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 41);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormPL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1300, 715);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPL";
            Text = "Penjualan laptop ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTransaksi;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private TextBox txtboxStok;
        private TextBox txtboxHarga;
        private TextBox txtboxNama;
        private TextBox txtboxIDLaptop;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private TextBox txtboxsearch;
        private Label lblsearch;
        private Button btnClearS;
        private Button btnRefresh;
        private Button btnweather;
    }
}