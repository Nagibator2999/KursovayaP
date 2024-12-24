using KursovayaP.Model;
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

namespace KursovayaP.View
{
    /// <summary>
    /// Логика взаимодействия для WeaponsInfoWindow.xaml
    /// </summary>
    public partial class WeaponsInfoWindow : Window
    {
        public WeaponsInfoWindow(WeaponModel weapon)
        {
            InitializeComponent();          
            this.Background = new ImageBrush(weapon.BuildImage);
        }
    }
}
