using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Client1;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client2
{
    public partial class Client2 : Form
    {
        Singleton singleton = Singleton.socket();
        Series series;
        Series series2;
        ChartArea cArea;
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public Client2()
        {

            InitializeComponent();
        }

        private void Client2_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            singleton.connectionOn();

            chartLoading();
        }

        private void chartLoading()
        {
            series = chart1.Series[0];
            series2 = chart1.Series[1];
            cArea = chart1.ChartAreas[0];

        }

        private void Client2_FormClosing(object sender, FormClosingEventArgs e)
        {
            singleton.connectionOff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            singleton.veriYaz(ReceiveData);
        }

        public void ReceiveData(TcpClient client)
        {
            int gun = 1;
            int tarihGun;
            int vakaSayisi;
            int vefatSayisi;

            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length);

            string yazi = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);
            string[] metin = yazi.Split(';');
            String[] tarih = metin[0].Split(' ');
            label12.Text = metin[7];
            label13.Text = metin[8];
            label14.Text = metin[9];
            label15.Text = metin[10];
            label16.Text = metin[11];
            label17.Text = metin[12];

            StreamReader sr = new StreamReader(desktopPath + "\\veriler.txt");
            string satir = "";
            while (true)
            {
                satir = sr.ReadLine();
                if (satir == null)
                {
                    sr.Close();
                    break;
                }

                string[] grafikVeriDizi = satir.Split(';');
                String[] tarihBilgi = grafikVeriDizi[0].Split(' ');
                tarihGun = Convert.ToInt32(tarihBilgi[0]);
                vakaSayisi = Convert.ToInt32(grafikVeriDizi[8]);
                vefatSayisi = Convert.ToInt32(grafikVeriDizi[9]);

                cArea.AxisY.Interval += vakaSayisi;
                series.Points.AddXY(tarihGun, vakaSayisi);
                series2.Points.AddXY(tarihGun, vefatSayisi);

                gun++;
            }


        }
    }
}
