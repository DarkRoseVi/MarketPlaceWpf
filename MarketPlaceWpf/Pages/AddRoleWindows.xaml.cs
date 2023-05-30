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
    /// Логика взаимодействия для AddRoleWindows.xaml
    /// </summary>
    public partial class AddRoleWindows : Window
    {
        public Role contextRole; 
        public AddRoleWindows(Role role)
        {
            InitializeComponent();
            contextRole = role;
            DataContext = contextRole;

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTB.Text.Length > 0)
            {
                if (contextRole.Id == 0)
                {
                    App.db.Role.Add(contextRole);

                }
                MessageBox.Show("sead");
                App.db.SaveChanges();
            }
            else MessageBox.Show("Title is null");
            DialogResult = true;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;   
        }
    }
}
