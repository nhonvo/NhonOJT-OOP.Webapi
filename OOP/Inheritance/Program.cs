using Inheritance.Models;

Animal animal = new Animal();
animal.Sleep();
Cat cat = new Cat { Name = "Cat", Size = 1 };
cat.Sleep();
cat.Talk();
Dog dog = new Dog{ Name = "Dog", Age = 1 };
dog.Sleep();
dog.Talk();