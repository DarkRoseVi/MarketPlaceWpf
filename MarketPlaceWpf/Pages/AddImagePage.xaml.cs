using MarketPlaceWpf.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddImagePage.xaml
    /// </summary>
    public partial class AddImagePage : Window
    {
        public Useer contextuser;
        public byte[] image;    
        public AddImagePage(Useer user)
        {
            InitializeComponent();
            contextuser = user;
            DataContext = user;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openfil = new OpenFileDialog();
      
            if (openfil.ShowDialog().GetValueOrDefault())
            {
                image = File.ReadAllBytes(openfil.FileName);    
                ImageProf.Source = new BitmapImage(new Uri(openfil.FileName));  
            }
            contextuser.Photo = image;
            MessageBox.Show("image saved");
            App.db.SaveChanges();   
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}
