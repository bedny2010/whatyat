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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main_Frame.Navigate(new Service_Page());
            Manager.Main_Frame=Main_Frame;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.Main_Frame.GoBack();
        }

        private void Main_Frame_ContentRendered(object sender, EventArgs e)
        {
            if (Main_Frame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;

            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}
