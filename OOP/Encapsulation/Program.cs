using Encapsulation.Models;

Student per = new Student();
System.Console.WriteLine(per.Print());
per.Name = "a";
System.Console.WriteLine(per.Print());
// per.Age = 1;