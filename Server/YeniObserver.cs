using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class YeniObserver : IObserver
    {
        public static String test;

        public YeniObserver(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Update(string veri)
        {
                    byte[] buffer = Encoding.ASCII.GetBytes(veri + Environment.NewLine);
                    foreach (TcpClient c in Server.list_clients.Values)
                    {
                        NetworkStream stream = c.GetStream();

                        stream.Write(buffer, 0, buffer.Length);
                    }
            
        }
    }
}
