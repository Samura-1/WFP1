using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.Entity;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModelBd.Model1 connectBd = new ModelBd.Model1();
        public MainWindow()
        {
            InitializeComponent();
            connectBd.users.Load();
        }

        static public string dostup;

        public bool aut()
        {
            if ((bool)ChecGues.IsChecked == true)
            {
                dostup = "Guest";
                menu win = new menu();
                this.Close();
                win.Show();
                return true;
            }
            else
            if (connectBd.users.Local.
                Where(datauser => datauser.login == login.Text & datauser.password == password.Text).FirstOrDefault() != null)
            {
                dostup = connectBd.users.Local.
                Where(datauser => datauser.login == login.Text & datauser.password == password.Text).FirstOrDefault().login;
                menu win = new menu();
                this.Close();
                win.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Неправильные данные для входа");
                return false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aut();
        }
    }

}