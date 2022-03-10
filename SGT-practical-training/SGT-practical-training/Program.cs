// See https://aka.ms/new-console-template for more information


/*
var sideA = 8;
var sideB = 8;
var sideC = 5;
*/

Console.WriteLine("Write the length of the side A of the triangle");
var sideA = int.Parse(Console.ReadLine());
Console.WriteLine("\nWrite the length of the side B of the triangle");
var sideB = int.Parse(Console.ReadLine());
Console.WriteLine("\nWrite the length of the side C of the triangle");
var sideC = int.Parse(Console.ReadLine());


bool equilateraltriangle;
bool isoscelestriangle;
bool scalenetriangle;

if (sideA+sideB > sideC && sideB+sideC > sideA && sideC+sideA > sideB)
{

    if (sideA == sideB || sideB == sideC || sideA == sideC)
    {
        equilateraltriangle = true;
        Console.WriteLine("\nIt is a equilateral triangle");
    }
    if (sideA == sideB && sideB == sideC)
    {
        isoscelestriangle = true;
        Console.WriteLine("\nIt is a isosceles triangle");
    }
    if (sideA != sideB && sideB != sideC && sideA != sideC)
    {
        scalenetriangle = true;
        Console.WriteLine("\nIt is a scalene triangle");
    }
}
else
{
    Console.WriteLine("\nYou're bad at geometry - it is not an actual triangle!");
}



