using System.Collections.ObjectModel;
using System.Windows;
using WpfThemeSample.Services;

namespace WpfThemeSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeSampleData();
        }

        private void InitializeSampleData()
        {
            var sampleData = new ObservableCollection<SampleItem>
            {
                new SampleItem { Id = 1, Name = "Component A", Status = "Active", Value = "100" },
                new SampleItem { Id = 2, Name = "Component B", Status = "Idle", Value = "250" },
                new SampleItem { Id = 3, Name = "Component C", Status = "Active", Value = "175" },
                new SampleItem { Id = 4, Name = "Component D", Status = "Error", Value = "0" },
                new SampleItem { Id = 5, Name = "Component E", Status = "Active", Value = "320" }
            };

            SampleListView.ItemsSource = sampleData;

            // Populate ComboBox
            var comboBoxItems = new ObservableCollection<string>
            {
                "Option 1 - Standard",
                "Option 2 - Advanced",
                "Option 3 - Professional",
                "Option 4 - Enterprise",
                "Option 5 - Custom"
            };

            SampleComboBox.ItemsSource = comboBoxItems;
        }

        private void ThemeA_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplyThemeA();
        }

        private void ThemeB_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplyThemeB();
        }

        private void ThemeC_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplyThemeC();
        }

        private void ThemeD_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplyThemeD();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "WPF Theme Sample - Industrial Touch UI\n\n" +
                "This sample demonstrates runtime theme switching with four different themes:\n" +
                "- Theme A: Light Panel\n" +
                "- Theme B: Dark Steel\n" +
                "- Theme C: Blue Accent\n" +
                "- Theme D: High Contrast\n\n" +
                "Compatible with .NET Framework 4.8+ and .NET 6+",
                "About",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }

    public class SampleItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
