using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class client
    {
        public Socket sock;
        IPAddress serverAddr = IPAddress.Parse("192.168.178.11");
        public IPEndPoint endPoint;
        public string lampstatus = "off";




        public void OpenConnection()
        {

            endPoint = new IPEndPoint(serverAddr, 11000);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sock.Connect(endPoint);

        }

        public void beslagkeuze()
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            endPoint = new IPEndPoint(serverAddr, 11000);
            if (lampstatus == "off")
            {
                lampstatus = "on";
            }
            else
            {
                lampstatus = "off";
            }
            string text = lampstatus;
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.SendTo(send_buffer, endPoint);
        }

        public void CloseConnection()
        {
            try
            {
                sock.Shutdown(SocketShutdown.Both);
            }
            finally
            {
                sock.Close();
            }
        }


    }
}
