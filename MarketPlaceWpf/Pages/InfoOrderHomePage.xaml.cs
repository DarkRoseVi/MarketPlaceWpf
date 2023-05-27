using MarketPlaceWpf.Models;
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
using System.Windows.Shapes;

namespace MarketPlaceWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для InfoOrderHomePage.xaml
    /// </summary>
    public partial class InfoOrderHomePage : Window
    {
        public ProductOrder contextProductOrder;
        public InfoOrderHomePage(ProductOrder productOrder)
        {
            InitializeComponent();
            contextProductOrder = productOrder;
            DataContext = productOrder;
       

        }

        private void GivBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}
