using System.Windows;
using System.Windows.Controls;

namespace ToDo
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

        private void AddToDoItemButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = ToDoInput.Text.Trim();

            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock toDoItem = new()
                {
                    Text = todoText,
                    Margin = new Thickness(5)
                };
                ToDoList.Children.Add(toDoItem);
                ToDoInput.Clear();
                ToDoInput.Focus();
            }
        }
    }
}