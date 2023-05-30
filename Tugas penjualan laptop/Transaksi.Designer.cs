namespace Tugas_penjualan_laptop
{
    partial class frmTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaksi));
            label1 = new Label();
            panel1 = new Panel();
            btnrefresh = new Button();
            dataGridView1 = new DataGridView();
            txtboxtanggal = new TextBox();
            lbltanggal = new Label();
            btnback = new Button();
            btndetail = new Button();
            lbltransaksi = new Label();
            txtboxidtransaksi = new TextBox();
            btnDelete = new Button();
            label2 = new Label();
            txtboxidlaptop = new TextBox();
            txtboxjumlah = new TextBox();
            label3 = new Label();
            btnInsert = new Button();
            button1 = new Button();
            label5 = new Label();
            txtboxnamapembeli = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(540, 34);
            label1.Name = "label1";
            label1.Size = new Size(217, 65);
            label1.TabIndex = 0;
            label1.Text = "Transaksi";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnrefresh);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtboxtanggal);
            panel1.Controls.Add(lbltanggal);
            panel1.Location = new Point(278, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 422);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(54, 364);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(112, 34);
            btnrefresh.TabIndex = 18;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(655, 273);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtboxtanggal
            // 
            txtboxtanggal.Location = new Point(147, 26);
            txtboxtanggal.Name = "txtboxtanggal";
            txtboxtanggal.ReadOnly = true;
            txtboxtanggal.Size = new Size(228, 31);
            txtboxtanggal.TabIndex = 9;
            // 
            // lbltanggal
            // 
            lbltanggal.AutoSize = true;
            lbltanggal.Location = new Point(54, 27);
            lbltanggal.Name = "lbltanggal";
            lbltanggal.Size = new Size(73, 25);
            lbltanggal.TabIndex = 7;
            lbltanggal.Text = "Tanggal";
            // 
            // btnback
            // 
            btnback.Location = new Point(844, 543);
            btnback.Name = "btnback";
            btnback.Size = new Size(112, 34);
            btnback.TabIndex = 4;
            btnback.Text = "Produk";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btndetail
            // 
            btndetail.Location = new Point(715, 543);
            btndetail.Name = "btndetail";
            btndetail.Size = new Size(112, 34);
            btndetail.TabIndex = 5;
            btndetail.Text = "Detail";
            btndetail.UseVisualStyleBackColor = true;
            btndetail.Click += btndetail_Click;
            // 
            // lbltransaksi
            // 
            lbltransaksi.AutoSize = true;
            lbltransaksi.Location = new Point(38, 123);
            lbltransaksi.Name = "lbltransaksi";
            lbltransaksi.Size = new Size(99, 25);
            lbltransaksi.TabIndex = 6;
            lbltransaksi.Text = "IDTransaksi";
            // 
            // txtboxidtransaksi
            // 
            txtboxidtransaksi.Location = new Point(38, 151);
            txtboxidtransaksi.Name = "txtboxidtransaksi";
            txtboxidtransaksi.Size = new Size(212, 31);
            txtboxidtransaksi.TabIndex = 8;
            txtboxidtransaksi.TextChanged += txtboxidtransaksi_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(85, 490);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 267);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 12;
            label2.Text = "IDLaptop";
            // 
            // txtboxidlaptop
            // 
            txtboxidlaptop.Location = new Point(38, 295);
            txtboxidlaptop.Name = "txtboxidlaptop";
            txtboxidlaptop.Size = new Size(212, 31);
            txtboxidlaptop.TabIndex = 13;
            // 
            // txtboxjumlah
            // 
            txtboxjumlah.Location = new Point(38, 369);
            txtboxjumlah.Name = "txtboxjumlah";
            txtboxjumlah.Size = new Size(212, 31);
            txtboxjumlah.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 341);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 15;
            label3.Text = "Jumlah yang dibeli";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(85, 437);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1043, 12);
            button1.Name = "button1";
            button1.Size = new Size(26, 29);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 199);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 6;
            label5.Text = "Nama Pembeli";
            // 
            // txtboxnamapembeli
            // 
            txtboxnamapembeli.Location = new Point(38, 227);
            txtboxnamapembeli.Name = "txtboxnamapembeli";
            txtboxnamapembeli.Size = new Size(212, 31);
            txtboxnamapembeli.TabIndex = 8;
            txtboxnamapembeli.TextChanged += txtboxidtransaksi_TextChanged;
            // 
            // frmTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1081, 600);
            Controls.Add(button1);
            Controls.Add(btnInsert);
            Controls.Add(label3);
            Controls.Add(txtboxjumlah);
            Controls.Add(txtboxidlaptop);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(txtboxnamapembeli);
            Controls.Add(label5);
            Controls.Add(txtboxidtransaksi);
            Controls.Add(lbltransaksi);
            Controls.Add(btndetail);
            Controls.Add(btnback);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransaksi";
            Text = "Transaksi";
            Load += frmTransaksi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnback;
        private Button btndetail;
        private Label lbltransaksi;
        private Label lbltanggal;
        private TextBox txtboxidtransaksi;
        private TextBox txtboxtanggal;
        private Button btnDelete;
        private Label label2;
        private TextBox txtboxidlaptop;
        private TextBox txtboxjumlah;
        private Label label3;
        private Button btnInsert;
        private Button button1;
        private Label label5;
        private TextBox txtboxnamapembeli;
        private Button btnrefresh;
    }
}