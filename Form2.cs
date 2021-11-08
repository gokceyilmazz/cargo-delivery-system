using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeslimatAdres frm4 = new TeslimatAdres();
            this.Close();
            frm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeslimatDurum frm3 = new TeslimatDurum();
            this.Close();
            frm3.Show();
        }
    }
}
