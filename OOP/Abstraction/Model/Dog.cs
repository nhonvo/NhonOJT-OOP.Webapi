namespace Abstraction.Model
{
    public class Dog : Animal
    {
        public int Age { get; set; }
        public override void Talk()
        {
            System.Console.WriteLine("gau gau" + Age);
        }
    }
}