// See https://aka.ms/new-console-template for more information
//Day 11 Practical
/*
Console.WriteLine("TASK 1: Enter numbers until sum of all numbers is larger than 100!");

int sum = 0;
do
{
    Console.WriteLine($"Please enter a number:");
    int.TryParse(Console.ReadLine(), out int value);
    sum += value;
    Console.WriteLine($"The current sum is {sum}");
} while (sum <= 100);
Console.WriteLine($" The sum {sum} > 100, you have reached the end!");
*/


Console.WriteLine("TASK 2: Number guessing game! Guess 3 numbers from 1 to 10");

int[] answer = new int[3];
answer[0] = 4;
answer[1] = 2;
answer[2] = 9;

int[] guess = new int[3];
bool game = true;

while (game)
{//can be written outside the loop as well - then it will appear only at the beginning
    Console.WriteLine("Enter a number 1-10:");
    int.TryParse(Console.ReadLine(), out int numbers);
    switch (numbers)
    {
        case 4:
            Console.WriteLine("You are correct!");
            int guess1 = numbers;
            guess[0] = guess1;
            break;
        case 2:
            Console.WriteLine("You are correct!");
            int guess2 = numbers;
            guess[1] = guess2;
            break;
        case 9:
            Console.WriteLine("You are correct!");
            int guess3 = numbers;
            guess[2] = guess3;
            break;
        default:
            Console.WriteLine("You are wrong!");
            break;
    }
    Console.WriteLine($"You have correctly guessed {guess[0]} {guess[1]} {guess[2]}");
    bool isEqual = Enumerable.SequenceEqual(guess, answer);
    if (isEqual == true)
    {
        game = false;
        Console.WriteLine("Congrats! You won!");
    }
}
