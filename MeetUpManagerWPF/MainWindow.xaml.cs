using System.Windows;
using MeetUpManagerWPF.Data;
using MeetUpManagerWPF.View.Pages;

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

        }
    }
}