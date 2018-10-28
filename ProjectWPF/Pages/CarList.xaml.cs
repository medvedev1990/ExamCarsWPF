using CarDB.DAL.Models;
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

namespace ProjectWPF.Pages
{
    /// <summary>
    /// Interaction logic for CarList.xaml
    /// </summary>
    public partial class CarList : Page
    {
        ModelEntity db = new ModelEntity();
        public CarList()
        {
            InitializeComponent();
            CarsList.ItemsSource = db.newEquipment.ToList();
        }


        private void LookInfo_Click(object sender, RoutedEventArgs e)
        {
            newEquipment equipment = (newEquipment)CarsList.SelectedItem;
            LookInfo page = new LookInfo(equipment);
            MainWindow.cframe.NavigationService.Navigate(page);
        }
    }
}
