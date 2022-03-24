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
StringBuilder combo1 = new StringBuilder();
StringBuilder combo2 = new StringBuilder();

int cCount = 0;
bool menuOn = true;

do
{
    Console.WriteLine("Please choose the search parameter or parameters");
    Console.WriteLine("1 Search by first letter");
    Console.WriteLine("2 Search by last letter");
    Console.WriteLine("3 search by the number of letters");
    Console.WriteLine("4 search by partial match");
    Console.WriteLine("1,2 search by first and last letter");
    Console.WriteLine("1,2,3 search by first and last letter and number of letters");
    Console.WriteLine("* quit search\n");
    string choice = Console.ReadLine();
    Console.WriteLine();
    switch (choice)
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
                    cCount=0;
                    char first = firstletter [0];
                    for (int i = 0; i < cities.Length; i++)
                    {
                        int j = 1;
                        var cityName = cities[i];
                        if (cityName[0] == first)
                        {
                            Console.WriteLine(cityName);
                            starts.Append($"{j}.{cities[i]}; ");
                            cCount++;
                        }
                        
                    }   
                    Console.WriteLine($"There are {cCount} cities starting with \"{first}\":");
                    Console.WriteLine(starts);
                    /*
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
                    */
                    /*Console.WriteLine($"There are {cCount} cities starting with \"{first}\":");
                    Console.WriteLine(starts); 
                    Console.WriteLine();
                    starts = new StringBuilder();*/
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

        case "1,2":
            bool menucombo2 = true;
            do
            {
                Console.WriteLine("Please insert the first letter:");
                Console.WriteLine("Type * to return to main menu");
                Console.WriteLine();
                string firstletter3 = Console.ReadLine();
                if (firstletter3 == "*")
                {
                    menucombo2=false;
                }
                else if (firstletter3 != "*")
                {
                    Console.WriteLine("Please insert the last letter:");
                    Console.WriteLine("Type * to return to main menu");
                    Console.WriteLine();
                    string lastletter3 = Console.ReadLine();
                    Console.WriteLine();
                    if (lastletter3 == "*")
                    {
                        menucombo2=false;
                    }
                    else if (lastletter3 !="*")
                    {
                            char first3 = firstletter3[0];
                            char last3 = lastletter3[0];
                            Regex re6 = new Regex($"^{first3}.*{last3}$", RegexOptions.IgnoreCase);
                            int j = 1;
                            cCount = 0;

                            for (int i = 0; i < cities.Length; i++)

                                if (re6.IsMatch(cities[i]))
                                {
                                    cCount++;
                                    combo2.Append($"{j}.{cities[i]}; ");
                                    j++;

                                }
                            Console.WriteLine($"There are {cCount} cities starting with \"{first3}\", ending with \"{last3}\":");
                            Console.WriteLine(combo2);
                            Console.WriteLine();
                            combo2 = new StringBuilder();
                    }
                     

                }
            } while (menucombo2);
            break;

        case "1,2,3":
            bool menucombo1 = true;
            do
            {
                Console.WriteLine("Please insert the first letter:");
                Console.WriteLine("Type * to return to main menu");
                Console.WriteLine();
                string firstletter2 = Console.ReadLine();
                if (firstletter2 == "*")
                {
                    menucombo1=false;
                }
                else if (firstletter2 != "*")
                { 
                        Console.WriteLine("Please insert the last letter:");
                        Console.WriteLine("Type * to return to main menu");
                        Console.WriteLine();
                        string lastletter2 = Console.ReadLine();
                        Console.WriteLine();
                        if (lastletter2 == "*")
                        {
                            menucombo1=false;
                        }
                        else if (lastletter2 !="*")
                        {
                            Console.WriteLine("Enter number of letters:");
                            Console.WriteLine("Type * to return to main menu");
                         Console.WriteLine();
                            string letters2 = Console.ReadLine();
                            Console.WriteLine();

                            if (letters2 != "*")
                            {
                                char first2 = firstletter2[0];
                                char last2 = lastletter2[0];
                                int.TryParse((letters2), out int number2);
                                Regex re5 = new Regex($"^{first2}[a-z]{{{number2-2}}}{last2}$", RegexOptions.IgnoreCase);
                                int j = 1;
                                cCount = 0;

                                for (int i = 0; i < cities.Length; i++)

                                if (re5.IsMatch(cities[i]))
                                {
                                    cCount++;
                                    combo1.Append($"{j}.{cities[i]}; ");
                                    j++;

                                }
                            Console.WriteLine($"There are {cCount} cities starting with \"{first2}\", ending with \"{last2}\" and containing exactly {letters2} letters:");
                            Console.WriteLine(combo1);
                            Console.WriteLine();
                            combo1 = new StringBuilder();
                        }
                        else if (letters2 == "*")
                        {
                            menucombo1 = false;
                        }
                        }
                        
                }
            } while (menucombo1);
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







