namespace Flavor.Maui.Demo.Pages;

public partial class IconsPage : ContentPage
{
    public IconsPage()
    {
        InitializeComponent();

        // Search icon click
        SearchField.AdornmentClicked += async (s, e) =>
        {
            await DisplayAlertAsync("Search", $"Searching for: {SearchField.Text}", "OK");
        };

        // Password visibility toggle
        bool passwordVisible = false;
        PasswordField.AdornmentClicked += (s, e) =>
        {
            passwordVisible = !passwordVisible;
            PasswordField.InputType = passwordVisible
                ? Flavor.Maui.Enums.FlavorInputType.Text
                : Flavor.Maui.Enums.FlavorInputType.Password;
            PasswordField.AdornmentIcon = passwordVisible
                ? "icon_eye"
                : "icon_eye_off";
        };
    }
}
