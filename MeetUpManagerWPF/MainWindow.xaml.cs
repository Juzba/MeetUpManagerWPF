using System.Windows;
using MeetUpManagerWPF.Data;
using MeetUpManagerWPF.View.Pages;
using MeetUpManagerWPF.View.UserControls;

namespace MeetUpManagerWPF
{
    public partial class MainWindow : Window
    {
        private readonly AppDbContext _db;
        


        public MainWindow(AppDbContext db)
        {
            _db = db;
            InitializeComponent();


            MainFrame.Navigate(new Login());
            navBar.Btn_Login += Navbar_Btn_Login;
            navBar.Btn_AddEvent += Navbar_Btn_AddEvent;

        }

        private void Navbar_Btn_Login(object? sender, System.EventArgs e)
        {
            MainFrame.Navigate(new Login());
        }
        private void Navbar_Btn_AddEvent(object? sender, System.EventArgs e)
        {
            MainFrame.Navigate(new AddEvent());
        }
    }
}