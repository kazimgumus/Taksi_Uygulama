using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierSoforinForm.BLL.Service;

namespace NTierSoforinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly SoforService soforService = new SoforService();
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Ad";
            listBox1.DisplayMember = "Soyad";
            listBox1.DisplayMember = "Email";
            listBox1.DisplayMember = "Plaka";
            listBox1.ValueMember = "Puan";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
