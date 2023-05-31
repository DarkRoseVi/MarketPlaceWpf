﻿using MarketPlaceWpf.Models;
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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            var user = HelpClass.AutoUset.Id;
   var contextorders = App.db.Order.Where(x => x.UserId == user);
            OrderLw.ItemsSource = contextorders.ToList();
       //     var con = App.db.ProductOrder.Where(x => x.Order == contextorders).Select(z => z.Order).ToList();
           

        }

        private void EditStatusBtn_Click(object sender, RoutedEventArgs e)
        {
            var ord = (sender as Button).DataContext as Order;
            NavigationService.Navigate(new EditOrderPage(ord));
        }
    }
}