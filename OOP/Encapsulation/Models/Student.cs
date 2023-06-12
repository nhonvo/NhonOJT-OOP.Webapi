namespace Encapsulation.Models
{
    public class Person
    {
        public string Name { get; set; }
    }
    public class Student : Person
    {
        private int Age { get; } = 0;
        public string Print() => Name + " " + Age.ToString();
    }
}