// See https://aka.ms/new-console-template for more information

using Day16_lecture;

Dog dog1 = new Dog();

    dog1.Name = "Brownie";
    dog1.Age = 10;
    dog1.Size = 13;
    dog1.Weight = 10;
    dog1.Rabbiesvaccine = true;
    dog1.Breed = "Dingo";
    dog1.Gender = 'M';
    dog1.Color = "Brown";

dog1.PrintInfo();

Student stud1 = new Student("Līga",16,"RFL"); //no arg constructor
Student stud2 = new Student("Jānis",22, "LU");
Student stud3 = new Student("Juris", 15);
Student stud4 = new Student("Jana", "R3Ģ");
Student stud5 = new Student(15, "64.vsk");
stud1.PrintInfo();
stud2.PrintInfo();
stud3.PrintInfo();
stud4.PrintInfo();
stud5.PrintInfo();

