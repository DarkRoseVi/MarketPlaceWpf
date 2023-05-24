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
using MarketPlaceWpf.Models;
using MarketPlaceWpf.Pages;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace MarketPlaceWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPAge.xaml
    /// </summary>
    public partial class MainPAge : Window
    {
        public MainPAge()
        {
            InitializeComponent();
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new ProductPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}
