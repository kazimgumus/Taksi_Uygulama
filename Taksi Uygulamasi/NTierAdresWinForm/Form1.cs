using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierAdres.BLL.Service;
namespace NTierAdresWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AdresService adresService = new AdresService();

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Adres";
            listBox1.ValueMember = "AdresID";
            listBox1.DisplayMember = "KayitliAdres";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
