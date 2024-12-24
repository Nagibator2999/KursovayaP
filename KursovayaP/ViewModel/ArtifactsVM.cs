using KursovayaP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KursovayaP.ViewModel
{
    public class ArtifactsVM
    {
        public List<Artifact> Artifacts { get; set; }

        public ArtifactsVM()
        {
            Artifacts = new List<Artifact>
            {
                new Artifact
                {
                    SetName = "Архаичный камень",                   
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/arhaichniy_kamen.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/arhaichniy_kamen.jpg")),
                },
                new Artifact
                {
                    SetName = "Бледный огонь",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/bledniy_ogon.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/bledniy_ogon.jpg")),
                },
                new Artifact
                {
                    SetName = "Эмблема рассеченной судьбы",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/emblema_rassechennoy_sudbi.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/emblema_rassechennoy_sudbi.jpg")),
                },
                new Artifact
                {
                    SetName = "Горящая алая ведьма",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/goryashaya_alaya_vedma.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/goryashchaya_alaya_vedma.jpg")),
                },
                new Artifact
                {
                    SetName = "Громогласный рёв ярости",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/gromoglasniy_rev_yarosti.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/gromoglasniy_rev_yarosti.jpg")),
                },
                new Artifact
                {
                    SetName = "Изумрудная тень",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/izumrudnaya_ten.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/izumrudnaya_ten.jpg")),
                },
                new Artifact
                {
                    SetName = "Конец гладиатора",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/konec_gladiatora.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/konec_gladiatora.jpg")),
                },
                new Artifact
                {
                    SetName = "Рыцарь крови",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/ricar_krovi.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/ricar_krovi.jpg")),
                },
                new Artifact
                {
                    SetName = "Сердце глубин",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/serdce_glubin.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/serdce_glubin.jpg")),
                },
                new Artifact
                {
                    SetName = "Стойкость миллелита",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/stoikost_millilita.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/stoikost_millelita.jpg")),
                },
                new Artifact
                {
                    SetName = "Странствующий ансабль",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/stranstvuyushiy_ansambl.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/stranstvuushchiy_ansambl.jpg")),
                },
                new Artifact
                {
                    SetName = "Ступающий по лаве",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/stupaushiy_po_lave.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/stupaushchiy_po_lave.jpg")),
                },
                new Artifact
                {
                    SetName = "Церемония древней знати",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/tseremoniya_drevney_znati.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/tseremoniya_drevney_znati.jpg")),
                },
                new Artifact
                {
                    SetName = "Усмиряющий гром",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/usmiryaushiy_grom.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/usmiryaushchiy_grom.jpg")),
                },
                new Artifact
                {
                    SetName = "Воспоминания Симэнавы",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/vospominaniya_simenavi.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/vospominaniya_simenavi.jpg")),
                },
                new Artifact
                {
                    SetName = "Возлюбленная юная дева",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/vozlublennaya_unaya_deva.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/vozlublennaya_unaya_deva.jpg")),
                },
                new Artifact
                {
                    SetName = "Встречная комета",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/vstrechnaya_kometa.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/vstrechnaya_kometa.jpg")),
                },
                new Artifact
                {
                    SetName = "Заблудший в метели",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/Arts/zabludshiy_v_meteli.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/ArtsBuilds/zabludshiy_v_meteli.jpg")),
                },
            };       
        }           
    }
}
