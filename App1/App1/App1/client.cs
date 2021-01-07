using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace App1
{
    class client
    {
        public static Socket sender;
        public static IPAddress ipAddress = IPAddress.Parse("192.168.178.47");
        public static EndPoint remoteEP;
        public static byte[] bytes = new byte[1024];

        public void OpenConnection()
        {
            try
            {
                remoteEP = new IPEndPoint(ipAddress, 80);
                sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(remoteEP);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CloseConnection()
        {
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

        public void Send(string message)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(message);
                sender.Send(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public string Receive()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Send("Hallo");
            int bytesRec = sender.Receive(bytes);
            return Encoding.ASCII.GetString(bytes, 0, bytesRec);
        }
    }
}
