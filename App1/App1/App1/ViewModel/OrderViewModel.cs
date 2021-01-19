using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {
        client test = new client();
        public OrderViewModel()
        {
            MenuList = GetMenu();

        }
        public string procent()
        {
            double sensordata = Convert.ToInt32(test.recievesens());
            string procent = Convert.ToString(sensordata) + "% vol";
            return (procent);
        }


        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "Hagelslag", Image = "Hagelslag.png", Description = procent() },
                new Pick { Title = "Muisjes", Image = "MuisjesGroter.png", Description = "Muisjes zijn een voortreffelijke keuze voor op je beschuitje, daarnaast een echte klassieker!" },
                new Pick { Title = "Vlokken", Image = "MuisjesGroter.png", Description = "Vlokken" },
                new Pick { Title = "Witte Vlokken", Image = "MuisjesGroter.png", Description = "Vlokken maar dan wit" }
            };
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
}
