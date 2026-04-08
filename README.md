# Flavor.Maui Demo

A sample .NET MAUI app showcasing [Flavor.Maui](https://www.nuget.org/packages/Flavor.Maui) — Material Design UI controls with native rendering.

## Getting Started

1. Clone this repo
2. Open in Visual Studio or run from CLI:

```bash
# iOS
dotnet build -f net10.0-ios -t:Run

# Android
dotnet build -f net10.0-android -t:Run

# macOS
dotnet build -f net10.0-maccatalyst -t:Run
```

## What's Inside

| Tab | Features |
|-----|----------|
| **Basic** | Outlined, Filled, Standard variants, read-only, disabled, multi-line, helper text |
| **Validation** | Required fields, regex patterns, custom validators, debounced validation |
| **Icons** | Start/end adornment icons, text adornments, clearable fields |
| **Masks** | Phone, credit card, date, time, zip code masks + value converters |
| **Styling** | Dense mode, accent colors, icon sizes, underline toggle, layout options |

## How to Use Flavor.Maui in Your App

### 1. Install the NuGet package

```bash
dotnet add package Flavor.Maui
```

### 2. Register in MauiProgram.cs

```csharp
using Flavor.Maui.Extensions;

builder
    .UseMauiApp<App>()
    .UseFlavor();
```

### 3. Add XAML namespace and use controls

```xml
xmlns:flavor="clr-namespace:Flavor.Maui.Controls;assembly=Flavor.Maui"

<flavor:FlavorTextField Label="Email"
                    InputType="Email"
                    Variant="Outlined"
                    IsRequired="True" />
```

## Links

- [Flavor.Maui on NuGet](https://www.nuget.org/packages/Flavor.Maui)
- [Flavor.Maui Source Code](https://github.com/mistrypragnesh40/Flavor.Maui)
- [Full Documentation](https://github.com/mistrypragnesh40/Flavor.Maui#readme)

## License

MIT
