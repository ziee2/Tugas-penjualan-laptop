namespace Tugas_penjualan_laptop
{
    partial class Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtboxiddetail = new TextBox();
            txtboxjumlah = new TextBox();
            txtboxidtransaksi = new TextBox();
            txtboxidlaptop = new TextBox();
            label5 = new Label();
            btnBack = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(319, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 418);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(658, 340);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 129);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 3;
            label1.Text = "ID detail transaksi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 216);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "id transaksi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 303);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "id laptop";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 385);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 6;
            label4.Text = " jumlah";
            // 
            // txtboxiddetail
            // 
            txtboxiddetail.Location = new Point(63, 169);
            txtboxiddetail.Name = "txtboxiddetail";
            txtboxiddetail.Size = new Size(150, 31);
            txtboxiddetail.TabIndex = 7;
            txtboxiddetail.TextAlign = HorizontalAlignment.Center;
            txtboxiddetail.TextChanged += txtboxiddetail_TextChanged;
            // 
            // txtboxjumlah
            // 
            txtboxjumlah.Location = new Point(63, 419);
            txtboxjumlah.Name = "txtboxjumlah";
            txtboxjumlah.Size = new Size(150, 31);
            txtboxjumlah.TabIndex = 8;
            txtboxjumlah.TextAlign = HorizontalAlignment.Center;
            // 
            // txtboxidtransaksi
            // 
            txtboxidtransaksi.Location = new Point(63, 258);
            txtboxidtransaksi.Name = "txtboxidtransaksi";
            txtboxidtransaksi.Size = new Size(150, 31);
            txtboxidtransaksi.TabIndex = 9;
            txtboxidtransaksi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtboxidlaptop
            // 
            txtboxidlaptop.Location = new Point(63, 342);
            txtboxidlaptop.Name = "txtboxidlaptop";
            txtboxidlaptop.Size = new Size(150, 31);
            txtboxidlaptop.TabIndex = 10;
            txtboxidlaptop.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(527, 29);
            label5.Name = "label5";
            label5.Size = new Size(353, 65);
            label5.TabIndex = 11;
            label5.Text = "Detail Transaksi";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(939, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1066, 12);
            button1.Name = "button1";
            button1.Size = new Size(26, 29);
            button1.TabIndex = 13;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1104, 613);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(txtboxidlaptop);
            Controls.Add(txtboxidtransaksi);
            Controls.Add(txtboxjumlah);
            Controls.Add(txtboxiddetail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Detail";
            Text = "Detail";
            Load += Detail_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtboxiddetail;
        private TextBox txtboxjumlah;
        private TextBox txtboxidtransaksi;
        private TextBox txtboxidlaptop;
        private Label label5;
        private Button btnBack;
        private Button button1;
    }
}