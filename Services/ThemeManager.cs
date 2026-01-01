using System;
using System.Linq;
using System.Windows;

namespace WpfThemeSample.Services
{
    public static class ThemeManager
    {
        private const string ThemeUriFormat = "Themes/{0}.xaml";

        public static void ApplyTheme(string themeName)
        {
            if (Application.Current == null)
                throw new InvalidOperationException("Application is not initialized");

            var themeUri = new Uri(string.Format(ThemeUriFormat, themeName), UriKind.Relative);
            var newTheme = new ResourceDictionary { Source = themeUri };

            // Remove existing theme dictionaries (all Theme*.xaml resources)
            var themeDictionaries = Application.Current.Resources.MergedDictionaries
                .Where(d => d.Source != null && d.Source.OriginalString.StartsWith("Themes/Theme"))
                .ToList();

            foreach (var dict in themeDictionaries)
            {
                Application.Current.Resources.MergedDictionaries.Remove(dict);
            }

            // Add the new theme
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }

        public static void ApplyThemeA() => ApplyTheme("ThemeA");
        public static void ApplyThemeB() => ApplyTheme("ThemeB");
        public static void ApplyThemeC() => ApplyTheme("ThemeC");
        public static void ApplyThemeD() => ApplyTheme("ThemeD");
    }
}
