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
    /// Логика взаимодействия для TypeProductPage.xaml
    /// </summary>
    public partial class TypeProductPage : Page
    {
        public TypeProductPage()
        {
            InitializeComponent();
        }

        private void DeletBtn_Click(object sender, RoutedEventArgs e)
        {
            var type = (sender as Button).DataContext as TypeProduct;
            if (MessageBox.Show("Вы точно хотите удалить эту запись", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                App.db.TypeProduct.Remove(type);
            }
            App.db.SaveChanges();
            Reshres();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var type = (sender as Button).DataContext as TypeProduct;
            new AddTypeProduct(type).Show();
            Reshres();

        }

        private void AbbBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddTypeProduct(new TypeProduct()).Show();
            Reshres();
        }

        public void Reshres()
        {
            TypeProdDt.ItemsSource = App.db.TypeProduct.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Reshres();
        }
    }
}
