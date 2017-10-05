using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ClientSSL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khoi tao Client");
            //b1 xac dinh IP Server
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            //b2 tao Socket
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //b3 gui nhan data
            Console.WriteLine("Client gui data");






            //b4 dong client socket
            client.Close();
        }
    }
}
