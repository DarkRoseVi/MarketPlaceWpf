using MarketPlaceWpf.Models;
using MarketPlaceWpf.Models.Partial;
using System;
using System.Collections.Concurrent;
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
    /// Логика взаимодействия для ClientHomePage.xaml
    /// </summary>
    public partial class ClientHomePage : Page
    {
        public byte[] image;
        public Useer contextuser;


        public ClientHomePage()
        {

            InitializeComponent();
            contextuser = HelpClass.AutoUset;
            //image = user.Photo;
            // var dsd = App.db.Useer.Where(x=>x.Id == user.Id).FirstOrDefault();
           // OrderLw.ItemsSource = App.db.ProductOrder.Where(x => x.StatysOrderId == 1).Select(x => x.Order).Where(s => s.UserId == contextuser.Id).ToList();
            OrderLw.ItemsSource = App.db.Order.Where(s => s.UserId == contextuser.Id).SelectMany(x => x.ProductOrder).Where(s=>s.StatysOrderId == 1).ToList();

            //    ImageHome.Source = image ;
            DataContext = contextuser;
            Refresh();
          
        }
        public void Refresh() 
        {
            contextuser = HelpClass.AutoUset;
            ChekLw.ItemsSource = App.db.Chek.Where(x => x.UserId == contextuser.Id).ToList();

        }

        private void EditInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            new EditInfoProvPage(contextuser).ShowDialog();
            Refresh();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddChek(new Chek()).ShowDialog();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var ch = (sender as Button).DataContext as Chek;
            new AddChek(ch).ShowDialog();   
        }

        private void InfoOrrderBtn_Click(object sender, RoutedEventArgs e)
        {
            var prod = (sender as Button).DataContext as ProductOrder;
            new InfoOrderHomePage(prod).ShowDialog();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
