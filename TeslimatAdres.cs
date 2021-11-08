using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using System.Threading;

namespace KargoSistemi
{
    public partial class TeslimatAdres : Form
    {
        private const MouseButtons right = MouseButtons.Right;
        Harita hrt = new Harita();
        

        public TeslimatAdres()
        {
            InitializeComponent();
            hrt.Show();
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBiQPHuBBaKnF2RkwF8pQmsAELJqHqkWQ0";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.CacheLocation = @"cache";
            gMapControl1.DragButton = right;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            double lat1 = 40.7750;
            double longt1 = 29.9480;
            gMapControl1.Position = new PointLatLng(lat1, longt1);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 10;

           
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void Map_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "";
            build.Database = "kargodagitim";
            baglanti = new MySqlConnection(build.ToString());
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBiQPHuBBaKnF2RkwF8pQmsAELJqHqkWQ0";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.CacheLocation = @"cache";
            gMapControl1.DragButton = right;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtEnlem.Text.Replace(".",","));
            double longt = Convert.ToDouble(txtBoylam.Text.Replace(".", ","));
            gMapControl1.Position = new PointLatLng(lat,longt);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 10;

            PointLatLng point = new PointLatLng(lat,longt);
            GMapMarker marker = new GMarkerGoogle(point,GMarkerGoogleType.blue_dot);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
            

            EkleSilGuncelle("insert into teslimatadres (yerAdi,latitude,longitude,teslimatDurumu) values('" + yer.Text + "','" + txtEnlem.Text.Replace(",", ".") + "','" + txtBoylam.Text.Replace(",", ".") + "','Teslim edilmedi')");
            Harita hrt = new Harita();

            hrt.Listele_Goster();
            hrt.Rota_Ciz();
            //MessageBox.Show("Kargo adresi eklendi");
            

            Console.WriteLine(double.Parse(txtEnlem.Text));

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Close();
            frm2.Show();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

      


        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double longt = point.Lng;
                txtEnlem.Text = lat+"";
                txtBoylam.Text = longt+"";


            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            hrt.Listele_Goster();
            hrt.Rota_Ciz();
        }
    }
}
