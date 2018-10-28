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
using CarDB.DAL;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame cframe;
        public MainWindow()
        {
            InitializeComponent();
            cframe = CentralFrame;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bbn_AddCar(object sender, RoutedEventArgs e)
        {
            UserControl1 user = new UserControl1();
            CentralFrame.Source = new Uri("Pages/AddCar.xaml", UriKind.RelativeOrAbsolute);
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            CentralFrame.Source = new Uri("Pages/CarList.xaml", UriKind.RelativeOrAbsolute);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CentralFrame.Source = new Uri("Pages/MainPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
