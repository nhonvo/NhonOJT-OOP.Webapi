namespace Inheritance.Models
{
    public class Dog : Animal
    {
        public int Age { get; set; }
        public void Talk()
        {
            System.Console.WriteLine(Name + " gau gau " + Age);
        }
    }
}