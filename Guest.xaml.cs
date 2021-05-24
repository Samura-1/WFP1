using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Guest.xaml
    /// </summary>
    public partial class Guest : Window
    {
        ModelBd.Model1 con = new ModelBd.Model1();
        public Guest()
        {
            InitializeComponent();
            con.Client.Load();
            list1box.ItemsSource = con.Client.Local;
        }
    }
}
