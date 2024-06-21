using System.Windows;
using System.Windows.Controls;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btn = new();
            btn.Content = "B";
            Grid.SetRow(btn, 3);
            Grid.SetColumn(btn, 4);

            Grid grd = (Grid)FindName("mainGrid");

            grd.Children.Add(btn);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!!!");
        }
    }
}