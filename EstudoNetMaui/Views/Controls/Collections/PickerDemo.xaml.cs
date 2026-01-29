namespace EstudoNetMaui.Views.Controls.Collections;

public partial class PickerDemo : ContentPage
{
	public PickerDemo()
	{
		InitializeComponent();
	}

    private void pickerOptions_SelectedIndexChanged(object sender, EventArgs e)
    {
		var picker = (Picker)sender;
		var selectedItem = picker.SelectedItem;
        lblPickerResult.Text = $"Selected Item: {selectedItem}";
    }
}
