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
    public partial class Soforler : Form
    {
        public Soforler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = ("Data Source=ASUS-ASUS?\\SQLEXPRESS");

        private void Soforler_Load(object sender, EventArgs e)
        {

        }
    }

    private void verilergoster()
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("select from * SoförEkle", baglanti);
        SqlDataReader oku = komut.ExecuteReader();

        while (oku.Read())
        {
            ListViewItem ekle = new ListViewItem();
            ekle.Text = oku["Soforid"].ToString();
            ekle.SubItems.Add["Adi"].ToString();
            ekle.SubItems.Add["Soyadi"].ToString();
            ekle.SubItems.Add["Telefon"].ToString();
            ekle.SubItems.Add["Mail"].ToString();
            ekle.SubItems.Add["Ehliyet"].ToString();
            ekle.SubItems.Add["kayit"].ToString();

        }
    }

    baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into MusteriEkle (Adi,Soyadı,KullaniciAdi,Mail,Telefon) values ('" + TxtAdi.Text",''" + TxtSoyadi.Text"','" + TxtKullaniciAdi.Text"','" + TxtMail.Text"')", baglanti);
}
}
