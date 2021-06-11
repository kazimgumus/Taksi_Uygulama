using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksi_Uygulamasi
{
    public partial class Mesaj : Form
    {
        public Mesaj()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = ("Data Source=ASUS-ASUS?\\SQLEXPRESS");
        private void verilergoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select from * Mesaj", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajid"].ToString();
                ekle.SubItems.Add["Adi"].ToString();
                ekle.SubItems.Add["Soyadi"].ToString();
                ekle.SubItems.Add["mesaj"].ToString();
               

            }
        }

        baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into MusteriEkle (Adi,Soyadı,KullaniciAdi,Mail,Telefon) values ('" + TxtAdi.Text",''" + TxtSoyadi.Text"','" + TxtKullaniciAdi.Text"','" + TxtMail.Text"')", baglanti);
    }
}
