using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace ServerSocket._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            socket.Bind(ep);

            socket.Listen(10);//한번에 10개의 소켓 받을수있음

            Socket clientSocket = socket.Accept();
            if (clientSocket.Connected)
            {
                Console.WriteLine("클라이언트가 서버에 접속하였습니다.");
            }

            while (!Console.KeyAvailable)//콘솔에 키가 눌리면 종료
            {
                byte[] buff = new byte[2048];
                int n = clientSocket.Receive(buff);
                string result = Encoding.UTF8.GetString(buff, 0, n);
                if(result == "Ping")
                {
                    result = "Pong";
                }
                Console.WriteLine(result);
            }
        }
    }
}
