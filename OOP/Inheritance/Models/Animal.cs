namespace Inheritance.Models
{
    public class Animal
    {
        public string Name { get; set; } = string.Empty;
        public virtual void Sleep()
        {
            System.Console.WriteLine("zzz");
        }
    }
}