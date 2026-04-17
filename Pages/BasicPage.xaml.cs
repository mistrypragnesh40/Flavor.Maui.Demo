namespace Flavor.Maui.Demo.Pages;

public partial class BasicPage : ContentPage
{
    public BasicPage()
    {
        InitializeComponent();
    }

    private async void OnHomeTapped(object? sender, EventArgs e)
        => await Shell.Current.GoToAsync("//Home");
}
