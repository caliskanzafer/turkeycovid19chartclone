using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Timers;

namespace Server
{
    public partial class Server : Form
    {
        int toplam_test_sayisi = 0;
        int toplam_vaka_sayisi = 0;
        int toplam_vefat_sayisi = 0;
        int toplam_y_b_sayisi = 0;
        int toplam_entube_sayisi = 0;
        int toplam_iyilesen_sayisi = 0;

        public static readonly object _lock = new object();
        public static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();
        TcpListener ServerSocket;
        int count = 0;
        ClientUyelik clientUye;
        YeniObserver observer;
        string yazi;
        Thread t;
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public Server()
        {
            InitializeComponent();
            ServerSocket = new TcpListener(IPAddress.Any, 1234);
            ServerSocket.Start();

            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            myTimer.Interval = 1000;
            myTimer.Start();

        }

        public void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {

            while (true)
            {
                TcpClient client = ServerSocket.AcceptTcpClient();
                list_clients.Add(count++, client);
                Console.WriteLine("Client ile Bağlantı Kuruldu");
            }
        }
        public void observerNesnesi(object a)
        {
            clientUye = new ClientUyelik();
            observer = new YeniObserver(clientUye);
            clientUye.setVeriler(yazi);
            clientUye.changeStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam_test_sayisi += Convert.ToInt32(gunluk_test_veri.Text);
            toplam_vaka_sayisi += Convert.ToInt32(gunluk_vaka_veri.Text);
            toplam_vefat_sayisi += Convert.ToInt32(olu_sayisi_veri.Text);
            toplam_y_b_sayisi += Convert.ToInt32(y_b_hasta_sayisi_veri.Text);
            toplam_entube_sayisi += Convert.ToInt32(entube_hasta_sayisi_veri.Text);
            toplam_iyilesen_sayisi += Convert.ToInt32(iyilesen_hasta_sayisi_veri.Text);

            yazi = tarih_veri.Text + ";" + gunluk_test_veri.Text + ";" + gunluk_vaka_veri.Text + ";" + y_b_hasta_sayisi_veri.Text + ";" + entube_hasta_sayisi_veri.Text + ";" +
                olu_sayisi_veri.Text + ";" + iyilesen_hasta_sayisi_veri.Text + ";" + toplam_test_sayisi + ";" + toplam_vaka_sayisi + ";" + toplam_vefat_sayisi + ";" + toplam_y_b_sayisi + ";" + toplam_entube_sayisi + ";" + toplam_iyilesen_sayisi; ;
            t = new Thread(observerNesnesi);
            t.Start(0);
            using (StreamWriter w = File.AppendText(desktopPath + "\\veriler.txt"))
            {
                w.WriteLine(yazi + " | ");
                w.Flush();
                w.Close();
            }

        }
    }
}
