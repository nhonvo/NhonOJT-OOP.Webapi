namespace Inheritance.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public virtual void Sleep()
        {
            System.Console.WriteLine("zzz");
        }
    }
}