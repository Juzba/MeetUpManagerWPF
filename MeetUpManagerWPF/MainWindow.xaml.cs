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
using MeetUpManagerWPF.Pages;

namespace MeetUpManagerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_DashBoard(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DashBoard());
        }

        private void Button_Calendar(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CalendarPage());
        }
    }
}