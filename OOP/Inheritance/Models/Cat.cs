namespace Inheritance.Models
{
    public class Cat : Animal
    {
        public int Size { get; set; }
        public void Talk()
        {
            System.Console.WriteLine(Name + " meo meo " + Size);
        }
    }
}