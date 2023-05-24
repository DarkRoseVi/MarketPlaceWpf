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
    /// Логика взаимодействия для InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public Product contextproduct;

        public InfoPage(Product product)
        {
            InitializeComponent();
            TypeCb.ItemsSource = App.db.TypeProduct.ToList();  
            contextproduct = product;
            DataContext = contextproduct;
            ImageLW.ItemsSource = contextproduct.ProductPhoto.ToList();

            int id = Convert.ToInt32(contextproduct.Id);
            ProviderTb.ItemsSource = contextproduct.ProviderProduct.Where(x => x.Product.Id == id ).Select(z =>z.Provider).ToList();
            ProviderTb.DisplayMemberPath = "Title";

 
        }
    }
}
