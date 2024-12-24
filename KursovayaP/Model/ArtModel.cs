using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KursovayaP.Model
{
    public class Artifact
    {
        public string SetName { get; set; }       
        public BitmapImage Image { get; set; }
        public BitmapImage BuildImage { get; set; }
    }
}
