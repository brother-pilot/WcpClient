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

namespace WpfWCPClient.Person
{
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        public PersonWindow()
        {
            InitializeComponent();
        }

        private void SearchPersonW(object sender, RoutedEventArgs e)
        {
            SearchPerson sp = new SearchPerson();
            sp.Show();
            sp.Owner = this;

        }

        private void InputPersonW(object sender, RoutedEventArgs e)
        {
            PersonWindow personWindow = new PersonWindow();
            personWindow.Show();
            personWindow.Owner = this;
        }

        private void InputListPersonW(object sender, RoutedEventArgs e)
        {
            ListPersonW listPersonW = new ListPersonW();
            listPersonW.Show();
            listPersonW.Owner = this;
        }
    }
}
