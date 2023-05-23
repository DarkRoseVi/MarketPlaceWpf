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
using MarketPlaceWpf.Pages;
using System.Windows.Shapes;
using System.Net;

namespace MarketPlaceWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AutoPage());
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
             string login = LoginTb.Text.Trim();    
              string password = PasswordTb.Password.Trim();   
             //string password2 = Password2Tb.Password.Trim();   


        }

        private void VidBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowPasswordCharsCheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
                Password2TB.Visibility = Visibility.Visible;
                Password2Pb.Visibility = Visibility.Collapsed;

                Password2TB.Text = new NetworkCredential(string.Empty, Password2Pb.SecurePassword).Password;
                Password2TB.Focus();
    
            
  
        }

        private void ShowPasswordCharsCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
         

            Password2Pb.Visibility = Visibility.Visible;
            Password2TB.Visibility = Visibility.Collapsed;

            Password2TB.Text ="";
            Password2TB.Focus();
          
          
        }

        private void Vid_Click(object sender, RoutedEventArgs e)
        {
            ShowPasswordCharsCheckBox.IsChecked = true;
        }
    }
}
