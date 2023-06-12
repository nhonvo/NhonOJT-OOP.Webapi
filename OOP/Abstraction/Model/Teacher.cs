namespace Abstraction.Model
{
    public class Teacher : Person
    {
        public int Age { get; set; }
        public void Talk()
        {
            System.Console.WriteLine("Hello");
        }

        public void Walk()
        {
            System.Console.WriteLine("Walking in school");
        }
    }
}