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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
            Dostup1();
        }
        string dostup;
        private void Dostup1()
        {
            if (MainWindow.dostup == "Guest")
            {
                admin.Visibility = Visibility.Hidden;
                user.Visibility = Visibility.Hidden;
            }
            else
                if (MainWindow.dostup == "User")
            {
                admin.Visibility = Visibility.Hidden;
                return;
            }
            else
                if (MainWindow.dostup == "Admin")

            {
            }
        }
        private void all_Click(object sender, RoutedEventArgs e)
        {
            Guest guest = new Guest();
            guest.Show();
            this.Close();
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            adminWin admin = new adminWin();
            admin.Show();
            this.Close();
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }
    }
}
