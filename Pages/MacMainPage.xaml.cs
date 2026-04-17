namespace Flavor.Maui.Demo.Pages;

public partial class MacMainPage : ContentPage
{
    private readonly View[] _pages;
    private int _selected = -1;

    public MacMainPage()
    {
        InitializeComponent();

        _pages = new View[]
        {
            new BasicPage().Content,
            new ValidationPage().Content,
            new IconsPage().Content,
            new MasksPage().Content,
            new StylingPage().Content,
        };

        SelectTab(0);
    }

    private void OnTabClicked(object? sender, EventArgs e)
    {
        if (sender is Button btn && int.TryParse(btn.ClassId, out var index))
            SelectTab(index);
    }

    private void SelectTab(int index)
    {
        if (index == _selected) return;
        _selected = index;
        PageHost.Content = _pages[index];

        var buttons = new[] { BtnBasic, BtnValidation, BtnIcons, BtnMasks, BtnStyling };
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].Opacity = i == index ? 1.0 : 0.5;
        }
    }
}
