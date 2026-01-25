using CommunityToolkit.Mvvm.ComponentModel;
using EstudoNetMaui.Models;
using System.Collections.ObjectModel;

namespace EstudoNetMaui.ViewModels
{
    public partial class FotoViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Foto> fotos;

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>
            {
                new Foto { Nome = "Foto 1", ImagemUrl = "https://picsum.photos/id/237/200/300" },
                new Foto { Nome = "Foto 2", ImagemUrl = "https://picsum.photos/id/238/200/300" },
                new Foto { Nome = "Foto 3", ImagemUrl = "https://picsum.photos/id/239/200/300" },
                new Foto { Nome = "Foto 4", ImagemUrl = "https://picsum.photos/id/240/200/300" },
                new Foto { Nome = "Foto 5", ImagemUrl = "https://picsum.photos/id/241/200/300" },
                new Foto { Nome = "Foto 6", ImagemUrl = "https://picsum.photos/id/242/200/300" },
                new Foto { Nome = "Foto 7", ImagemUrl = "https://picsum.photos/id/243/200/300" },
                new Foto { Nome = "Foto 8", ImagemUrl = "https://picsum.photos/id/244/200/300" },
                new Foto { Nome = "Foto 9", ImagemUrl = "https://picsum.photos/id/249/200/300" },
                new Foto { Nome = "Foto 10", ImagemUrl = "https://picsum.photos/id/250/200/300" },
                new Foto { Nome = "Foto 11", ImagemUrl = "https://picsum.photos/id/247/200/300" },
                new Foto { Nome = "Foto 12", ImagemUrl = "https://picsum.photos/id/248/200/300" },
                new Foto { Nome = "Foto 13", ImagemUrl = "https://picsum.photos/id/251/200/300" },
                new Foto { Nome = "Foto 14", ImagemUrl = "https://picsum.photos/id/252/200/300" },
                new Foto { Nome = "Foto 15", ImagemUrl = "https://picsum.photos/id/253/200/300" },

            };
        }
    }
}
