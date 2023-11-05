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

namespace Glazki_IvanovO_O
{
    /// <summary>
    /// Логика взаимодействия для Glazki_Page.xaml
    /// </summary>
    public partial class Glazki_Page : Page
    {
        public Glazki_Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManagerClass.MainFrame.Navigate(new AddEditPage());
        }
    }
}
