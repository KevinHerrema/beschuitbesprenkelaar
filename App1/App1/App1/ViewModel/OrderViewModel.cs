using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }

        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "Hagelslag", Image = "Hagelslag.png", Description = "Zin in chocola, maar wil je toch niet teveel? Laat de machine een perfect laagje hagelslag over je beschuit strooien!" },
                new Pick { Title = "Muisjes", Image = "MuisjesB.png", Description = "Muisjes zijn een voortreffelijke keuze voor op je beschuitje, daarnaast een echte klassieker!" },
                new Pick { Title = "Vlokken", Image = "MuisjesB.png", Description = "Vlokken" },
                new Pick { Title = "Witte Vlokken", Image = "MuisjesB.png", Description = "Vlokken maar dan wit" }
            };
        }
    }
}
