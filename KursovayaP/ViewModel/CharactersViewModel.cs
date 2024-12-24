using KursovayaP.Model;
using System.Windows.Media.Imaging;

namespace KursovayaP.ViewModel
{
    public class CharactersViewModel
    {
        public List<Character> Characters { get; set; }

        public CharactersViewModel()
        {
            Characters = new List<Character>
            {
                new Character {
                    Name = "Альбедо",
                    Element = "Гео",
                    Weapon = "Меч", 
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/albedo.jpg")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/albedo.jpg")),
                },
                new Character {
                    Name = "Эмбер",
                    Element = "Пиро",
                    Weapon = "Лук",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/ember.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/amber.jpg")),
                },
                new Character {
                    Name = "Барбара",
                    Element = "Гидро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/barbara.png")),
                    BuildImage = new BitmapImage(uriSource : new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/barbara.jpg"))
                },
                new Character {
                    Name = "Беннетт",
                    Element = "Пиро",
                    Weapon = "Меч",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/bennet.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/bennet.jpg"))
                },
                new Character {
                    Name = "Дилюк",
                    Element = "Пиро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/diluk.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/diluc.jpg"))
                },
                new Character {
                    Name = "Диона",
                    Element = "Крио",
                    Weapon = "Лук",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/diona.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/diona.jpg"))
                },
                new Character {
                    Name = "Эола",
                    Element = "Крио",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/eola.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/eola.jpg"))
                },
                new Character {
                    Name = "Фишль",
                    Element = "Электро",
                    Weapon = "Лук",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/fischl.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/fischle.jpg"))
                },
                new Character {
                    Name = "Джинн",
                    Element = "Анемо",
                    Weapon = "Меч",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/jin.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/jean.jpeg"))
                },
                new Character {
                    Name = "Кэйа",
                    Element = "Крио",
                    Weapon = "Меч",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/keya.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kaeya.jpg"))
                },
                new Character {
                    Name = "Кли",
                    Element = "Пиро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/kli.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kli.jpg"))
                },
                new Character {
                    Name = "Лиза",
                    Element = "Электро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/lisa.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/lisa.jpg"))
                },
                new Character {
                    Name = "Мика",
                    Element = "Крио",
                    Weapon = "Копьё",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/mika.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/mika.jpg"))
                },
                new Character {
                    Name = "Мона",
                    Element = "Гидро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/mona.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/mona.jpg"))
                },
                new Character {
                    Name = "Ноэлль",
                    Element = "Гео",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/noell.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/noell.jpg"))
                },
                new Character {
                    Name = "Рейзор",
                    Element = "Электро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/reizor.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/reizor.jpg"))
                },
                new Character {
                    Name = "Розария",
                    Element = "Крио",
                    Weapon = "Копьё",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/rosaria.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/rosaria.jpg"))
                },
                new Character {
                    Name = "Сахароза",
                    Element = "Анемо",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/saharoza.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/saharoza.jpg"))
                },
                new Character {
                    Name = "Венти",
                    Element = "Анемо",
                    Weapon = "Лук",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/venti.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/venti.jpg"))
                },
                new Character {
                    Name = "Бай Чжу",
                    Element = "Дендро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/bai_dju.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/bai_jzu.jpg"))
                },
                new Character {
                    Name = "Бей Доу",
                    Element = "Электро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/beidou.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/beidou.jpg"))
                },
                new Character {
                    Name = "Чун Юнь",
                    Element = "Крио",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/chonguyn.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/chunyun.jpg"))
                },
                new Character {
                    Name = "Ка Мин",
                    Element = "Пиро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/kamin.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kamin.jpg"))
                },
                new Character {
                    Name = "Гань Юй",
                    Element = "Крио",
                    Weapon = "Лук",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/ganuyi.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/ganui.jpg"))
                },
                new Character {
                    Name = "Ху Тао",
                    Element = "Пиро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/hutao.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/hutao.jpg"))
                },
                new Character {
                    Name = "Кэ Цин",
                    Element = "Электро",
                    Weapon = "Меч",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/kecing.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/keking.jpg"))
                },
                new Character {
                    Name = "Нин Гуан",
                    Element = "Гео",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/ninguan.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/ninguan.jpg"))
                },
                new Character {
                    Name = "Цици",
                    Element = "Крио",
                    Weapon = "Меч",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/cici.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/cici.jpg"))
                },
                new Character {
                    Name = "Шень Хэ",
                    Element = "Крио",
                    Weapon = "Копьё",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/shenhe.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/shenhe.jpg"))
                },
                new Character {
                    Name = "Сянлин",
                    Element = "Пиро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/syanlin.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/syanlin.jpg"))
                },
                new Character {
                    Name = "Сянь Юнь",
                    Element = "Анемо",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/syanyun.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/syanyun.jpg"))
                },
                new Character {
                    Name = "Сяо",
                    Element = "Анемо",
                    Weapon = "Копьё",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/syao.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/syao.jpg"))
                },
                new Character {
                    Name = "Син Цю",
                    Element = "Гидро",
                    Weapon = "Меч",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/sintsyu.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/sincu.jpg"))
                },
                new Character {
                    Name = "Синь Янь",
                    Element = "Пиро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/sinyan.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/sinyan.jpg"))
                },
                new Character {
                    Name = "Янь Фэй",
                    Element = "Пиро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/yanfei.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/yanfei.jpg"))
                },
                new Character {
                    Name = "Яо Яо",
                    Element = "Дендро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/yaoyao.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/yaoyao.jpg"))
                },
                new Character {
                    Name = "Е Лань",
                    Element = "Гидро",
                    Weapon = "Лук",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/elan.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/elan.jpg"))
                },
                new Character {
                    Name = "Юнь Цзинь",
                    Element = "Гео",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/yundzin.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/unczin.jpg"))
                },
                new Character {
                    Name = "Чжун Ли",
                    Element = "Гео",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/junli.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/chzunli.jpg"))
                },
                new Character {
                    Name = "Аратаки Итто",
                    Element = "Гео",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/itto.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/itto.jpg"))
                },
                new Character {
                    Name = "Тиори",
                    Element = "Гео",
                    Weapon = "Меч",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/chiori.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/tiori.jpg"))
                },
                new Character {
                    Name = "Горо",
                    Element = "Гео",
                    Weapon = "Лук",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/goro.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/goro.jpg"))
                },
                new Character {
                    Name = "Каэдехара Кадзуха",
                    Element = "Анемо",
                    Weapon = "Меч",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/kazuha.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kadzuha.jpg"))
                },
                new Character {
                    Name = "Камисато Аяка",
                    Element = "Крио",
                    Weapon = "Меч",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/ayaka.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/ayaka.jpg"))
                },
                new Character {
                    Name = "Камисато Аято",
                    Element = "Гидро",
                    Weapon = "Меч",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/ayato.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/ayato.jpg"))
                },
                new Character {
                    Name = "Кирара",
                    Element = "Дендро",
                    Weapon = "Меч",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/kirara.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kirara.jpg"))
                },
                new Character {
                    Name = "Кудзе Сара",
                    Element = "Электро",
                    Weapon = "Лук",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/sara.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/sara.jpg"))
                },
                new Character {
                    Name = "Куки Синобу",
                    Element = "Электро",
                    Weapon = "Меч",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/sinobu.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/sinobu.jpg"))
                },
                new Character {
                    Name = "Райден Сегун",
                    Element = "Электро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/raiden.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/raiden.jpg"))
                },
                new Character {
                    Name = "Сангономия Кокоми",
                    Element = "Гидро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/kokomi.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kokomi.jpg"))
                },
                new Character {
                    Name = "Саю",
                    Element = "Анемо",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/sayu.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/sau.jpg"))
                },
                new Character {
                    Name = "Сиканоин Хейдзо",
                    Element = "Анемо",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/heidzo.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/heidzo.jpg"))
                },
                new Character {
                    Name = "Тома",
                    Element = "Пиро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/toma.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/toma.jpg"))
                },
                new Character {
                    Name = "Яэ Мико",
                    Element = "Электро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/yaemiko.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/yaemiko.jpg"))
                },
                new Character {
                    Name = "Ёимия",
                    Element = "Пиро",
                    Weapon = "Лук",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/eimiya.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/eimia.jpg"))
                },
                new Character {
                    Name = "Аль-Хайтам",
                    Element = "Дендро",
                    Weapon = "Меч",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/alhaitam.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/alhaitam.jpg"))
                },
                new Character {
                    Name = "Кандакия",
                    Element = "Гидро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/kandakia.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kandakia.jpg"))
                },
                new Character {
                    Name = "Коллеи",
                    Element = "Дендро",
                    Weapon = "Лук",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/kollei.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kollei.jpg"))
                },
                new Character {
                    Name = "Сайно",
                    Element = "Электро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/cino.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/saino.jpg"))
                },
                new Character {
                    Name = "Дэхья",
                    Element = "Пиро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/dehya.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/dehia.jpg"))
                },
                new Character {
                    Name = "Дори",
                    Element = "Электро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/dori.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/dori.jpg"))
                },
                new Character {
                    Name = "Фарузан",
                    Element = "Анемо",
                    Weapon = "Лук",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/faruzan.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/faruzan.jpg"))
                },
                new Character {
                    Name = "Кавех",
                    Element = "Дендро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/kaveh.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kaveh.jpg"))
                },
                new Character {
                    Name = "Лайла",
                    Element = "Крио",
                    Weapon = "Меч",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/layla.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/layla.jpg"))
                },
                new Character {
                    Name = "Нахида",
                    Element = "Дендро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/nahida.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/nahida.jpg"))
                },
                new Character {
                    Name = "Нилу",
                    Element = "Гидро",
                    Weapon = "Меч",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/nilou.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/nilou.jpg"))
                },
                new Character {
                    Name = "Сетос",
                    Element = "Электро",
                    Weapon = "Лук",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/setos.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/setos.jpg"))
                },
                new Character {
                    Name = "Тигнари",
                    Element = "Дендро",
                    Weapon = "Лук",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/tignari.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/tignari.jpg"))
                },
                new Character {
                    Name = "Странник",
                    Element = "Анемо",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/strannik.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/skaramucha.jpg"))
                },
                new Character {
                    Name = "Шарлотта",
                    Element = "Крио",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/sharlotta.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/sharlotta.jpg"))
                },
                new Character {
                    Name = "Шеврёз",
                    Element = "Пиро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/shevrez.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/shevrez.jpg"))
                },
                new Character {
                    Name = "Клоринда",
                    Element = "Электро",
                    Weapon = "Меч",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/klorinda.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/klorinda.jpg"))
                },
                new Character {
                    Name = "Эмилия",
                    Element = "Дендро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/emiliya.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/emilia.jpg"))
                },
                new Character {
                    Name = "Фремине",
                    Element = "Крио",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/fremine.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/fremine.jpg"))
                },
                new Character {
                    Name = "Фурина",
                    Element = "Гидро",
                    Weapon = "Меч",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/furina.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/furina.jpg"))
                },
                new Character {
                    Name = "Линетт",
                    Element = "Анемо",
                    Weapon = "Меч",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/linett.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/linett.jpg"))
                },
                new Character {
                    Name = "Лини",
                    Element = "Пиро",
                    Weapon = "Лук",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/lini.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/liney.jpg"))
                },
                new Character {
                    Name = "Навия",
                    Element = "Гео",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/navia.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/naviya.jpg"))
                },
                new Character {
                    Name = "Нёвиллет",
                    Element = "Гидро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/nevillet.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/nevilett.jpg"))
                },
                new Character {
                    Name = "Сиджвин",
                    Element = "Гидро",
                    Weapon = "Лук",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/sigwinn.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/sigvin.jpg"))
                },
                new Character {
                    Name = "Ризли",
                    Element = "Крио",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Снежной Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/rizli.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/risley.jpg"))
                },
                new Character {
                    Name = "Часка",
                    Element = "Анемо",
                    Weapon = "Лук",
                    BestArtifactSet = "Вестерождённый",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/jaska.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/chaska.jpg"))
                },
                new Character {
                    Name = "Качина",
                    Element = "Гео",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/kachina.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kachina.jpg"))
                },
                new Character {
                    Name = "Кинич",
                    Element = "Дендро",
                    Weapon = "Двуручный меч",
                    BestArtifactSet = "Цветущего Камня",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/kinich.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/kinich.jpg"))
                },
                new Character {
                    Name = "Муалани",
                    Element = "Гидро",
                    Weapon = "Катализатор",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/mualani.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/mualani.jpg"))
                },
                new Character {
                    Name = "Оророн",
                    Element = "Электро",
                    Weapon = "Лук",
                    BestArtifactSet = "Громовой Ярости",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/4/ororon.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/ororon.jpg"))
                },
                new Character {
                    Name = "Шилонен",
                    Element = "Гео",
                    Weapon = "Меч",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/shilonen.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/shilonen.jpg"))
                },
                new Character {
                    Name = "Арлекино",
                    Element = "Пиро",
                    Weapon = "Копьё",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/arlecchino.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/arlekino.jpg"))
                },
                new Character {
                    Name = "Тарталья",
                    Element = "Гидро",
                    Weapon = "Лук",
                    BestArtifactSet = "Водного Покрова",
                    Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersIcon/5/tartalia.png")),
                    BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/CharactersBuilds/tartalia.jpg"))
                }

            };

        }
    }    

}
