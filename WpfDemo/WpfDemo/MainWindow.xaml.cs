using System;
using System.Windows;
using WpfDemo.Data;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> persons = [];

        public MainWindow()
        {
            InitializeComponent();
            persons.Add(new Person("Andrei", 44));
            persons.Add(new Person("Alex", 18));
            persons.Add(new Person("Egor", 15));

            ListBoxPersons.ItemsSource = persons;

        }

        private void ListBoxPersons_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Person person = ListBoxPersons.SelectedItem as Person;

            MessageBox.Show(person.Name + " is " + person.Age + " years old.");
        }
    }
}