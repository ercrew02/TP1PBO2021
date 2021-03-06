using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class Form1 : Form
    {
        List<barang> databarang = new List<barang>();
        String jenisbarang;
        int hargabarangtinggi;
        int hargabarangrendah;


        public Form1()
        {
            InitializeComponent();
            addbarang();
            filterProses(this.jenisbarang, this.hargabarangtinggi, this.hargabarangrendah);
        }

        public void addbarang()
        {
            this.databarang.Add(new barang("Greenlight", 100000, "6", "pakaian"));
            this.databarang.Add(new barang("Hoodie", 200000, "5", "pakaian"));
            this.databarang.Add(new barang("Kulkas", 800000, "3", "elektronik"));
            this.databarang.Add(new barang("Nasi goreng", 100000, "2", "makanan"));
            this.databarang.Add(new barang("Roti kukus", 250000, "4", "makanan"));
            this.databarang.Add(new barang("Nasi liwet", 100000, "2", "makanan"));
            this.databarang.Add(new barang("Roti jepang", 2500000, "4", "makanan"));
        }
        private void btnkatalog_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.tokopedia.com/");
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {

        }

        Panel createlist(string nama, string harga, string id, string jenis)
        {
            Panel panelmain = new Panel();
            Label lblhargabarang = new Label();
            Label lblnamabarang = new Label();
            Button button1 = new Button();

            panelmain.Controls.Add(lblhargabarang);
            panelmain.Controls.Add(lblnamabarang);
            panelmain.Controls.Add(button1);
            panelmain.Location = new System.Drawing.Point(3, 3);
            panelmain.Name = "panelmain";
            panelmain.Size = new System.Drawing.Size(144, 154);
            panelmain.TabIndex = 0;
            panelmain.BackColor = System.Drawing.Color.Blue;
            
            lblhargabarang.AutoSize = true;
            lblhargabarang.Location = new System.Drawing.Point(32, 79);
            lblhargabarang.Name = "lblhargabarang";
            lblhargabarang.Size = new System.Drawing.Size(73, 13);
            lblhargabarang.TabIndex = 2;
            lblhargabarang.Text = harga;

            lblnamabarang.AutoSize = true;
            lblnamabarang.Location = new System.Drawing.Point(32, 66);
            lblnamabarang.Name = "lblnamabarang";
            lblnamabarang.Size = new System.Drawing.Size(72, 13);
            lblnamabarang.TabIndex = 1;
            lblnamabarang.Text = nama;
       
            button1.Location = new System.Drawing.Point(29, 105);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Beli";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler((object sender, EventArgs e) => {
                Detail menu2 = new Detail(id);
                this.Hide();
                menu2.Show();
            });
            return panelmain;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBoxJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox value = (ComboBox)sender;
            value.DropDownStyle = ComboBoxStyle.DropDownList;
            this.jenisbarang = value.SelectedItem.ToString().ToLower();
        }

        private void comboBoxHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox value = (ComboBox)sender;
            value.DropDownStyle = ComboBoxStyle.DropDownList;
            ambilharga(value.SelectedItem.ToString().ToLower());
        }

        private void ambilharga(string value)
        {
            if(value == "100rb - 200rb")
            {
                this.hargabarangrendah = 100000;
                this.hargabarangtinggi = 100000;
            }else if(value == "200rb - 500rb"){
                this.hargabarangrendah = 200000;
                this.hargabarangtinggi = 500000;
            }else if(value == "500rb - 1jt"){
                this.hargabarangrendah = 500000;
                this.hargabarangtinggi = 1000000;
            }
        }



        void filterProses(string jenisBarang, int hargabarangtinggi, int hargabarangterendah)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var data in this.databarang)
            {
                Panel Createlist = createlist(data.getnamabarang, data.gethargabarang.ToString(), data.getidbarang, data.getjenisbarang);
                if (data.getjenisbarang.ToLower() == jenisBarang)
                {
                    if (data.gethargabarang >= hargabarangrendah && data.gethargabarang <= hargabarangtinggi)
                    {
                        flowLayoutPanel1.Controls.Add(Createlist);
                    }
                    else if (hargabarangterendah == 0)
                    {
                        flowLayoutPanel1.Controls.Add(Createlist);
                    }
                }
                else if (jenisBarang == null)
                {
                    if (data.gethargabarang >= hargabarangterendah && data.gethargabarang <= hargabarangtinggi)
                    {
                        flowLayoutPanel1.Controls.Add(Createlist);
                    }
                    else if (hargabarangterendah == 0)
                    {
                        flowLayoutPanel1.Controls.Add(Createlist);
                    }
                }
            }
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            filterProses(this.jenisbarang, this.hargabarangtinggi, this.hargabarangrendah);
        }
    }

    class barang
    {
        public barang(string nama, int harga, string id, string jenis)
        {
            getnamabarang = nama;
            gethargabarang = harga;
            getidbarang = id;
            getjenisbarang = jenis;
        }
        public string getnamabarang
        {
            get; set;
        }

       public int gethargabarang
        {
            get; set;
        }

        public string getidbarang
        {
            get; set;
        }
       public string getjenisbarang
        {
            get; set;
        }
    }
}
