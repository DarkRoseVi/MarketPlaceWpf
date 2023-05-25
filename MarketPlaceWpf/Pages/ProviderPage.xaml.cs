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
    /// Логика взаимодействия для ProviderPage.xaml
    /// </summary>
    public partial class ProviderPage : Page
    {
        public ProviderPage()
        {
            InitializeComponent();
        
        }

        private void AbbBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddProvider(new Provider()).Show();
            Reshres();
        }

        public void Reshres() 
        {
            ProviderDt.ItemsSource = App.db.Provider.ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Reshres();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var pro = (sender as Button).DataContext as Provider;
            new AddProvider(pro).Show();
            Reshres();

        }

        private void DeletBtn_Click(object sender, RoutedEventArgs e)
        {
            var provider = (sender as Button).DataContext as Provider;
            if (MessageBox.Show("Вы точно хотите удалить эту запись", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
            App.db.Provider.Remove(provider);
            }
            App.db.SaveChanges();
            Reshres();
        }
    }
}
