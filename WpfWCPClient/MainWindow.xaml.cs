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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WcfClient;
using WpfWCPClient.Person;

namespace WpfWCPClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //TO DO выделить отдельный класс для запуска сервисов и wpf
        public MainWindow()
        {
            InitializeComponent();
            Transfer.InitializeConnection();
        }

        private void PersonOpenWindow(object sender, RoutedEventArgs e)
        {
            PersonWindow personWindow = new PersonWindow();
            personWindow.Show();
            personWindow.Owner = this;

        }

        private void CompanyOpenWindow(object sender, RoutedEventArgs e)
        {
            CompanyWindow companyWindow = new CompanyWindow();
            companyWindow.Show();
            companyWindow.Owner = this; 
        }
    }
}
