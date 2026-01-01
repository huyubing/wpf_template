# WPF Theme Sample - Industrial Touch UI

A WPF (Windows Presentation Foundation) sample application demonstrating runtime theme switching with four different color themes optimized for industrial touch interfaces.

## Features

- **Four Switchable Themes:**
  - **Theme A (Light Panel)**: Clean light palette suitable for bright environments
  - **Theme B (Dark Steel)**: Dark theme inspired by Visual Studio dark mode
  - **Theme C (Blue Accent)**: Light theme with blue accent colors
  - **Theme D (High Contrast)**: High-contrast black/yellow theme for accessibility

- **Runtime Theme Switching**: Change themes dynamically without restarting the application
- **Industrial Touch UI**: Optimized control sizes and spacing for touch interfaces
- **Comprehensive Control Styles**: Includes styles for Menu, Button, CheckBox, RadioButton, ListBox, TabControl, and ListView
- **DynamicResource Bindings**: All color references use DynamicResource for seamless theme switching

## Project Structure

```
WpfThemeSample/
├── App.xaml                    # Application resources with default theme
├── App.xaml.cs                 # Application code-behind
├── MainWindow.xaml             # Demo UI with all controls
├── MainWindow.xaml.cs          # Window code-behind with sample data
├── Services/
│   └── ThemeManager.cs         # Theme switching service
├── Styles/
│   └── Controls.xaml           # Base control styles and shared resources
└── Themes/
    ├── ThemeA.xaml             # Light Panel palette
    ├── ThemeB.xaml             # Dark Steel palette
    ├── ThemeC.xaml             # Blue Accent palette
    └── ThemeD.xaml             # High Contrast palette
```

## Building the Project

### Requirements
- Visual Studio 2022 or later
- .NET 8.0 SDK or .NET Framework 4.8+

### Build Instructions

```bash
# Using .NET CLI
dotnet build WpfThemeSample.csproj

# Using Visual Studio
# Open WpfThemeSample.csproj and build from the IDE
```

## Usage

1. Run the application
2. Use the **Theme** menu to switch between themes:
   - Theme A (Light Panel)
   - Theme B (Dark Steel)
   - Theme C (Blue Accent)
   - Theme D (High Contrast)

The theme will change immediately across all controls and UI elements.

## Theme Customization

### Adding a New Theme

1. Create a new ResourceDictionary file in the `Themes/` folder (e.g., `ThemeE.xaml`)
2. Define all required color palette keys:
   - `Bg0`, `Bg1` - Background colors
   - `Border0` - Border color
   - `Hover` - Hover state color
   - `Accent`, `AccentHi` - Accent colors
   - `Text0`, `TextSub` - Text colors
   - `TextOnAccent` - Text color on accent backgrounds
   - `MenuBg` - Menu background color

3. Add control templates for Button, CheckBox, and RadioButton
4. Update `ThemeManager.cs` to include the new theme
5. Add a menu item in `MainWindow.xaml` for the new theme

### Customizing Dimensions

Edit `Styles/Controls.xaml` to modify:
- `CornerRadius` - Border corner radius
- `StandardPadding` - Control padding
- `StandardBorderThickness` - Border thickness
- `StandardFontSize`, `HeaderFontSize` - Font sizes

## Architecture

### Theme Management

The `ThemeManager` service manages theme switching by:
1. Removing the current theme ResourceDictionary from merged dictionaries
2. Adding the new theme ResourceDictionary

All controls use `DynamicResource` bindings to palette keys, allowing instant visual updates when themes change.

### Control Styling

- **Base Styles**: Defined in `Styles/Controls.xaml` with shared layout and behavior
- **Theme-Specific Styles**: Each theme provides color-specific implementations
- **DynamicResource Usage**: Color properties use `{DynamicResource}` markup
- **StaticResource Usage**: Dimensions use `{StaticResource}` for performance

## Compatibility

- **.NET 8.0-windows**: Recommended for new projects
- **.NET Framework 4.8**: For compatibility with legacy systems
- **Cross-platform Build Support**: Includes `EnableWindowsTargeting` for CI/CD on non-Windows platforms

## License

This sample is provided as-is for educational and demonstration purposes.
