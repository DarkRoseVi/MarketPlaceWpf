using MarketPlaceWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    /// Логика взаимодействия для TypePage.xaml
    /// </summary>
    public partial class TypePage : Page
    {
       public static TypePage Instance;
        public TypePage()
        {
            InitializeComponent();
            Reshres();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var type = (sender as Button).DataContext as DeliveryType;
            new AddDeliveryPage(new DeliveryType()).Show();
        }

        public  void Reshres() 
        {
            TypeProduct.ItemsSource = App.db.DeliveryType.ToList();
            DeliveryPointDt.ItemsSource = App.db.DeliveryPoint.ToList();
        }
        private void AddPoint_Click(object sender, RoutedEventArgs e)
        {
            Reshres();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var type = (sender as Button).DataContext as DeliveryType;
            new AddDeliveryPage(type).Show();
        }

        private void DeletBtn_Click(object sender, RoutedEventArgs e)
        {
            var em = (sender as Button).DataContext as DeliveryType;
            if (MessageBox.Show("Вы точно хотите удалить эту запись", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                App.db.DeliveryType.Remove(em);
            App.db.SaveChanges();
            Reshres();
        }


      
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Reshres();
        }
    }
}
