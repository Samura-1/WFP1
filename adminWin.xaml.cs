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
    /// Логика взаимодействия для adminWin.xaml
    /// </summary>
    public partial class adminWin : Window
    {
        public static ModelBd.Model1 conect = new ModelBd.Model1();
        public adminWin()
        {
            InitializeComponent();
            conect.Client.Load();
            clientsLB.ItemsSource = conect.Client.Local;
        }


        public static ModelBd.Client selectClient = new ModelBd.Client();

        private void SelectedClient()
        {
            selectClient = (ModelBd.Client)clientsLB.SelectedItem;
        }
    }
    
}
