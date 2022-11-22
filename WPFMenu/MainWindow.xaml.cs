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
        }

        private void OnRed(object sender, RoutedEventArgs e)
        {
            BackPanel.Background = Brushes.Red;
        }

        private void OnGreen(object sender, RoutedEventArgs e)
        {
            BackPanel.Background = Brushes.Green;
        }

        private void OnBlue(object sender, RoutedEventArgs e)
        {
            BackPanel.Background = Brushes.Blue;
        }

        private void OnWhite(object sender, RoutedEventArgs e)
        {
            BackPanel.Background = Brushes.White;
        }
    }
}
