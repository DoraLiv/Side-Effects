using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_lecture
{
    internal class Student
    {
        private string Name { get; set; } //can omit get/set
        private int Age { get; set; }
        private string School { get; set; }


        public Student()  //no argument constructor
        {
            this.Name = "not defined";
            this.Age  = 1;
            this.School = "not defined";
        }

         public Student(string name1, int age1, string school1)
        {
            Name = name1;
            Age  = age1;
            School = school1;
        }

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age  = Age;
            this.School = "not defined";
        }

        public Student(int Age, string School)
        {
            this.Name = "not defined";
            this.Age  = Age;
            this.School = School;
        }

        public Student(string Name, string School)
        {
            this.Name = Name;
            this.Age  = 1;
            this.School = School;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, {Age}, {School}");
        }

    }
   
    

}
