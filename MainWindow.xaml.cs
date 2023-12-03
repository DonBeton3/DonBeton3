using SportKursach.ViewModels;
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

namespace SportKursach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isAddCompetitionClicked;

        public bool IsAddCompetitionClicked
        {
            get { return _isAddCompetitionClicked; }
            set
            {
                _isAddCompetitionClicked = value;
               
                //UpdateVisibility();
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            
            IsAddCompetitionClicked = false;
            DataContext = new CompetitionViewModel();
        }

        

        private void FullInfo_Button(object sender, RoutedEventArgs e)
        {
            MyGr.Visibility = Visibility.Collapsed;
            FullInfoPage fullInfo = new FullInfoPage();
            MainFrame.Content = fullInfo;
            MyGrid.Visibility = Visibility.Visible;
            
        }
        private void Update_Button(object sender, RoutedEventArgs e)
        {
            MyGr.Visibility = Visibility.Collapsed;
            UpdatePage updatePage = new UpdatePage();
            MainFrame.Content = updatePage;
            MyGrid.Visibility = Visibility.Visible;
        }
        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            MyGr.Visibility = Visibility.Collapsed;
            DeletePage AddPage = new DeletePage();
            MainFrame.Content = AddPage;
            MyGrid.Visibility = Visibility.Visible;
        }
        private void Add_Button(object sender, RoutedEventArgs e)
        {
            MyGr.Visibility = Visibility.Collapsed;
            AddPagexaml AddPage = new AddPagexaml();
            MainFrame.Content = AddPage;
            MyGrid.Visibility = Visibility.Visible;
        }
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Ваш обработчик двойного клика на строке
        }
    }

}