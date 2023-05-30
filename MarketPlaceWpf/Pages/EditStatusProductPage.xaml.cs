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
    /// Логика взаимодействия для EditStatusProductPage.xaml
    /// </summary>
    public partial class EditStatusProductPage : Window
    {
        public ProductOrder contextProductOrder;
        public EditStatusProductPage(ProductOrder productorders)
        {
            InitializeComponent();
            StatusCb.ItemsSource = App.db.StatysOrder.ToList();        
            contextProductOrder = productorders;
            DataContext = contextProductOrder;

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("saved");
            App.db.SaveChanges();
            Close();    
           
        }
    }
}
