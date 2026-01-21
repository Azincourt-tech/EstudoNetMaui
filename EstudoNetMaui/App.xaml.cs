using EstudoNetMaui.Controls.Command;
using EstudoNetMaui.Controls.Presentation;

namespace EstudoNetMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new MauiCommandControls()));
        }
    }
}