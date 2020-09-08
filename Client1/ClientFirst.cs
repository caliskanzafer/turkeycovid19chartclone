using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Client1
{
    public partial class client_form : Form
    {
        Singleton socket = Singleton.socket();
        public client_form()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            socket.connectionOn();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            socket.veriYaz(ReceiveData);
        }

        private void client_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.connectionOff();
        }

        public void ReceiveData(TcpClient client)//Mesaj geri geliyor
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length);

            string yazi = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);
            string[] metin = yazi.Split(';');
            String[] tarih = metin[0].Split(' ');
            tarih1.Text = tarih[0];
            tarih2.Text = tarih[1];
            tarih3.Text = tarih[2];
            gunluk_test_sonuc.Text = metin[1];
            gunluk_vaka_sonuc.Text = metin[2];
            olu_sayisi_sonuc.Text = metin[5];
            iyilesen_hasta_sayisi_sonuc.Text = metin[6];
            label12.Text = metin[7];
            label13.Text = metin[8];
            label14.Text = metin[9];
            label15.Text = metin[10];
            label16.Text = metin[11];
            label17.Text = metin[12];
        }
    }
}
