namespace Abstraction.Model
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Talk();
        public virtual void Sleep()
        {
            System.Console.WriteLine("zzz");
        }
    }
}