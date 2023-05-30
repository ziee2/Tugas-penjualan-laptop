namespace Tugas_penjualan_laptop
{
    partial class frmweather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmweather));
            button1 = new Button();
            lblkota = new Label();
            txtboxkota = new TextBox();
            btnsearch = new Button();
            lblkondisi = new Label();
            lbldetail = new Label();
            label3 = new Label();
            label4 = new Label();
            lblsunrise = new Label();
            lblsunset = new Label();
            label7 = new Label();
            lblwindspeed = new Label();
            label9 = new Label();
            lblpressure = new Label();
            picticon = new PictureBox();
            Suhu = new Label();
            lbltemp = new Label();
            ((System.ComponentModel.ISupportInitialize)picticon).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(821, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblkota
            // 
            lblkota.AutoSize = true;
            lblkota.BackColor = Color.Transparent;
            lblkota.FlatStyle = FlatStyle.Flat;
            lblkota.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblkota.ForeColor = SystemColors.ControlLightLight;
            lblkota.Location = new Point(117, 76);
            lblkota.Name = "lblkota";
            lblkota.Size = new Size(77, 26);
            lblkota.TabIndex = 1;
            lblkota.Text = "Kota :";
            // 
            // txtboxkota
            // 
            txtboxkota.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxkota.Location = new Point(203, 78);
            txtboxkota.Name = "txtboxkota";
            txtboxkota.Size = new Size(231, 33);
            txtboxkota.TabIndex = 2;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.Transparent;
            btnsearch.FlatStyle = FlatStyle.Flat;
            btnsearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.ForeColor = SystemColors.ControlLightLight;
            btnsearch.Location = new Point(475, 50);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(133, 86);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "SEARCH";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // lblkondisi
            // 
            lblkondisi.AutoSize = true;
            lblkondisi.BackColor = Color.Transparent;
            lblkondisi.FlatStyle = FlatStyle.Flat;
            lblkondisi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblkondisi.ForeColor = SystemColors.ControlLightLight;
            lblkondisi.Location = new Point(101, 282);
            lblkondisi.Name = "lblkondisi";
            lblkondisi.Size = new Size(106, 26);
            lblkondisi.TabIndex = 4;
            lblkondisi.Text = "Kondisi :";
            // 
            // lbldetail
            // 
            lbldetail.AutoSize = true;
            lbldetail.BackColor = Color.Transparent;
            lbldetail.FlatStyle = FlatStyle.Flat;
            lbldetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldetail.ForeColor = SystemColors.ControlLightLight;
            lbldetail.Location = new Point(101, 332);
            lbldetail.Name = "lbldetail";
            lbldetail.Size = new Size(74, 26);
            lbldetail.TabIndex = 5;
            lbldetail.Text = "Detail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(101, 380);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 6;
            label3.Text = "Sunrise :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(106, 429);
            label4.Name = "label4";
            label4.Size = new Size(99, 26);
            label4.TabIndex = 7;
            label4.Text = " Sunset :";
            // 
            // lblsunrise
            // 
            lblsunrise.AutoSize = true;
            lblsunrise.BackColor = Color.Transparent;
            lblsunrise.FlatStyle = FlatStyle.Flat;
            lblsunrise.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsunrise.ForeColor = SystemColors.ControlLightLight;
            lblsunrise.Location = new Point(230, 380);
            lblsunrise.Name = "lblsunrise";
            lblsunrise.Size = new Size(53, 26);
            lblsunrise.TabIndex = 8;
            lblsunrise.Text = "N/A";
            // 
            // lblsunset
            // 
            lblsunset.AutoSize = true;
            lblsunset.BackColor = Color.Transparent;
            lblsunset.FlatStyle = FlatStyle.Flat;
            lblsunset.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsunset.ForeColor = SystemColors.ControlLightLight;
            lblsunset.Location = new Point(230, 429);
            lblsunset.Name = "lblsunset";
            lblsunset.Size = new Size(53, 26);
            lblsunset.TabIndex = 9;
            lblsunset.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(425, 282);
            label7.Name = "label7";
            label7.Size = new Size(203, 26);
            label7.TabIndex = 10;
            label7.Text = "Kecepatan Angin :";
            // 
            // lblwindspeed
            // 
            lblwindspeed.AutoSize = true;
            lblwindspeed.BackColor = Color.Transparent;
            lblwindspeed.FlatStyle = FlatStyle.Flat;
            lblwindspeed.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblwindspeed.ForeColor = SystemColors.ControlLightLight;
            lblwindspeed.Location = new Point(657, 282);
            lblwindspeed.Name = "lblwindspeed";
            lblwindspeed.Size = new Size(53, 26);
            lblwindspeed.TabIndex = 11;
            lblwindspeed.Text = "N/A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(515, 325);
            label9.Name = "label9";
            label9.Size = new Size(113, 26);
            label9.TabIndex = 12;
            label9.Text = "Tekanan :";
            // 
            // lblpressure
            // 
            lblpressure.AutoSize = true;
            lblpressure.BackColor = Color.Transparent;
            lblpressure.FlatStyle = FlatStyle.Flat;
            lblpressure.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblpressure.ForeColor = SystemColors.ControlLightLight;
            lblpressure.Location = new Point(657, 325);
            lblpressure.Name = "lblpressure";
            lblpressure.Size = new Size(53, 26);
            lblpressure.TabIndex = 13;
            lblpressure.Text = "N/A";
            // 
            // picticon
            // 
            picticon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picticon.BackColor = Color.Transparent;
            picticon.Location = new Point(44, 137);
            picticon.Name = "picticon";
            picticon.Size = new Size(331, 110);
            picticon.SizeMode = PictureBoxSizeMode.Zoom;
            picticon.TabIndex = 14;
            picticon.TabStop = false;
            // 
            // Suhu
            // 
            Suhu.AutoSize = true;
            Suhu.BackColor = Color.Transparent;
            Suhu.FlatStyle = FlatStyle.Flat;
            Suhu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Suhu.ForeColor = SystemColors.ControlLightLight;
            Suhu.Location = new Point(549, 367);
            Suhu.Name = "Suhu";
            Suhu.Size = new Size(78, 26);
            Suhu.TabIndex = 15;
            Suhu.Text = "Suhu :";
            // 
            // lbltemp
            // 
            lbltemp.AutoSize = true;
            lbltemp.BackColor = Color.Transparent;
            lbltemp.FlatStyle = FlatStyle.Flat;
            lbltemp.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltemp.ForeColor = SystemColors.ControlLightLight;
            lbltemp.Location = new Point(657, 367);
            lbltemp.Name = "lbltemp";
            lbltemp.Size = new Size(53, 26);
            lbltemp.TabIndex = 16;
            lbltemp.Text = "N/A";
            // 
            // frmweather
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(865, 555);
            Controls.Add(lbltemp);
            Controls.Add(Suhu);
            Controls.Add(picticon);
            Controls.Add(lblpressure);
            Controls.Add(label9);
            Controls.Add(lblwindspeed);
            Controls.Add(label7);
            Controls.Add(lblsunset);
            Controls.Add(lblsunrise);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbldetail);
            Controls.Add(lblkondisi);
            Controls.Add(btnsearch);
            Controls.Add(txtboxkota);
            Controls.Add(lblkota);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmweather";
            Text = "weathering";
            Load += Formweather_Load;
            ((System.ComponentModel.ISupportInitialize)picticon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblkota;
        private TextBox txtboxkota;
        private Button btnsearch;
        private Label lblkondisi;
        private Label lbldetail;
        private Label label3;
        private Label label4;
        private Label lblsunrise;
        private Label lblsunset;
        private Label label7;
        private Label lblwindspeed;
        private Label label9;
        private Label lblpressure;
        private PictureBox picticon;
        private Label Suhu;
        private Label lbltemp;
    }
}