using KursovayaP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace KursovayaP.ViewModel
{
    public class VMWeapons
    {
        public List<WeaponModel> Weapons { get; set; }

        public VMWeapons()
        {
            {
                Weapons = new List<WeaponModel>();
            }
            Weapons = new List<WeaponModel>
            {
                       new WeaponModel {
                            Name = "Песнь патруля пиков",
                            Type = "Меч",
                            BaseAttack = 42,
                            SecondaryStat = "Сила атаки",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/pesnya_patrulya_pikov.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/pesn_patrulya_pikov.jpg"))
                       },
                       new WeaponModel {
                            Name = "Лук Амоса",
                            Type = "Лук",
                            BaseAttack = 46,
                            SecondaryStat = "Сила атаки",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/amos.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/amos.jpg"))
                       },
                       new WeaponModel {
                            Name = "Рассекающий туман",
                            Type = "Меч",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/rassekaushiy_tuman.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/rassekaushiy_tuman.jpg"))
                       },
                        new WeaponModel {
                            Name = "Харан Геппаку Фуцу",
                            Type = "Меч",
                            BaseAttack = 46,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/haran_geppaku_futsu.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/haran.jpg"))
                        },
                       new WeaponModel {
                            Name = "Клятва свободы",
                            Type = "Меч",
                            BaseAttack = 46,
                            SecondaryStat = "Мастерство стихий",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/klyatva_svobodi.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/klyatva_svobodi.jpg"))
                       },
                         new WeaponModel {
                            Name = "Драгоценный омут",
                            Type = "Меч",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/dragoceniy_omut.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/dragocenni_omut.jpg"))
                        },
                        new WeaponModel {
                            Name = "Меч Сокола",
                            Type = "Меч",
                            BaseAttack = 48,
                            SecondaryStat = "Физ. урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/mech_sokola.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/mech_sokola.jpg"))
                        },
                        
                        new WeaponModel {
                            Name = "Очертания алой луны",
                            Type = "Копьё",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/ochertaniya_aloy_luni.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/ochertaniya_aloy_luni.jpg"))
                        },
                        new WeaponModel {
                            Name = "Небесное величие",
                            Type = "Двуручный меч",
                            BaseAttack = 48,
                            SecondaryStat = "Восстановление энергии",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/nebesniy_chetotam.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/nebesnoe_velichie.jpg"))
                        },
                        new WeaponModel {
                            Name = "Волчья погибель",
                            Type = "Двуручный меч",
                            BaseAttack = 46,
                            SecondaryStat = "Сила атаки",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/volchya_pogibel.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/volchya_pogibel.jpg"))
                        },
                         new WeaponModel {
                            Name = "Блеск тихих вод",
                            Type = "Меч",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/blesk_tihih_vod.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/blesk_tihih_vod.jpg"))
                         },


                         new WeaponModel {
                            Name = "Покоритель вихря",
                            Type = "Копьё",
                            BaseAttack = 46,
                            SecondaryStat = "Сила атаки",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/pokoritel_vihrya.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/pokoritel_vihrya.jpg"))
                         },
                        new WeaponModel {
                            Name = "Сияющая жатва",
                            Type = "Копьё",
                            BaseAttack = 48,
                            SecondaryStat = "Восстановление энергии",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/siyaushaya_zhatva.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/zhatva.jpg"))
                        },
                        new WeaponModel {
                            Name = "Нефритовый коршун",
                            Type = "Копьё",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/neftitovi_korshun.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/nefritovi_korshun.jpg"))
                        },
                         new WeaponModel {
                              Name = "Усмиритель бед",
                              Type = "Копьё",
                              BaseAttack = 46,
                              SecondaryStat = "Сила атаки",
                              Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/usmiritel_bed.png")),
                              BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/usmiritel_bed.jpg"))
                         },
                         new WeaponModel {
                            Name = "Посох Хомы",
                            Type = "Копьё",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/posoh_homi.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/posoh_homi.jpg"))
                         },
                         
                        new WeaponModel {
                            Name = "Вечное лунное сияние",
                            Type = "Катализатор",
                            BaseAttack = 46,
                            SecondaryStat = "Восстановление энергии",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/vechniy_moonlight.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/vechnaoe_lunnoe_siyanie.jpg"))
                        },
                        new WeaponModel {
                           Name = "Молитва святым ветрам",
                            Type = "Катализатор",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. шанс",
                           Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/molitva_svyashennim_vetram.png")),
                             BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/molitva_svyatim_vetram.jpg"))
                        },
                         new WeaponModel {
                            Name = "Истина кагура",
                            Type = "Катализатор",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/kagura.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/istina_kagura.jpg"))
                         },
                         new WeaponModel {
                            Name = "Небесная ось",
                            Type = "Копьё",
                            BaseAttack = 48,
                            SecondaryStat = "Восстановление энергии",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/nebesnaya_os.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/nebesnaya_os.jpg"))
                         },
                       

                        new WeaponModel {
                           Name = "Аква симулякрум",
                           Type = "Лук",
                           BaseAttack = 44,
                           SecondaryStat = "Крит. Урон",
                           Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/aqua_simulacra.png")),
                           BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/aqua_simulacra.jpg"))
                        },
                        new WeaponModel {
                            Name = "Громовой пульс",
                            Type = "Лук",
                            BaseAttack = 46,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/gromopodobniy_impuls.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/gromovoi_puls.jpg"))
                        },
                        new WeaponModel {
                            Name = "Небесное крыло",
                            Type = "Лук",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/sky_arpha.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/nebesnoe_krilo.jpg"))
                        },
                        new WeaponModel {
                            Name = "Полярная звезда",
                            Type = "Лук",
                            BaseAttack = 46,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/polar_star.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/polyarnaya_zvezda.jpg"))
                        },
                        new WeaponModel {
                            Name = "Элегия Люмидус",
                            Type = "Копьё",
                            BaseAttack = 46,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/elegiya_lumidus.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/elegiya_lumidus.jpg"))
                        },
                        new WeaponModel {
                            Name = "Казначейский надзор",
                            Type = "Катализатор",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/kontrol_za_deneznimi_potokami.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/kaznacheiskiy_nadzor.jpg"))
                        },
                        new WeaponModel {
                            Name = "Клык горного короля",
                            Type = "Двуручный меч",
                            BaseAttack = 49,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/klik_gornogo_korolya.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/klik_gornogo_korolya.jpg"))
                        },
                        new WeaponModel {
                            Name = "Ключ Хадж-нисут",
                            Type = "Двуручный меч",
                            BaseAttack = 44,
                            SecondaryStat = "НР",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/kluch_kadz_nisuta.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/kluch.jpg"))
                        },
                        new WeaponModel {
                            Name = "Краснорогий камнеруб",
                            Type = "Двуручный меч",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/redhorn_stonethresher.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/krasnorogiy_kamnerub.jpg"))
                        },
                        new WeaponModel {
                            Name = "Кромсатель пиков",
                            Type = "Меч",
                            BaseAttack = 46,
                            SecondaryStat = "Сила атаки",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/kromsatel_pikov.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/kromsatel_pikov.jpg"))
                        },
                        new WeaponModel {
                            Name = "Лови волну",
                            Type = "Катализатор",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/serfing_zavershen.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/lovi_volnu.jpg"))
                        },
                        new WeaponModel {
                            Name = "Маяк тростникового моря",
                            Type = "Двуручный меч",
                            BaseAttack = 46,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/mayak_kamishovogo_morya.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/mayak_trostnikovogo_morya.jpg"))
                        },
                        new WeaponModel {
                            Name = "Обряд вечного течения",
                            Type = "Катализатор",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/vechniy_potok.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/obryad_vechnogo_techeniya.jpg"))
                        },
                        new WeaponModel {
                            Name = "Охотничья тропа",
                            Type = "Лук",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/put_ohotnika.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/ohotnichya_tropa.jpg"))
                        },
                        new WeaponModel {
                            Name = "Отпущение грехов",
                            Type = "Меч",
                            BaseAttack = 47,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/otpushenie_grehov.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/otpushenie_grehov.jpg"))
                        },
                        new WeaponModel {
                            Name = "Память о пыли",
                            Type = "Катализатор",
                            BaseAttack = 46,
                            SecondaryStat = "Сила атаки",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/pamyat_o_pili.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/pamyat_o_pili.jpg"))
                        },
                        new WeaponModel {
                            Name = "Первый великий фокус",
                            Type = "Лук",
                            BaseAttack = 46,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/first_great_magic.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/perviy_velikiy_fokus.jpg"))
                        },
                        new WeaponModel {
                            Name = "Песнь разбитых сосен",
                            Type = "Двуручный меч",
                            BaseAttack = 49,
                            SecondaryStat = "Физ. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/pesn_slomannih_sosen.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/pesn_razbitih_sosen.jpg"))
                        },
                        new WeaponModel {
                            Name = "Сердечные струны дождя",
                            Type = "Лук",
                            BaseAttack = 44,
                            SecondaryStat = "НР",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/silvershower_heartstrings.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/serdechnie_struni_dozhdya.jpg"))
                        },
                        new WeaponModel {
                            Name = "Сновидения тысячи ночей",
                            Type = "Катализатор",
                            BaseAttack = 44,
                            SecondaryStat = "Мастерство стихий",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/tisacha_paryashih_snov.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/snovideniya.jpg"))
                        },
                        new WeaponModel {
                            Name = "Ураку Мисугири",
                            Type = "Меч",
                            BaseAttack = 44,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/uraku_misugiri.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/uraku_misugri.jpg"))
                        },
                        new WeaponModel {
                            Name = "Великолепие лазурного свода",
                            Type = "Катализатор",
                            BaseAttack = 46,
                            SecondaryStat = "НР",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/velikolepie_nefrita.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/velikolepie_lazurnogo_svoda.jpg"))
                        },
                        new WeaponModel {
                            Name = "Вердикт",
                            Type = "Двуручный меч",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. Шанс",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/verdickt.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/verdikt.jpg"))
                        },
                        new WeaponModel {
                            Name = "Воспоминания Тулайтуллы",
                            Type = "Катализатор",
                            BaseAttack = 48,
                            SecondaryStat = "Крит. Урон",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/pamyat_o_tullaytule.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/vospominaiya_tal.jpg"))
                        },
                        new WeaponModel {
                            Name = "Звонкий клич журавля",
                            Type = "Катализатор",
                            BaseAttack = 49,
                            SecondaryStat = "Сила атаки",
                            Image = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/Weapons/eho_zov_kreina.png")),
                            BuildImage = new BitmapImage(uriSource: new Uri("pack://application:,,,/Sourse/Images/WeaponsBuilds/zvonkiy_klich_zhuravlya.jpg"))
                        },
            };

        }
        

    }
}
