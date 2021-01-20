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
                new Pick { Title = "Hagelslag", Image = "Hagelslag.png", Description = procent() }
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
