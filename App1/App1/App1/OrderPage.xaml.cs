using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        client test = new client();
        public OrderPage()
        {
            InitializeComponent();
        }

        private void CarouselPositionChanged(object sender, PositionChangedEventArgs e)
        {
            var carousel = sender as CarouselView;
            var views = carousel.VisibleViews;

            if (views.Count > 0)
            {
                foreach (var view in views)
                {
                    var img = view.FindByName<Image>("MenuImg");
                    ViewExtensions.CancelAnimations(img);

                    Task.Run(async () => await img.RelRotateTo(360, 5000, Easing.BounceOut));
                }
            }
        }
        private void disconnect_Clicked(object sender, EventArgs e)
        {            
           test.CloseConnection();            
        }
        private async void send_Clicked(object sender, EventArgs e)
        {            
           test.beslagkeuze();
           await Navigation.PushAsync(new LoadingPage());
        }
    }
}