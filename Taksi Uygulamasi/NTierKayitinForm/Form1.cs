using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierKayit.BLL.Service;

namespace NTierKayitinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        KayitService kayit = new KayitService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Kayıt_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "KayitAd";
            listBox1.DisplayMember = "KayitSoyad";
            listBox1.DisplayMember = "KayitEmail";
            listBox1.DisplayMember = "KayitKullaciAdi";
            listBox1.ValueMember = "KayitTelefon";   
        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DtpKayit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
