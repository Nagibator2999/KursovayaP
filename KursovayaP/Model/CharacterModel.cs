using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KursovayaP.Model
{
    public class Character
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public string Weapon { get; set; }
        public string BestArtifactSet { get; set; }
        public BitmapImage Image { get; set; }
        public BitmapImage BuildImage { get; set; }
        
    } 
}
