using System.Text.RegularExpressions;
using Flavor.Maui.Converters;
using Flavor.Maui.Masks;

namespace Flavor.Maui.Demo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		// Validation demo: validate email format on blur
		EmailValidation.Validation = text =>
		{
			if (string.IsNullOrEmpty(text)) return null;
			var isValid = Regex.IsMatch(text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
			return isValid ? null : "Invalid email address";
		};

		// Mask demo: phone number formatting
		PhoneMasked.Mask = new PatternMask("(###) ###-####");

		// Value<T> demo: numeric field with converter
		NumericField.Converter = FlavorConverters.Double;
		NumericField.ValueChanged += (s, value) =>
		{
			System.Diagnostics.Debug.WriteLine($"Numeric value: {value} (type: {value?.GetType().Name})");
		};

		// Adornment icon click demo
		SearchField.AdornmentClicked += async (s, e) =>
		{
			var text = SearchField.Text;
			await DisplayAlertAsync("Search", $"Searching for: {text}", "OK");
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
