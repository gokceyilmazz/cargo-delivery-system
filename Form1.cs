using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KargoSistemi
{
    
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        String ad = "";
        String sifre = "";

        public Form1()
        {
            InitializeComponent();
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "";
            build.Database = "kargodagitim";
            baglanti = new MySqlConnection(build.ToString());

            
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from kullanicigiris");
            komut.Connection = baglanti;
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ad = (string)read["kullaniciAdi"];
                sifre = (string)read["sifre"];
                

            }
            baglanti.Close();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== ad && textBox2.Text == sifre)
            {
                Form1 frm1 = new Form1();
                Form2 frm2 = new Form2();
                
                

                frm2.Show();
                
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!!!!");
            }

        }
    }
}
