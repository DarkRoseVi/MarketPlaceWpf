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
    /// Логика взаимодействия для AdDelivetyPointPage.xaml
    /// </summary>
    /// 
    public partial class AdDelivetyPointPage : Window
    {
        public DeliveryPoint contextDeliveryPoint;
        public AdDelivetyPointPage(DeliveryPoint deliveryPoint)
        {
            InitializeComponent();
            contextDeliveryPoint = deliveryPoint;
            DataContext = contextDeliveryPoint;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AdressTb.Text.Length>0)
            {

            if (contextDeliveryPoint.Id == 0 )
            {
                App.db.DeliveryPoint.Add(contextDeliveryPoint);
            }
            MessageBox.Show("Saved");
            App.db.SaveChanges();  
             
          
            }
            else MessageBox.Show("Fill in the field");
            DialogResult = true;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
