using Abstraction.Model;

Dog dog = new Dog
{
    Name = "Pitpull",
    Age = 10
};
dog.Talk();
dog.Sleep();
Cat cat = new Cat
{
    Name = "niki cat",
    Size = 10
};
cat.Talk();
dog.Sleep();

List<Student> students = new List<Student>{
    new Student{Grade = 11},
    new Student{Grade = 12},
};
students.ForEach(x => { x.Talk(); });

List<Teacher> teachers = new List<Teacher>{
    new Teacher{Age = 11},
    new Teacher{Age = 12},
};
teachers.ForEach(x => { x.Talk(); });