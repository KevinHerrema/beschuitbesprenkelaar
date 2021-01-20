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
        IPAddress serverAddr = IPAddress.Parse("192.168.178.36");
        public IPEndPoint endPoint;
        public string lampstatus = "off";




        //client page
        string ontvangen;
        public double recievesens()
        {

            endPoint = new IPEndPoint(serverAddr, 11000);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sock.Connect(endPoint);
            string text = "sens";
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);
            sock.SendTo(send_buffer, endPoint);
            byte[] recieve_buffer = new byte[1024];
            int bytesync = sock.Receive(recieve_buffer);

            ontvangen = Encoding.ASCII.GetString(recieve_buffer, 0, bytesync);
            double sensordata = Convert.ToInt32(ontvangen);
            sensordata = sensordata / 22 * 100;
            sensordata = 100 - sensordata;
            return sensordata;
        }

        public void beslagkeuze()
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            endPoint = new IPEndPoint(serverAddr, 11000);

            string text = "hagel";
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.SendTo(send_buffer, endPoint);
            byte[] recieve_buffer = new byte[1024];
            int bytesync = sock.Receive(recieve_buffer);

            string ontvangen2 = Encoding.ASCII.GetString(recieve_buffer, 0, bytesync);
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
