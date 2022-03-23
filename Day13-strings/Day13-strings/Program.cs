// See https://aka.ms/new-console-template for more information

/*
char[] letters = { 'D', 'o', 'r','a' };
string name = new string(letters);

string equals = "Dora";
*/

using System.Text;
using System.Text.RegularExpressions;

string[] cities = { "Copenhagen", "Paris", "Tokyo", "Bristol", "Mumbai", "Dehli", "Riga", "Vienna", "Warsaw", "Hamburg", "Cesis" };

StringBuilder starts = new StringBuilder();
StringBuilder ends = new StringBuilder();
StringBuilder lettercount = new StringBuilder();
StringBuilder contains = new StringBuilder();
//StringBuilder substringEN = new StringBuilder();


int cCount = 0;
bool menuOn=true;

do
{
    Console.WriteLine("Please choose the search parameter:");
    Console.WriteLine("1. Search by first letter");
    Console.WriteLine("2. Search by last letter");
    Console.WriteLine("3. search by the number of letters");
    Console.WriteLine("4. search by partial match");
    Console.WriteLine("* quit search\n");
    string choise = Console.ReadLine();
    Console.WriteLine();
    switch (choise)
    {
        case "1":

            bool menufirst = true;
            do
            {
                Console.WriteLine("Please insert the first letter:");
                Console.WriteLine("Type * to return to main menu");
                Console.WriteLine();
                string firstletter = Console.ReadLine();
                Console.WriteLine();

                if (firstletter != "*")
                {
                    char first = firstletter [0];
                    Regex re = new Regex($"^{first}", RegexOptions.IgnoreCase);
                    int j = 1;
                    cCount = 0;
                    for (int i = 0; i < cities.Length; i++)
                        if (re.IsMatch(cities[i]))
                        {
                            cCount++;           
                            starts.Append($"{j}.{cities[i]}; ");
                            j++;
                        }
                    Console.WriteLine($"There are {cCount} cities starting with \"{first}\":");
                    Console.WriteLine(starts); 
                    Console.WriteLine();
                    starts = new StringBuilder();
                }
                else if (firstletter == "*")
                {
                    menufirst = false;
                }
                
            } while (menufirst);

            break;

        case "2":
            bool menulast = true;
            do
            {
                Console.WriteLine("Please insert the last letter:");
                Console.WriteLine("Type * to return to main menu");
                Console.WriteLine();
                string lastletter = Console.ReadLine();
                Console.WriteLine();

                if (lastletter != "*")
                {
                    char last = lastletter[0];
                    Regex re2 = new Regex($"{last}$", RegexOptions.IgnoreCase);
                    int j = 1;
                    cCount = 0;
                    for (int i = 0; i < cities.Length; i++)
                       if (re2.IsMatch(cities[i]))
                       {
                            cCount++;
                            ends.Append($"{j}.{cities[i]}; ");
                            j++;
                       }
                    Console.WriteLine($"There are {cCount} cities ending with \"{last}\":");
                    Console.WriteLine(ends);
                    Console.WriteLine();
                    ends = new StringBuilder();
                    
                }
                else if (lastletter == "*")
                {
                    menulast = false;
                }
                
            } while (menulast);
            break;

        case "3":
            bool menucount = true;
            do
            {
                Console.WriteLine("Enter the number of letters:");
                Console.WriteLine("Type * to return to main menu");
                Console.WriteLine();
                string letters = Console.ReadLine();
                Console.WriteLine();

                if (letters != "*")
                {
                    Regex check = new Regex(@"^\d+$");
                    if (check.IsMatch(letters))
                    {
                        int.TryParse((letters), out int number);
                        Regex re3 = new Regex($"^[a-zA-Z]{{{number}}}$");
                        int j = 1;
                        cCount = 0;
                        for (int i = 0; i < cities.Length; i++)
                            if (re3.IsMatch(cities[i]))
                            {
                                cCount++;
                                lettercount.Append($"{j}.{cities[i]}; ");
                                j++;
                            }
                        Console.WriteLine($"There are {cCount} cities containing exactly {letters} letters:");
                        Console.WriteLine(lettercount);
                        Console.WriteLine();
                        lettercount = new StringBuilder();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input value. Try again!");
                        Console.WriteLine();
                    }
                    

                }
                else if (letters == "*")
                {
                    menucount = false;
                }

            } while (menucount);
            break;

        case "4":
            bool menuPart = true;
            do
            {
                Console.WriteLine("Enter part of the word:");
                Console.WriteLine("Type * to return to main menu");
                Console.WriteLine();
                string part = Console.ReadLine();
                Console.WriteLine();

                if (part != "*")
                {
                    Regex re4 = new Regex($"^.*{part}.*$", RegexOptions.IgnoreCase);
                    int j = 1;
                    cCount = 0;

                    for (int i = 0; i < cities.Length; i++)

                        if (re4.IsMatch(cities[i]))
                        {
                            cCount++;
                            contains.Append($"{j}.{cities[i]}; ");
                            j++;

                        }
                    Console.WriteLine($"There are {cCount} cities containing \"{part}\":");
                    Console.WriteLine(contains);
                    Console.WriteLine();
                    contains = new StringBuilder();
                }
                else if (part == "*")
                {
                    menuPart = false;
                }
            } while (menuPart);
            break;

        case "*":
            Console.WriteLine("Bye!");
            menuOn=false;
            break;

        default:
            Console.WriteLine("Invalid choice. Try again!");
            Console.WriteLine();
            break;


    }
} while (menuOn);







