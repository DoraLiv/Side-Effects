// See https://aka.ms/new-console-template for more information
/*
// 1D array
Console.WriteLine("1D array sample");
var coffee = 0;
int[] days = new int[7];

days[0] = 32;
days[1] = 44;
days[2] = 51;
days[3] = 47;
days[4] = 23;
days[5] = 5;
days[6] = 3;
for (int i = 0; i < days.Length; i++)
{
    coffee += days[i];
}
Console.WriteLine($"during the week {coffee} cups of coffee were consumed");

//2D arrays int[y,x]
Console.WriteLine("2D array samples ");

int[,] smth = new int[3,2];
smth[1,0]=23;
smth[0,0]=5;
smth[0,1]=34;

//2D arrays - filling up rows

int[,] smth2 = { { 32, 34, 25 },{ 67, 8, 14},{ 23, 87, 90 } };
Console.WriteLine($"the array looks like this:");
Console.WriteLine($"\n|{smth2[0, 0]}|{smth2[0, 1]}|{smth2[0, 2]}|");
Console.WriteLine($"|{smth2[1, 0]}|{smth2[1, 1]}|{smth2[1, 2]}|");
Console.WriteLine($"|{smth2[2, 0]}|{smth2[2, 1]}|{smth2[2, 2]}|");
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{smth2[i,j]}");
        Console.Write("   ");
    }
    Console.WriteLine();
}
Console.WriteLine();


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(smth2[i, j]);
        Console.Write("   ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("transposed array (if rows = colums)");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(smth2[j, i]);
        Console.Write("   ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("transposed array (if rows != colums)");
int[,] smth3 = { { 32, 25 }, { 67, 8 }, { 23, 90 } };
Console.WriteLine("Original 3x2 array:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(smth2[i, j]);
        Console.Write("   ");
    }
    Console.WriteLine();
}
Console.WriteLine("Transposed 2x3 -> 3x2");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(smth2[j, i]);
        Console.Write("   ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Skipping rows");
for (int i = 0; i < 3; i+=2)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(smth2[i, j]);
        Console.Write("   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("[foreach] command - can't manipulate the elements of the array, print them individually");
foreach (int k in smth2)
{
    Console.Write($"{k}");
    Console.Write("  ");
    
}
*/
/*
//WHILE loop
Console.WriteLine("WHILE loop");
bool whileMenuIsRunning = true;

while (whileMenuIsRunning)
{
    //can be written outside the loop as well - then it will appear only at the beginning
    Console.WriteLine("Choose a compliment:");
    Console.WriteLine("1 - you are intelligent!");
    Console.WriteLine("2 - you are beautiful!");
    Console.WriteLine("3 - you are awesome!");
    Console.WriteLine("4 - to quit the menu");
    int.TryParse(Console.ReadLine(), out int menuitem);

    switch (menuitem)
    {
        case 1: Console.WriteLine("You are intelligent!");
            break;
        case 2: Console.WriteLine("You are beautiful!");
            break;
        case 3: Console.WriteLine("You are awesome!");
            break;
        case 4: Console.WriteLine("Byebye!");
            whileMenuIsRunning = false;
            break;
        default: Console.WriteLine("Unknown item, try again!");
            break;
    }
}
*/
/*
//DO WHILE loop - do at least once an dthen check the condition
Console.WriteLine("DO WHILE loop");
int time = 12;
do
{
    Console.WriteLine($"It is {time} o'clock");
    time++;
} while (time <=24);
Console.WriteLine();
Console.WriteLine("if outside the condition - only the initial value, no loops");
int time2 = 36;
do
{
    Console.WriteLine($"It is {time2} o'clock");
    time2++;
} while (time2 <=24);

*/


//Practical task part 2 - 3x5 array, output values properly; *bonus* change to float, calculate sums in rows and columns

/*
int[,] table = new int[3, 5];
Random r = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        table[i, j] = r.Next(-100, 100);
        Console.Write(table[i, j]);
        Console.Write("   ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
*/
/*
float[,] table2 = new float[3, 5];
    var r2 = new Random();
    float sumofarray = 0;
    
    for (int i = 0; i < 3; i++)
    { 
        float sumrow = 0;
        for (int j = 0; j < 5; j++)
        {
            table2[i, j] = r2.Next(0, 100);
            Console.Write($"{table2[i, j]}  ");
            sumrow += table2[i, j];
                 
        }
        sumofarray +=sumrow;
                Console.Write($" the sum of the row is {sumrow}");
        Console.WriteLine();
    }

Console.WriteLine();
float sumofarray3 = 0;
for  (int i = 0; i < 5; i++)
    {    
      float sumcolumn = 0;
        for (int j = 0; j < 3; j++) 
        {
         sumcolumn += table2[j, i];
        }
    Console.Write($"{sumcolumn} ");
    sumofarray3 += sumcolumn;
    }
float sumofarray2 = 0;
    foreach (int k in table2)
{
     sumofarray2 += k;
}
Console.WriteLine($"\nSum of the array rows is {sumofarray} = sum of the array columns {sumofarray3}" );
Console.WriteLine($"Sum of the array elements is {sumofarray2}" );
*/

//with .GetLenght(0) - y axis, .GetLength(1) - x asis
float[,] table2 = new float[3, 5];
var r2 = new Random();
float sumofarray = 0;

for (int i = 0; i < table2.GetLength(0); i++)
{
    float sumrow = 0;
    for (int j = 0; j < table2.GetLength(1); j++)
    {
        table2[i, j] = r2.Next(0, 100);
        Console.Write($"{table2[i, j]}  ");
        sumrow += table2[i, j];

    }
    sumofarray +=sumrow;
    Console.Write($" the sum of the row is {sumrow}");
    Console.WriteLine();
}

Console.WriteLine();
float sumofarray3 = 0;
for (int i = 0; i < table2.GetLength(1); i++)
{
    float sumcolumn = 0;
    for (int j = 0; j < table2.GetLength(0); j++)
    {
        sumcolumn += table2[j, i];
    }
    Console.Write($"{sumcolumn} ");
    sumofarray3 += sumcolumn;
}
float sumofarray2 = 0;
foreach (int k in table2)
{
    sumofarray2 += k;
}
Console.WriteLine($"\nSum of the array rows is {sumofarray} = sum of the array columns {sumofarray3}");
Console.WriteLine($"Sum of the array elements is {sumofarray2}");

