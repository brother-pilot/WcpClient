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
using WcfClient;
using WcfContract;

namespace WpfWCPClient.Person
{
    /// <summary>
    /// Interaction logic for SearchPerson.xaml
    /// </summary>
    public partial class SearchPerson : Window
    {
        public PersonDTO Person { get; private set; }

        public SearchPerson()
        {
            InitializeComponent();
            Person = new PersonDTO(); ;
            DataContext = Person;
            //Person = new PersonDTO { Name = "sds", Surname = "pusto" };
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            var t=Transfer.Service.TestGetSum(4, 5);
            DataContext = new PersonDTO {Name=t.ToString(),Surname="pusto" };
        }
    }
}
