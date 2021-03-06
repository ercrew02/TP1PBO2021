
namespace TP1PBO2021
{
    partial class Form1
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
            this.pnlheader = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnkatalog = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblnama = new System.Windows.Forms.Label();
            this.lblnim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllogo = new System.Windows.Forms.Label();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.comboBoxHarga = new System.Windows.Forms.ComboBox();
            this.btncari = new System.Windows.Forms.Button();
            this.lblketerangan = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblhargabarang = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlheader.Controls.Add(this.panel4);
            this.pnlheader.Controls.Add(this.panel6);
            this.pnlheader.Controls.Add(this.panel5);
            this.pnlheader.Controls.Add(this.btnhome);
            this.pnlheader.Controls.Add(this.btnkatalog);
            this.pnlheader.Controls.Add(this.btnlogout);
            this.pnlheader.Controls.Add(this.lblnama);
            this.pnlheader.Controls.Add(this.lblnim);
            this.pnlheader.Location = new System.Drawing.Point(120, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(682, 84);
            this.pnlheader.TabIndex = 0;
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(74, 33);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 3;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnkatalog
            // 
            this.btnkatalog.Location = new System.Drawing.Point(194, 33);
            this.btnkatalog.Name = "btnkatalog";
            this.btnkatalog.Size = new System.Drawing.Size(88, 23);
            this.btnkatalog.TabIndex = 4;
            this.btnkatalog.Text = "Web Katalog";
            this.btnkatalog.UseVisualStyleBackColor = true;
            this.btnkatalog.Click += new System.EventHandler(this.btnkatalog_Click_1);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(335, 33);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblnama.Location = new System.Drawing.Point(504, 39);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(114, 17);
            this.lblnama.TabIndex = 2;
            this.lblnama.Text = "Nama : Erlangga";
            // 
            // lblnim
            // 
            this.lblnim.AutoSize = true;
            this.lblnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblnim.Location = new System.Drawing.Point(504, 9);
            this.lblnim.Name = "lblnim";
            this.lblnim.Size = new System.Drawing.Size(100, 17);
            this.lblnim.TabIndex = 3;
            this.lblnim.Text = "NIM : 1909703";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBoxJenis);
            this.panel1.Controls.Add(this.comboBoxHarga);
            this.panel1.Controls.Add(this.btncari);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 451);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbllogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 84);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bersama PKI \r\nMembangun Negeri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbllogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbllogo.Location = new System.Drawing.Point(39, 35);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(0, 17);
            this.lbllogo.TabIndex = 7;
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.FormattingEnabled = true;
            this.comboBoxJenis.Items.AddRange(new object[] {
            "Elektronik",
            "Pakaian",
            "Makanan"});
            this.comboBoxJenis.Location = new System.Drawing.Point(11, 144);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(90, 21);
            this.comboBoxJenis.TabIndex = 3;
            this.comboBoxJenis.Text = "Jenis Barang";
            this.comboBoxJenis.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenis_SelectedIndexChanged);
            // 
            // comboBoxHarga
            // 
            this.comboBoxHarga.FormattingEnabled = true;
            this.comboBoxHarga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.comboBoxHarga.Location = new System.Drawing.Point(11, 185);
            this.comboBoxHarga.Name = "comboBoxHarga";
            this.comboBoxHarga.Size = new System.Drawing.Size(90, 21);
            this.comboBoxHarga.TabIndex = 2;
            this.comboBoxHarga.Text = "Harga Barang";
            this.comboBoxHarga.SelectedIndexChanged += new System.EventHandler(this.comboBoxHarga_SelectedIndexChanged);
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(11, 225);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(75, 23);
            this.btncari.TabIndex = 2;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // lblketerangan
            // 
            this.lblketerangan.AutoSize = true;
            this.lblketerangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblketerangan.Location = new System.Drawing.Point(164, 113);
            this.lblketerangan.Name = "lblketerangan";
            this.lblketerangan.Size = new System.Drawing.Size(110, 17);
            this.lblketerangan.TabIndex = 6;
            this.lblketerangan.Text = "Semua Barang: ";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(167, 133);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(608, 295);
            this.flowLayoutPanel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // lblhargabarang
            // 
            this.lblhargabarang.AutoSize = true;
            this.lblhargabarang.Location = new System.Drawing.Point(32, 88);
            this.lblhargabarang.Name = "lblhargabarang";
            this.lblhargabarang.Size = new System.Drawing.Size(66, 13);
            this.lblhargabarang.TabIndex = 2;
            this.lblhargabarang.Text = "Rp. 100.000";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(167, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 295);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::TP1PBO2021.Properties.Resources.logo_home_png_7412;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(57, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 23);
            this.panel4.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::TP1PBO2021.Properties.Resources.logout;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(317, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(23, 23);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::TP1PBO2021.Properties.Resources.catalog_icon_7343;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(175, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 23);
            this.panel5.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::TP1PBO2021.Properties.Resources.pkikomun;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(11, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 47);
            this.panel3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.lblketerangan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlheader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.MediumTurquoise;
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label lblnim;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnkatalog;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private System.Windows.Forms.ComboBox comboBoxHarga;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Label lblketerangan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblnamabarang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhargabarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

