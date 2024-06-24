namespace WpfDemo.Data
{
    public class Person(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

    }
}
