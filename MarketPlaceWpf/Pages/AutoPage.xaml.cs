﻿using System;
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
using MarketPlaceWpf.Pages;
using MarketPlaceWpf.Models;

using System.Windows.Shapes;
using System.Net;

namespace MarketPlaceWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void EntranceBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string password = Password2Pb.Password.Trim();  
            string password2 = Password2TB.Text.Trim();
            var user = App.db.Useer.Where(x=> (x.Login == login && x.Password == password) ||(x.Login == login &&  x.Password == password2)).FirstOrDefault();
            if (user != null)
            {
                //MessageBox.Show("Welcome " + HelpClass.AutoUset.Name);
                NavigationService.Navigate(new MainPAge());

            }
            else 
            {

                MessageBox.Show("such user already exists ");
                if (MessageBox.Show("you want to register", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    HelpClass.AutoUset = user;
                    NavigationService.Navigate(new RegPage());
                }

               
            }
        }

        private void ShowPasswordCharsCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

            Password2Pb.Visibility = Visibility.Visible;
            Password2TB.Visibility = Visibility.Collapsed;

            Password2TB.Text = "";
            Password2TB.Focus();

        }

        private void ShowPasswordCharsCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            Password2TB.Visibility = Visibility.Visible;
            Password2Pb.Visibility = Visibility.Collapsed;

            Password2TB.Text = new NetworkCredential(string.Empty, Password2Pb.SecurePassword).Password;
            Password2TB.Focus();
        }

        private void Vid_Click(object sender, RoutedEventArgs e)
        {
            ShowPasswordCharsCheckBox.IsChecked = true;
        }

        private void Sce_Click(object sender, RoutedEventArgs e)
        {
            ShowPasswordCharsCheckBox.IsChecked = false;
        }
    }
}
