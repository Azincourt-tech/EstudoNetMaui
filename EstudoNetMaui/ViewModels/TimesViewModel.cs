using CommunityToolkit.Mvvm.ComponentModel;
using EstudoNetMaui.Models;

namespace EstudoNetMaui.ViewModels
{
    public partial class TimesViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Time> times;

        public TimesViewModel()
        {
            Times = new List<Time>()
            {
               new Time{ Nome = "Real Madrid",Escudo="real.png" },
               new Time{ Nome = "Manchester City",Escudo="man_city.png" },
               new Time{ Nome = "Milan",Escudo="milan.png" },
               new Time{ Nome = "Napoli",Escudo="napoli.png" },
               new Time{ Nome = "Chelsea",Escudo="chelsea.png" },
               new Time{ Nome = "Bayer",Escudo="bayern.png" },
               new Time{ Nome = "Benfica",Escudo="benfica.png" },
               new Time{ Nome = "PSG",Escudo="psg.png" },
               new Time{ Nome = "Barcelona",Escudo="barca.png" },
            };
        }
    }
}
