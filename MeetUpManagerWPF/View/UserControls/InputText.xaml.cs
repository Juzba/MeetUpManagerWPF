using System.Windows;
using System.Windows.Controls;

namespace CustomFormWPF.View.UserControls
{
    public partial class InputText : UserControl
    {
        public InputText()
        {
            InitializeComponent();
            textBlockInput.Text = myPlaceHolder;
        }


        //propfull
        private string? myPlaceHolder;
        public string? MyPlaceHolder
        {
            get { return myPlaceHolder; }
            set
            {
                myPlaceHolder = value;
                textBlockInput.Text = myPlaceHolder;
            }
        }


        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            textBoxInput.Clear();
        }

        private void TextBox_Change(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInput.Text))
                textBlockInput.Visibility = Visibility.Visible;
            else
                textBlockInput.Visibility = Visibility.Hidden;
        }
    }
}
