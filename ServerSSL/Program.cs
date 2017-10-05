using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerSSL
{
    class Program
    {
        static void Main(string[] args)
        {
            //b1 tao socket udp
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 12345);
            //b2 ket noi Socket voi card mang
            server.Bind(ip);
            //b3 gui nhan data
            //Server phai nhan data truoc
            byte[] rec = new byte[25];
            EndPoint client = (EndPoint)ip;
            server.ReceiveFrom(rec, ref client);






            //b4 dong server
            server.Close();
        }
    }
}
