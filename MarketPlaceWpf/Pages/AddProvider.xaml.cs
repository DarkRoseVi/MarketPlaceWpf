using MarketPlaceWpf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
    /// Логика взаимодействия для AddProvider.xaml
    /// </summary>
    public partial class AddProvider : Window
    {
        public Provider contextProvider;
        DbPropertyValues values;
        public AddProvider(Provider provider)
        {
            InitializeComponent();
            contextProvider = provider;
            DataContext = contextProvider;
            if (contextProvider.Id != 0)
            {
                values = App.db.Entry(contextProvider).CurrentValues.Clone();
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (contextProvider.Id == 0)
            {
                App.db.Provider.Add(contextProvider);
            }
            MessageBox.Show("yes");
            App.db.SaveChanges();
            Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {

            if (values != null)
            {
                App.db.Entry(contextProvider).CurrentValues.SetValues(values);
            }
         
            Close();  
        }

     
    }
}
