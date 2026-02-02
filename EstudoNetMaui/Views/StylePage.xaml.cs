namespace EstudoNetMaui.Views;

public partial class StylePage : ContentPage
{
    public StylePage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Resources["dynamicStyle"] = Resources["cyanStyle"];

        Application.Current.Resources.TryGetValue("dangerButton", out var style);
        Resources["dynamicStyle"] = style;
    }
}