using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding bind = new CommandBinding(ApplicationCommands.Open);
            bind.Executed += OpenDoucument;
            CommandBindings.Add(bind);
        }
        private void OpenDoucument(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            //dialog.FileName = "사진"; // Default file name
            dialog.DefaultExt = ".jpg"; // Default file extension
            dialog.Filter = "Images (.jpg)|*.jpg"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result != true)
                return;

            // Open document
            string filename = dialog.FileName;

            MessageBox.Show(filename);
        }
        private void OnRed(object sender, RoutedEventArgs e)
        {
            BackPanel.Background = Brushes.Red;
            ItemRed.IsChecked = true;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = true;
        }

        private void OnGreen(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush
                //= new SolidColorBrush(Colors.Green);
                = new SolidColorBrush(Color.FromRgb(128, 255, 128));
            BackPanel.Background = brush;
            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = true;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = true;
        }

        private void OnBlue(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush
                //= new SolidColorBrush(Colors.Green);
                = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
            BackPanel.Background = brush;
            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = true;

            ItemWhite.IsEnabled = true;
        }

        private void OnWhite(object sender, RoutedEventArgs e)
        {
            BackPanel.Background = Brushes.White;
            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = false;
        }
    }
}
