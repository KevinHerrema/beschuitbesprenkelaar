using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        string lampstatus= "off";
        client test = new client();
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void connect_Clicked(object sender, EventArgs e)
        {
            if(lampstatus == "off")
            {
                lampstatus = "on";
            }
            else
            {
                lampstatus = "off";
            }
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,ProtocolType.Udp);

            IPAddress serverAddr = IPAddress.Parse("192.168.1.36");

            IPEndPoint endPoint = new IPEndPoint(serverAddr, 11000);

            string text = lampstatus;
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.SendTo(send_buffer, endPoint);
        }
        private void disconnect_Clicked(object sender, EventArgs e)
        {
            test.CloseConnection();
        }

       

    }
}
