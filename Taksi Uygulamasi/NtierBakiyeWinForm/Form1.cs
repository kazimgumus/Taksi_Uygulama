using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NtierBakiye.BLL.Service;
using NTierBakiye.BLL.Service;

namespace NtierBakiyeWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BakiyeService bakiyeService = new BakiyeService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = bakiyeService.GetNTierBakiyes();
            listBox1.ValueMember = "Bakiye";
            listBox1.ValueMember = "KartNo";
            listBox1.ValueMember = "CVV";
            listBox1.ValueMember = "Skt";
        }
    }
}
