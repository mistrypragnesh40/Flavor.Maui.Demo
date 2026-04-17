namespace Flavor.Maui.Demo.Pages;

public partial class FabPage : ContentPage
{
    private int _clickCount;

    public FabPage()
    {
        InitializeComponent();
    }

    private void OnFabClicked(object? sender, EventArgs e)
    {
        _clickCount++;
        FabClickLabel.Text = $"FAB clicked {_clickCount} time(s)";
    }
}
