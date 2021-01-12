using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class MainViewModel : BaseViewModel
    { client test = new client();
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }


        public ICommand StartCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));
    
        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "Hagelslag", Image = "Hagelslag.png", 
                    Description = "Zin in een perfect laagje hagelslag over je beschuit? Geen probleem!" },
                new Pick { Title = "Muisjes", Image = "MuisjesB.png", 
                    Description = "Pas op! Misschien rennen ze wel weg!" }
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }


    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}
