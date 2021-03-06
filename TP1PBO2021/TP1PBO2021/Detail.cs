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
    public partial class Detail : Form
    {
        List<barang> databarang = new List<barang>();
        public Detail(string id)
        {
            InitializeComponent();
            addbarang();
            foreach (var data in this.databarang)
            {
                if (data.getidbarang.ToString() == id)
                {
                    flowLayoutPanel1.Controls.Add(createlistdetail(data.getnamabarang, data.gethargabarang.ToString(), data.getidbarang, data.getjenisbarang));
                }
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnkatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.tokopedia.com/");
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        Panel createlistdetail(string nama, string harga, string id, string jenis)
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

            return panelmain;
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
    }
}
