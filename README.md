# Flavor.Maui Demo

A sample .NET MAUI app showcasing [Flavor.Maui](https://www.nuget.org/packages/Flavor.Maui) — Material Design UI controls with native rendering on Android, iOS, macOS Catalyst, and Windows.

> Uses **Flavor.Maui v0.2.0**.

## Getting Started

```bash
git clone https://github.com/mistrypragnesh40/Flavor.Maui.Demo.git
cd Flavor.Maui.Demo

# iOS
dotnet build -f net10.0-ios -t:Run

# Android
dotnet build -f net10.0-android -t:Run

# macOS
dotnet build -f net10.0-maccatalyst -t:Run

# Windows
dotnet build -f net10.0-windows10.0.19041.0 -t:Run
```

## What's Inside

The demo is organized into two tab bars — one for input controls and one for button controls.

### Input controls

| Tab | Features |
|-----|----------|
| **TextField** | Outlined, Filled, Standard variants, read-only, disabled, multi-line, helper text |
| **Validation** | Required fields, regex patterns, custom validators, debounced validation |
| **Icons** | Start/end adornment icons, text adornments, clearable fields |
| **Masks** | Phone, credit card, date, time, zip code masks + value converters |
| **Styling** | Dense mode, accent colors, icon sizes, underline toggle, layout options |

### Button controls

| Tab | Features |
|-----|----------|
| **Button** | `Text` / `Filled` / `Outlined` variants, sizes, preset colors, start/end icons, loading state, full-width, dense mode |
| **Icon Button** | Circular icon-only button — variants, sizes, colors, ripple, elevation |
| **FAB** | Floating Action Button — circular and extended (icon + label), sizes, custom colors, positioning via `FlavorFabAnchor` |
| **FAB Menu** | Speed-dial with staggered expand animation, action labels, direction (Top/Bottom/Left/Right), dim backdrop |

## How to Use Flavor.Maui in Your App

### 1. Install the NuGet package

```bash
dotnet add package Flavor.Maui --version 0.2.0
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
```

```xml
<!-- Text field -->
<flavor:FlavorTextField Label="Email"
                        InputType="Email"
                        Variant="Outlined"
                        IsRequired="True" />

<!-- Button -->
<flavor:FlavorButton Text="Save"
                     Variant="Filled"
                     Color="Primary"
                     StartIcon="icon_check" />

<!-- Icon button -->
<flavor:FlavorIconButton Icon="icon_edit"
                         Variant="Outlined"
                         Color="Secondary" />

<!-- Floating Action Button over page content -->
<flavor:FlavorFabAnchor Position="BottomEnd">
    <flavor:FlavorFabAnchor.Fab>
        <flavor:FlavorFab Icon="icon_add" Color="Primary" />
    </flavor:FlavorFabAnchor.Fab>

    <ScrollView>
        <!-- page content -->
    </ScrollView>
</flavor:FlavorFabAnchor>

<!-- FAB speed-dial menu -->
<flavor:FlavorFabAnchor Position="BottomEnd">
    <flavor:FlavorFabAnchor.Fab>
        <flavor:FlavorFabMenu Icon="icon_add" CloseIcon="icon_close" Direction="Top">
            <flavor:FlavorFabAction Icon="icon_edit"   Label="Edit"   Color="Secondary" />
            <flavor:FlavorFabAction Icon="icon_send"   Label="Send"   Color="Success"   />
            <flavor:FlavorFabAction Icon="icon_delete" Label="Delete" Color="Error"     />
        </flavor:FlavorFabMenu>
    </flavor:FlavorFabAnchor.Fab>
</flavor:FlavorFabAnchor>
```

## Supported Platforms

| Platform | Status |
|----------|--------|
| Android (API 21+) | Full support |
| iOS (15+) | Full support |
| macOS Catalyst (15+) | Full support |
| Windows (10.0.19041+) | Partial — FAB works, Button/IconButton/TextField are stubs |

## Links

- [Flavor.Maui on NuGet](https://www.nuget.org/packages/Flavor.Maui)
- [Full documentation on NuGet](https://www.nuget.org/packages/Flavor.Maui#readme-body-tab)

## License

MIT
