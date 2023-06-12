namespace Abstraction.Model
{
    public class Cat : Animal
    {
        public int Size { get; set; }
        public override void Talk()
        {
            System.Console.WriteLine("meo meo" + Size);
        }
    }
}