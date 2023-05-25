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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarketPlaceWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public BasketPage()
        {
            InitializeComponent();
            TypedeliveryCb.ItemsSource = App.db.DeliveryType.ToList();
            DeliveryPointCb.ItemsSource = App.db.DeliveryPoint.ToList();
            
            CheckCb.ItemsSource = App.db.Check.ToList();

            ProductLw.ItemsSource = HelpClass.prod;
            var us = HelpClass.AutoUset.Name;
            UserTb.Text = Convert.ToString(us );
        }

        private void Typedelivery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int v = (TypedeliveryCb.SelectedItem as DeliveryType).Id;
            if (v == 1)
            {
                AdressSt.Visibility = Visibility.Collapsed;
                DeliveryPointSt.Visibility = Visibility.Visible;
            }
            else if (v == 2 ) 
            {
                AdressSt.Visibility = Visibility.Visible;
                DeliveryPointSt.Visibility = Visibility.Collapsed;
            }
        }
    }
}
