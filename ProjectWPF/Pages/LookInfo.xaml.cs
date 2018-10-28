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
    /// Логика взаимодействия для LookInfo.xaml
    /// </summary>
    public partial class LookInfo : Page
    {
        ModelEntity db = new ModelEntity();
        public LookInfo(newEquipment equipment)
        {
            InitializeComponent();
            string model = db.TablesModel.ToList().Find(x => x.intModelID == equipment.intModelID).strName;
            tbxHeader.Text = equipment.intGarageRoom + "/" + model;
            tbxUnHeader.Text = equipment.CreateDate.ToString();


            tbxManuf.Text = db.TablesManufacturer.ToList().Find(x => x.intManufacturerID == equipment.intManufacturerID).strName;
            tbxModel.Text = db.TablesModel.ToList().Find(x => x.intModelID == equipment.intModelID).strName;
            tbxYear.Text = equipment.strManufYear;
            tbxNumber.Text = equipment.strSerialNo;
            tbxGroup.Text = equipment.intServiceLife.ToString();
            tbxModif.Text = db.TablesEquipmentType.ToList().Find(x => x.intEquipmentTypeId == equipment.intEquipmentTypeID).strUnits;
            tbxSMSC.Text = db.TablesSMCSFamily.ToList().Find(x => x.intSMCSFamilyID == equipment.intSMCSFamilyID).strName;
            tbxSize.Text = db.TablesSize.ToList().Find(x => x.intSizeID == equipment.intSizeID).strSize;
            tbxDay.Text = equipment.intlimitDay.ToString();
            tbxWeek.Text = equipment.intlimitWeek.ToString();

            if (equipment.bitActive == true)
            {
                tbxStatus.Text = "Активная; ";
                tbxStatus.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                tbxStatus.Text = "Не активная; ";
                tbxStatus.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (equipment.bitKTG == true)
            {
                tbxStatus.Text = tbxStatus.Text + "Учавствует при расчете КТГ; ";
                tbxStatus.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                tbxStatus.Text = tbxStatus.Text + "Не учавствует при расчете КТГ; ";
                tbxStatus.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (equipment.bitMeter == true)
            {
                tbxStatus.Text = tbxStatus.Text + "Учавствует в расчете мото-часов; ";
                tbxStatus.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                tbxStatus.Text = tbxStatus.Text + "Не учавствует в расчете мото-часов; ";
                tbxStatus.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
