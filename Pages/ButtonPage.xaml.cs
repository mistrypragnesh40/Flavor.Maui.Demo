namespace Flavor.Maui.Demo.Pages;

public partial class ButtonPage : ContentPage
{
    private int _clickCount;

    public ButtonPage()
    {
        InitializeComponent();
    }

    private void OnClickMeClicked(object? sender, EventArgs e)
    {
        _clickCount++;
        ClickCountLabel.Text = $"Click count: {_clickCount}";
    }

    private void OnToggleLoadingClicked(object? sender, EventArgs e)
    {
        LoadingButton.IsLoading = !LoadingButton.IsLoading;
    }

    private async void OnHomeTapped(object? sender, EventArgs e)
        => await Shell.Current.GoToAsync("//Home");
}
