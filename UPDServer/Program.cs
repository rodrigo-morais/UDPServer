using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UPDServer
{
    class Program
    {
        private static UdpClient server;

        static void Main(string[] args)
        {
            server = new UdpClient(9999);
            Console.WriteLine("Server connection");

            Console.Write(">> ");

            while (true)
            {
                receive();
            }
        }

        private static void receive()
        {
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 9999);
            byte[] data = new byte[1024];
            data = server.Receive(ref sender);
            String info = Encoding.ASCII.GetString(data, 0, data.Length);
            Console.WriteLine(info);
            Console.Write(">> ");
        }
    }
}
