using System.Windows;
using System.Windows.Controls;
using MeetUpManagerWPF.Code.Autorization;
using MeetUpManagerWPF.View.Pages;

namespace MeetUpManagerWPF.View.UserControls
{
    public partial class NavBar : UserControl
    {
        
        public EventHandler? Btn_Login;
        public EventHandler? Btn_AddEvent;

        public NavBar()
        {
          
            InitializeComponent();
            
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            Btn_Login?.Invoke(this, e);
        }
        private void Button_AddEvent(object sender, RoutedEventArgs e)
        {
            Btn_AddEvent?.Invoke(this, e);
        }
    }
}
