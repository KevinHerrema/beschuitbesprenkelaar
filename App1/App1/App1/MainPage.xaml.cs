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
        string sensordata;
        client test = new client();
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void connect_Clicked(object sender, EventArgs e)
        {
            test.OpenConnection();
        }
        private void disconnect_Clicked(object sender, EventArgs e)
        {          
            test.CloseConnection(sensordata);
            Label1.Text = sensordata;
        }


       

    }
}
