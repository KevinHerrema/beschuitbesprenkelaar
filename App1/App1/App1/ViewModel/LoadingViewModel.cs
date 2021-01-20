using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class LoadingViewModel : BaseViewModel
    {
        public LoadingViewModel()
        {
            LoadingList = GetLoads();
        }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        public List<Loads> LoadingList { get; set; }


        private List<Loads> GetLoads()
        {
            return new List<Loads>
            {
                new Loads { Title = "Wist je dat?", Image = "ScientistColor.png",
                    Description = "Hagelslag die minder dan 32 procent cacao bevat, mag geen chocoladehagelslag genoemd worden." },
                new Loads { Title = "Wist je dat?", Image = "ScientistColor.png",
                    Description = "In fruithagel en anijshagel zit nauwelijks fruit of anijs. Het is vooral suiker wat erin zit." },
                new Loads { Title = "Wist je dat?", Image = "ScientistColor.png",
                    Description = "Aanvankelijk waren de muisjes roze bij de komst van een meisje en wit bij een jongen. De blauwe muisjes werden pas in 1994 geïntroduceerd." },
                new Loads { Title = "Wist je dat?", Image = "ScientistColor.png",
                    Description = "In Belgie noemen ze hagelslag muizenstrontjes." },
                new Loads { Title = "Wist je dat?", Image = "ScientistColor.png",
                    Description = "de Ruijter werd in 1985 als Koninklijk werd benoemd." }
            };
        }
    }

    public class Loads
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }

}
