using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class LoadingPage : ContentPage
    {
        client test = new client();
        double sensordata = 1.0;
        public LoadingPage()
        {
            InitializeComponent();
            Task.Run(RotateImage);
            MainProgressBar.ProgressTo(sensordata, 9000, Easing.Linear);
        }

        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(360, 10000, Easing.Linear);
            }
        }
        private void disconnect_Clicked(object sender, EventArgs e)
        {
            test.CloseConnection();
        }

    }
}