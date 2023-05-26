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
    /// Логика взаимодействия для AddChek.xaml
    /// </summary>
    public partial class AddChek : Window
    {
        public Chek contextchek;
        public AddChek(Chek chek)
        {
            InitializeComponent();
            BankCb.ItemsSource = App.db.Bank.ToList();
            contextchek = chek;
            DataContext = contextchek;  

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (contextchek.Id == 0 )
            {
                App.db.Chek.Add(contextchek);
            }
            MessageBox.Show("yes");
            App.db.SaveChanges();   

        
        }
    }
}
