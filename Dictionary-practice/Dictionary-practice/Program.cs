// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
/*
Dictionary<string, double> shoppingList = new Dictionary<string, double>();
shoppingList.Add("Shampoo", 5.62);
shoppingList.Add("Conditioner", 3.98);
shoppingList.Add("Detergent", 9.34);
shoppingList.Add("Cat Food", 40.98);
shoppingList.Add("Milk", 1.29);
shoppingList.Add("Water", 0.78);
shoppingList.Add("Flowers", 3.25);
shoppingList.Add("Matches", 0.25);

int i = 0;
foreach (int price in shoppingList.Values)
{
    if (price < 1)
    {
        i++;
    }
}
Console.WriteLine($"Number of items under 1 euro: {i}");
var cheapest = shoppingList.MinBy(temp => temp.Value).Key;
Console.WriteLine($"Cheapest item is: {cheapest}");
var expensive = shoppingList.MaxBy(temp =>temp.Value).Key;
Console.WriteLine($"Most expensive item is: {expensive}");

Dictionary<string, double> addition = new Dictionary<string, double>();
addition.Add("Eggs", 3.29);
addition.Add("Candles", 9.78);
addition.Add("Nutella", 5.25);
addition.Add("Bread", 1.25);

//Dictionary<string, double> total = new Dictionary<string, double>();

//addition.ToList().ForEach(x => shoppingList.Add(x.Key, x.Value));
foreach(var item in addition)  //a way to merge both dictionaries
{
    shoppingList.Add(item.Key, item.Value);

}
int j=0;
foreach (var item in shoppingList)
{
    j++;
}
Console.WriteLine($"Number of items in the new list is: {j}");

var priceorder = shoppingList.OrderBy(temp => temp.Value).ToDictionary(x => x.Key, x => x.Value);

foreach (var item in priceorder)
{
    Console.WriteLine($"{item}");
}
*/

//Task2 - palindromes in data structures
Console.WriteLine($"Write something:");
string input = Console.ReadLine().ToLower();

string inputFormated = string.Empty;
Stack<char> inputstack = new Stack<char>();
Regex re = new Regex("[a-zA-Z]");
for (int t = 0; t < input.Length; t++)
{
    if (re.IsMatch(input[t].ToString()))
    {
        inputFormated += input[t];
    }
}
foreach (char c in inputFormated)
{
     inputstack.Push(c);
}
string inputReversed = string.Empty;
foreach (char c in inputstack)
{
    inputReversed += c;
}
Console.WriteLine();
Console.WriteLine(inputReversed.Equals(inputFormated));