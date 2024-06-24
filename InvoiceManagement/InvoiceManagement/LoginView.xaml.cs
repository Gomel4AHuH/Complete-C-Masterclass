using System.Windows;
using System.Windows.Controls;

namespace InvoiceManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        const string pswrd = "2001";
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string pswrdEntered = PasswordBox.Password;
            MessageBox.Show((pswrdEntered == pswrd) ? "Correct" : "Incorrect");
        }

        public void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
