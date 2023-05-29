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
    /// Логика взаимодействия для AddTypeProduct.xaml
    /// </summary>
    public partial class AddTypeProduct : Window
    {
        public TypeProduct contextTypeProduct;
        public AddTypeProduct(TypeProduct typeproduct)
        {
            InitializeComponent();
            contextTypeProduct = typeproduct;
            DataContext = contextTypeProduct;

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTb.Text.Trim().Length > 0 )
            {

                if (contextTypeProduct.Id == 0)
                {
                    App.db.TypeProduct.Add(contextTypeProduct);
                }
                MessageBox.Show("Type product saved");
                App.db.SaveChanges();
                Close();
            }
            else MessageBox.Show("Fill in the title");
        }
    }
}
