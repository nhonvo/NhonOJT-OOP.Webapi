namespace Abstraction.Model
{
    public class Student : Person
    {
        public int Grade { get; set; }
        public void Talk()
        {
            System.Console.WriteLine("Hello teacher!");
        }

        public void Walk()
        {
            System.Console.WriteLine("Walking in class");
        }
    }
}