// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
//will not work = no iterations
for (int i = 10; i < 2; i++)
{
    Console.WriteLine($"iteration {i}");

 }

//3 iterations
for (int g = 0; g<30; g+=10)
{
    Console.WriteLine($"iteration {g}");
}*/

//set values array
Console.WriteLine($"----Set values array----");

int[] values = {67,0,12,15,52};
Console.WriteLine("Array : 67,0,12,15,52 ");
Console.WriteLine($"First value is {values[0]}");
Console.WriteLine($"Last value is {values[values.Length-1]}");
Console.WriteLine($"Third value is {values[2]}");
int sum1 = 0;
for (int i = 0; i < values.Length; i++)
{
    sum1 += values[i];
}
Console.WriteLine($"The sum of array elements is {sum1}");

//Random values array
Console.WriteLine($"----Random values array----");
int[] ran =  new int[5];
var random = new Random();
int sum2 = 0;

foreach (int i in ran)
{
    int tempInt = random.Next(101);
    Console.WriteLine($"{tempInt}; ");
    sum2 += tempInt;
}
Console.WriteLine($"Lenght of array is {ran.Length} ");
Console.WriteLine($"The sum of array elements is {sum2}");

//user input for first and last value
Console.WriteLine($"----User input values array----");
var random1 = new Random();
int[] ran1 = new int[5];
Console.WriteLine("Please write the first value!");
ran1[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Please write the last value!");
ran1[ran1.Length-1] = int.Parse(Console.ReadLine());
int sum3 = 0;
int sum4 = ran1[0]+ran1[ran1.Length-1];
for (int i = 1; i < ran1.Length-1; i++)
{
    ran1[i] = random1.Next(101);
}

Console.WriteLine("The array values are:");
foreach (int tempInt in ran1)
{
    Console.WriteLine($"{tempInt}");
    sum3 += tempInt;
}
Console.WriteLine($"Lenght of array is {ran1.Length} ");
Console.WriteLine($"The sum of array elements is {sum3}");
Console.WriteLine($"The sum of elements you wrote is {sum4}");



/*
char[] gradevalues = { 'A', 'B', 'C', 'D'};
char lastgrades = gradevalues [gradevalues.Length - 1];
Console.WriteLine($"Last grade is {lastgrades}");


string[] text1 = { "text1", "text2", "text3", "text4"};
string lasttext = text1 [text1.Length - 1];
Console.WriteLine($"Last text is {lasttext}");

foreach (char tempChar in gradevalues) 
{
    Console.WriteLine($"the grade is {tempChar}");
}

foreach (int tempInt in values)
{
    Console.WriteLine($"the value is {tempInt}");
}
*/