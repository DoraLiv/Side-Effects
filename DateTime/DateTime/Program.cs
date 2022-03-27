// See https://aka.ms/new-console-template for more information
DateTime start = DateTime.Now;
int count1 = 0; //number of times option1 is picked
int count2 = 0; //number of times option2 is picked
int count3 = 0; //number of times option3 is picked
int countall = 0; //total number of answers 

bool survey = true;
do
{
    Console.WriteLine("Enter your birthday:");
    Console.WriteLine("Date: ");
    string day = Console.ReadLine();
    Console.WriteLine("Month: ");
    string month = Console.ReadLine();
    Console.WriteLine("Year: ");
    string year = Console.ReadLine();
    string bday = $"{year}-{month}-{day}";
    //bday.ToString(yyyy-mm-dd);

    Console.WriteLine($"Your birthday is {bday}");

    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - option1");
    Console.WriteLine("2 - option2");
    Console.WriteLine("3 - option3");
    Console.WriteLine("* - exit app");
    char.TryParse(Console.ReadLine(), out char choice);

    if (choice == '*')
    {
        survey = false;
    }
    else if (choice != '*')
    {
        countall++;
        switch (choice)
        {
            case '1':
                Console.WriteLine("You chose option 1.");
                count1++;
                
                break;

            case '2':
                Console.WriteLine("You chose option 2.");
                count2++;
                break;

            case '3':
                Console.WriteLine("You chose option 3.");
                count3++;
                break;

            default:
                break;

        }
    }

} while (survey);
DateTime stop = DateTime.Now;
Console.WriteLine($"Total number of answers: {countall}");
Console.WriteLine($"Number of option 1 votes: {count1}");
Console.WriteLine($"Number of option 1 votes: {count2}");
Console.WriteLine($"Number of option 1 votes: {count3}");
Console.WriteLine($"Time survey started: {start}");
Console.WriteLine($"Time survey finished: {stop}");