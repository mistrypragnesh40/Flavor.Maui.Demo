namespace Flavor.Maui.Demo.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnInputTapped(object? sender, TappedEventArgs e)
        => await Shell.Current.GoToAsync("//InputSection/TextField");

    private async void OnButtonsTapped(object? sender, TappedEventArgs e)
        => await Shell.Current.GoToAsync("//ButtonSection/Button");
}
