using Flavor.Maui.Converters;
using Flavor.Maui.Masks;

namespace Flavor.Maui.Demo.Pages;

public partial class MasksPage : ContentPage
{
    public MasksPage()
    {
        InitializeComponent();

        // Masks
        PhoneField.Mask = new PatternMask("(###) ###-####");
        CreditCardField.Mask = new PatternMask("####-####-####-####");
        DateField.Mask = new PatternMask("##/##/####");
        TimeField.Mask = new PatternMask("##:##");
        ZipField.Mask = new PatternMask("#####-####");

        // Converters
        IntField.Converter = FlavorConverters.Int;
        DoubleField.Converter = FlavorConverters.Double;
        DecimalField.Converter = FlavorConverters.Decimal;

        // Live value tracking
        PhoneField.TextChanged += (s, e) =>
        {
            var raw = PhoneField.Mask?.GetUnmaskedValue(PhoneField.Text) ?? PhoneField.Text;
            PhoneValueLabel.Text = $"Phone raw: {raw}";
        };

        IntField.ValueChanged += (s, value) =>
        {
            IntValueLabel.Text = $"Int value: {value} (type: {value?.GetType().Name ?? "null"})";
        };

        DoubleField.ValueChanged += (s, value) =>
        {
            DoubleValueLabel.Text = $"Double value: {value} (type: {value?.GetType().Name ?? "null"})";
        };

        DecimalField.ValueChanged += (s, value) =>
        {
            DecimalValueLabel.Text = $"Decimal value: {value} (type: {value?.GetType().Name ?? "null"})";
        };
    }
}
