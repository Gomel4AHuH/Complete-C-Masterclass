using System.Windows;
using System.Windows.Controls;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, RoutedEventArgs e)
        {
            Window wnd = Window.GetWindow(this);
            wnd.Content = new InvoiceView();
        }
    }
}
