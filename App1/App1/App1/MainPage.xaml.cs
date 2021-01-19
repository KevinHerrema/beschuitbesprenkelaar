using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        client test = new client();
       
        public MainPage()
        {
            InitializeComponent();
            Task.Run(RotateImage);
        }

        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(360, 10000, Easing.Linear);
            }
        }
        private void connect_Clicked(object sender, EventArgs e)
        {
           
            
                test.OpenConnection();


        }

    }
}


