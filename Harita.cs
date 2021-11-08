using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Timers;


namespace KargoSistemi
{
    public partial class Harita : Form
    {
        
        private List<PointLatLng> _points;
        public double lat2;
        public double longt2;
        private const MouseButtons right = MouseButtons.Right;

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        public Harita()
        {
            InitializeComponent();

            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBiQPHuBBaKnF2RkwF8pQmsAELJqHqkWQ0";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl2.CacheLocation = @"cache";
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "";
            build.Database = "kargodagitim";
            baglanti = new MySqlConnection(build.ToString());

            _points = new List<PointLatLng>();

            Baslangic_Ekle(40.7628844960185, 29.9351155757904);
            Listele_Goster();

            

            Rota_Ciz();

            
            
        }

       

        public void Harita_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBiQPHuBBaKnF2RkwF8pQmsAELJqHqkWQ0";

            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "";
            build.Database = "kargodagitim";
            baglanti = new MySqlConnection(build.ToString());

            
        }

        public void gMapControl2_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyAhalvVJySJWShss1nAa1Y56qb8ba1kGm8";
            Listele_Goster();
            
        }

        public void Listele_Goster()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from teslimatadres where teslimatDurumu= 'Teslim edilmedi'");
            komut.Connection = baglanti;
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                double lat3 = (double)read["latitude"];
                double longt3 = (double)read["longitude"];
                Nokta_Ekle(lat3, longt3);
                
            }
            baglanti.Close();
            
        }

        public void Nokta_Ekle(double lat3, double longt3)
        {
            gMapControl2.DragButton = right;
            gMapControl2.MapProvider = GMapProviders.GoogleMap;
            double lat1 = 40.7750;
            double longt1 = 29.9480;
            gMapControl2.Position = new PointLatLng(lat1, longt1);
            gMapControl2.MinZoom = 5;
            gMapControl2.MaxZoom = 100;
            gMapControl2.Zoom = 10;

            PointLatLng point = new PointLatLng(lat3, longt3);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);
            gMapControl2.Overlays.Add(markers);
            

        }

        public void Baslangic_Ekle(double lat3, double longt3)
        {
            gMapControl2.DragButton = right;
            gMapControl2.MapProvider = GMapProviders.GoogleMap;
            double lat1 = 40.7750;
            double longt1 = 29.9480;
            gMapControl2.Position = new PointLatLng(lat1,longt1);
            gMapControl2.MinZoom = 5;
            gMapControl2.MaxZoom = 100;
            gMapControl2.Zoom = 10;

            PointLatLng point = new PointLatLng(lat3, longt3);
            Bitmap bmpMarker = (Bitmap)Image.FromFile("C:/Users/Gökçe Yılmaz/source/repos/KargoSistemi/KargoSistemi/Resources/baslangic.png");
            GMapMarker marker = new GMarkerGoogle(point, bmpMarker);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);
            gMapControl2.Overlays.Add(markers);

        }

        public void Rota_Ciz()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from teslimatadres where teslimatDurumu= 'Teslim edilmedi'");
            komut.Connection = baglanti;
            MySqlDataReader read = komut.ExecuteReader();
            
            while (read.Read())
            {
                double lat3 = (double)read["latitude"];
                double longt3 = (double)read["longitude"];
                Nokta_Ekle(lat3, longt3);
                _points.Add(new PointLatLng(lat3, longt3));
                
                
            }
            baglanti.Close();

            PointLatLng ilk = new PointLatLng(40.7628844960185, 29.9351155757904);
            double kisamesafe=10000000;
            double uzunmesafe = 0;
            int kisa = 96;
            int uzun = 85;
            
            
                for (int i = 0; i < _points.Count; i++)
                {

                    PointLatLng son = new PointLatLng(_points[i].Lat, _points[i].Lng);
                    MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(ilk, son, false, false, 15);
                    GMapRoute r = new GMapRoute(route.Points, "My route");
                    GMapOverlay routesOverlay = new GMapOverlay("routes");
                    routesOverlay.Routes.Add(r);

                    r.Stroke.Width = 5;
                    r.Stroke.Color = Color.Red;


                    double mesafe = route.Distance;

                    Console.WriteLine("MESAFEE:" + mesafe);
                    if (mesafe < kisamesafe)
                    {
                        kisamesafe = mesafe;
                        kisa = i;
                    }
                    if (mesafe > uzunmesafe)
                    {
                        uzunmesafe = mesafe;
                        uzun = i;
                    }
                }
                Console.WriteLine("Kısa Mesafe:" + kisamesafe);
                Console.WriteLine("En kısa yer:" + kisa);
                Console.WriteLine("Uzun Mesafe:" + uzunmesafe);
                Console.WriteLine("En uzak yer:" + uzun);

                PointLatLng son1 = new PointLatLng(_points[kisa].Lat, _points[kisa].Lng);
                MapRoute route1 = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(ilk, son1, false, false, 15);
                GMapRoute r1 = new GMapRoute(route1.Points, "My route");
                GMapOverlay routesOverlay1 = new GMapOverlay("routes");
                routesOverlay1.Routes.Add(r1);

                r1.Stroke.Width = 5;
                r1.Stroke.Color = Color.Red;
                gMapControl2.Overlays.Add(routesOverlay1);

                
                _points.RemoveAt(kisa);

            
            

        }

    




    }
}
