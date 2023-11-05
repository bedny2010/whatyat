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

namespace Ivanov_Autoservice_first
{
    /// <summary>
    /// Логика взаимодействия для Service_Page.xaml
    /// </summary>
    public partial class Service_Page : Page
    {
        public Service_Page()
        {
            InitializeComponent();
            var currentServices = Ivanov_avtoserviceEntities3.GetContext().Service.ToList();
            ServiceListView.ItemsSource = currentServices;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.Main_Frame.Navigate(new Add_Edit_Page());
        }

        private void ServiceListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
