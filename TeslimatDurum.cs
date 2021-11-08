using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KargoSistemi
{
    public partial class TeslimatDurum : Form
    {
        public TeslimatDurum()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void AdresEkrani_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "";
            build.Database = "kargodagitim";
            baglanti = new MySqlConnection(build.ToString());
            Listele_Ara("SELECT * FROM teslimatadres");
        }

        public DataTable Listele_Ara(string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
            return tbl;

        }

        public void EkleSilGuncelle(string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            EkleSilGuncelle("update teslimatadres set teslimatDurumu= 'Teslim edildi' where yerId= '" + dataGridView1.CurrentRow.Cells["yerId"].Value.ToString() + "'");
            Listele_Ara("select * from teslimatadres");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkleSilGuncelle("delete from teslimatadres where yerId= '"+dataGridView1.CurrentRow.Cells["yerId"].Value.ToString() +"'");
            Listele_Ara("select * from teslimatadres");
            MessageBox.Show("Kargo başarıyla silindi");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Close();
            frm2.Show();
        }
    }
}
