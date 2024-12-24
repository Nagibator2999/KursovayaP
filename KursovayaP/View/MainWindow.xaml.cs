using KursovayaP.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KursovayaP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CharactersViewModel();
            DataContext = new ArtifactsVM();
            DataContext = new VMWeapons();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"Sourse/Images/Backgrounde/image1.jpg", UriKind.Relative)));
        }
        private void OpenCharactersWindow(object sender, RoutedEventArgs e)
        {
            var charactersWindow = new CharactersWindow
            {
                DataContext = new ViewModel.CharactersViewModel()
            };
            charactersWindow.Show();
            
        }

        private void OpenWeaponsWindow(object sender, RoutedEventArgs e)
        {
            var weaponsWindow = new WeaponsWindow
            {
                DataContext = new ViewModel.VMWeapons()
            };
            weaponsWindow.Show();
        }

        private void OpenArtifactsWindow(object sender, RoutedEventArgs e)
        {
            var artifactsWindow = new ArtifactsWindow
            {
                DataContext = new ViewModel.ArtifactsVM()
            };
            artifactsWindow.Show();
        }

        private void Button_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}