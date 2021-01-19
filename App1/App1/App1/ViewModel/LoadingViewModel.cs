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
        

        public List<Loads> LoadingList { get; set; }


        private List<Loads> GetLoads()
        {
            return new List<Loads>
            {
                new Loads { Title = "FACT", Image = "RobinLogoKenobi.png",
                    Description = "FUNNY" },
                new Loads { Title = "FACT", Image = "KevinLogoGrievous.png",
                    Description = "FUNNY" },
                new Loads { Title = "FACT", Image = "JelmerLogo.png",
                    Description = "FUNNY" },
                new Loads { Title = "FACT", Image = "LukeLogo.png",
                    Description = "FUNNY" },
                new Loads { Title = "FACT", Image = "ErikLogo.png",
                    Description = "FUNNY" }
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
