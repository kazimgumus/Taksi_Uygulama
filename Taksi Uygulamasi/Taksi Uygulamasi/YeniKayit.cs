using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Taksi_Uygulamasi
{
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = ("Data Source=ASUS-ASUS?\\SQLEXPRESS");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("select from * MusteriEkle", baglanti);
        SqlDataReader oku = komut.ExecuteReader();

        while (oku.Read())
        {
            ListViewItem ekle = new ListViewItem();
        ekle.Text = oku["Musteriid"].ToString();
        ekle.SubItems.Add["Adi"].ToString();
        ekle.SubItems.Add["Soyadi"].ToString();
        ekle.SubItems.Add["Telefon"].ToString();
        ekle.SubItems.Add["Mail"].ToString();
        ekle.SubItems.Add["KullaniciAdi"].ToString();
        ekle.SubItems.Add["kayit"].ToString();

    }
}

private void Kayıt_Enter(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("istert into MusteriEkle (Adi,Soyadı,KullaniciAdi,Mail,Telefon) values ('" + TxtAdi.Text",''" + TxtSoyadi.Text"','" + TxtKullaniciAdi.Text"','" + TxtMail.Text"')", baglanti);
        }
    }
}
