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
using WcfContract;

namespace WpfWCPClient.Person
{
    /// <summary>
    /// Interaction logic for ListPersonW.xaml
    /// </summary>
    public partial class ListPersonW : Window
    {
        public PersonDTO Person { get; private set; }

        public ListPersonW()
        {
            InitializeComponent();
            Person = new PersonDTO { Name = "ttt", Surname = "yyy" };
            DataContext = Person;
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
