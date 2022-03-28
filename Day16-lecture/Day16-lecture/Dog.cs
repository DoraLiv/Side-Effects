using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_lecture
{
	public class Dog
	{//can set additional verification
	 //if private class - will have to use getters (Get...) and setters (Set..)
	 //get and set to retrieve and assign values to the variable
		public string Name { get; set; }
		public int Age { get; set; }
		public float Size { get; set; }
		public float Weight { get; set; }
		public string Breed { get; set; }
		public string Color { get; set; }
		public bool Rabbiesvaccine { get; set; }
		public char Gender { get; set; }
		/*
		public Dog (string Name, int Age, float Size,
			float Weight, string Breed, string Color,
			bool Rabbiesvaccine, char Gender)
        {
			this.Name = Name;
			this.Age = Age;
			this.Size = Size;
			this.Weight = Weight;
			this.Breed = Breed;
			this.Color = Color;
			this.Rabbiesvaccine = Rabbiesvaccine;
			this.Gender = Gender;
        }
		*/
		public void PrintInfo()
		{
			Console.WriteLine($"{Name}, {Age}, {Size}, {Weight}, {Breed}, {Color}, {Rabbiesvaccine}, {Gender}");
		}

	}
	
	
}
