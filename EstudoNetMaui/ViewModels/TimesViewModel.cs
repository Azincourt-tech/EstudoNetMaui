using EstudoNetMaui.Models;

namespace EstudoNetMaui.ViewModels
{
    public class TimesViewModel
    {
        public List<Time> Times { get; set; } = new List<Time>();

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
