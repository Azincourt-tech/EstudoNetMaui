namespace EstudoNetMaui.Views.Controls.Edit;

public partial class MauiEditControls : ContentPage
{
	public MauiEditControls()
	{
		InitializeComponent();
	}

    private void entryName_TextChanged(object sender, TextChangedEventArgs e)
    {
        lblNameResult.Text = e.NewTextValue;
    }

    private void entryName_Completed(object sender, EventArgs e)
    {
        lblNameResult.Text = "You finished typing!";
    }

    private void editorMessage_TextChanged(object sender, TextChangedEventArgs e)
    {
        lblMessageResult.Text = e.NewTextValue;
    }

    private void editorMessage_Completed(object sender, EventArgs e)
    {
        lblMessageResult.Text = "You finished typing!";
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await progressBarDemo.ProgressTo(1, 5000, Easing.Linear);
    }

    private void Button_Reset_Clicked(object sender, EventArgs e)
    {
        progressBarDemo.ProgressTo(0.1, 5000, Easing.Linear);
    }
}
