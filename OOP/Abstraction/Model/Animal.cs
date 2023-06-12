namespace Abstraction.Model
{
    public abstract class Animal
    {
        public string Name { get; set; } = string.Empty;
        public abstract void Talk();
        public virtual void Sleep()
        {
            System.Console.WriteLine("zzz");
        }
    }
}