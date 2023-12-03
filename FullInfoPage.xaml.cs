using SportKursach.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportKursach
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class FullInfoPage : Page
    {
        public FullInfoPage()
        {
            InitializeComponent();
            DataContext = new CompetitionViewModel();
        }
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(1);
        }
    }
}
