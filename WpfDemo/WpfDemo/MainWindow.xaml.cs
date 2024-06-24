using System.Windows;
using System.Windows.Controls;
using WpfDemo.Data;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Person prsn = new("Andrei", 44);
        public MainWindow()
        {
            InitializeComponent();
                                 
            this.DataContext = prsn;
            
            //MainContent.Content = new LoginView();

            /*
            Button btn = new();
            btn.Content = "B";
            Grid.SetRow(btn, 3);
            Grid.SetColumn(btn, 4);

            Grid grd = (Grid)FindName("mainGrid");

            grd.Children.Add(btn);
            */

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personData = prsn.Name + " is " + prsn.Age + " years old.";
            MessageBox.Show(personData);
            
        }
    }
}