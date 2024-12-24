using KursovayaP.Model;
using KursovayaP.View;
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

namespace KursovayaP
{
    /// <summary>
    /// Логика взаимодействия для WeaponsWindow.xaml
    /// </summary>
    public partial class WeaponsWindow : Window
    {
        public WeaponsWindow()
        {
            InitializeComponent();
        }

        private void WeaponButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is WeaponModel weapon)
            {
                var weaponInfoWindow = new WeaponsInfoWindow(weapon);
                weaponInfoWindow.ShowDialog();
            }
        }
    }
}
