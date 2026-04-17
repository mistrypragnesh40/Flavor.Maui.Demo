namespace Flavor.Maui.Demo.Pages;

public partial class IconButtonPage : ContentPage
{
    private int _clickCount;

    public IconButtonPage()
    {
        InitializeComponent();
    }

    private void OnIconButtonClicked(object? sender, EventArgs e)
    {
        _clickCount++;
        IconClickLabel.Text = $"Clicked {_clickCount} time(s)";
    }
}
