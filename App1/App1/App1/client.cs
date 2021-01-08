using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace App1
{
    class client
    {

        public string lampstatus = "off";
        public void OpenConnection()
        {
            if (lampstatus == "off")
            {
                lampstatus = "on";
            }
            else
            {
                lampstatus = "off";
            }
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress serverAddr = IPAddress.Parse("192.168.1.36");

            IPEndPoint endPoint = new IPEndPoint(serverAddr, 11000);

            string text = lampstatus;
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.SendTo(send_buffer, endPoint);
        }

        public string CloseConnection(string ontvangen)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress serverAddr = IPAddress.Parse("192.168.1.36");

            IPEndPoint endPoint = new IPEndPoint(serverAddr, 11000);

            byte[] recieve_buffer = new byte[1024];
            string text = "sens";
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.SendTo(send_buffer, endPoint);


            int bytesync = sock.Receive(recieve_buffer);

            return ontvangen = Encoding.ASCII.GetString(recieve_buffer, 0, bytesync);
        }

        
    }
}
