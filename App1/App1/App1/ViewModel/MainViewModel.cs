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
                new Pick { Title = "Robin", Image = "RobinLogoKenobi.png",
                    Description = "Hello there" },
                new Pick { Title = "Kevin", Image = "KevinLogoGrievous.png", 
                    Description = "General Kenobi" },
                new Pick { Title = "Jelmer", Image = "JelmerLogo.png",
                    Description = "Me good in code, no ervaring needed!" },
                new Pick { Title = "Luke", Image = "LukeLogo.png",
                    Description = "Ik ben niet een land. Ik ben de zee. -Willem Alexander" },
                new Pick { Title = "Erik", Image = "ErikLogo.png",
                    Description = "Erik houdt wel eens van een beschuitje hagelslag op zijn tijd." }
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
