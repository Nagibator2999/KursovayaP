using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KursovayaP.Model
{
    public class WeaponModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int BaseAttack { get; set; }
        public string SecondaryStat { get; set; }
        public BitmapImage Image { get; set; }
        public BitmapImage BuildImage { get; set; }
    }
}
