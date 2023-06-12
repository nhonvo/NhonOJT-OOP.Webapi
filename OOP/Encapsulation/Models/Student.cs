namespace Encapsulation.Models
{
    public class Student : Person
    {
        private int Age { get; } = 0;
        public string Print() => Name + " " + Age.ToString();
    }
}