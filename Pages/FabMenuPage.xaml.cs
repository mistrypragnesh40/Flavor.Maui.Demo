namespace Flavor.Maui.Demo.Pages;

public partial class FabMenuPage : ContentPage
{
    public FabMenuPage()
    {
        InitializeComponent();
    }

    private void OnSendClicked(object? sender, EventArgs e)
    {
        StatusLabel.Text = "Send tapped!";
    }

    private void OnContactClicked(object? sender, EventArgs e)
    {
        StatusLabel.Text = "Contact tapped!";
    }

    private void OnEmailClicked(object? sender, EventArgs e)
    {
        StatusLabel.Text = "Email tapped!";
    }
}
