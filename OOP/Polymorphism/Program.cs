using Polymorphism.Models;

Person student = new Student { Grade = 1 };
Person teacher = new Teacher { Age = 18 };
student.Talk();
teacher.Talk();