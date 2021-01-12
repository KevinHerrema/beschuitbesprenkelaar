using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace App1
{
    class client
    {   public Socket sock;
        IPAddress serverAddr = IPAddress.Parse("192.168.1.36");
        public IPEndPoint endPoint;
        string lampstatus = "off";

     

        
        public void OpenConnection()
        {
            endPoint = new IPEndPoint(serverAddr, 11000);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sock.Connect(endPoint);

           

            
        }

        public void beslagkeuze()
        {
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

        public string CloseConnection(string ontvangen)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress serverAddr = IPAddress.Parse("192.168.1.36");

            IPEndPoint endPoint = new IPEndPoint(serverAddr, 11000);

            byte[] recieve_buffer = new byte[1024];
            string text = "sen";
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.SendTo(send_buffer, endPoint);


            int bytesync = sock.Receive(recieve_buffer);

            return ontvangen = Encoding.ASCII.GetString(recieve_buffer, 0, bytesync);
            
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
