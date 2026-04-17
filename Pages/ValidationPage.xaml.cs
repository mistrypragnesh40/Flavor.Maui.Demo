using System.Text.RegularExpressions;
using Flavor.Maui.Controls;

namespace Flavor.Maui.Demo.Pages;

public partial class ValidationPage : ContentPage
{
    public ValidationPage()
    {
        InitializeComponent();

        // Email format validation
        EmailField.Validation = text =>
        {
            if (string.IsNullOrEmpty(text)) return null;
            return Regex.IsMatch(text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
                ? null : "Invalid email address";
        };

        // Password strength validation
        PasswordField.Validation = text =>
        {
            if (string.IsNullOrEmpty(text)) return null;
            if (text.Length < 8) return "Password must be at least 8 characters";
            if (!Regex.IsMatch(text, @"[A-Z]")) return "Must contain an uppercase letter";
            if (!Regex.IsMatch(text, @"[0-9]")) return "Must contain a number";
            return null;
        };

        // Confirm password must match
        ConfirmPasswordField.Validation = text =>
        {
            if (string.IsNullOrEmpty(text)) return null;
            return text == PasswordField.Text ? null : "Passwords do not match";
        };

        // Username length validation (validates on change)
        UsernameField.Validation = text =>
        {
            if (string.IsNullOrEmpty(text)) return null;
            if (text.Length < 3) return "Username must be at least 3 characters";
            if (!Regex.IsMatch(text, @"^[a-zA-Z0-9_]+$")) return "Only letters, numbers, and underscores";
            return null;
        };

        // Website URL validation (debounced)
        WebsiteField.Validation = text =>
        {
            if (string.IsNullOrEmpty(text)) return null;
            return Uri.TryCreate(text, UriKind.Absolute, out _)
                ? null : "Enter a valid URL (https://...)";
        };
    }

    private async void OnSubmitClicked(object? sender, EventArgs e)
    {
        // Manually trigger validation on all fields
        var fields = new FlavorTextField[]
        {
            NameField, EmailField, PhoneField,
            PasswordField, ConfirmPasswordField,
            ZipField, UsernameField, WebsiteField
        };

        bool allValid = true;
        foreach (var field in fields)
        {
            // Trigger blur validation for each field
            field.OnValidateOnBlur();
            if (field.HasError)
                allValid = false;
        }

        ResultLabel.IsVisible = true;
        if (allValid)
        {
            ResultLabel.TextColor = Color.FromArgb("#4CAF50");
            ResultLabel.Text = "Form submitted successfully!";
            await DisplayAlertAsync("Success", "All fields are valid. Form submitted!", "OK");
        }
        else
        {
            ResultLabel.TextColor = Color.FromArgb("#F44336");
            ResultLabel.Text = "Please fix the errors above.";
        }
    }
}
