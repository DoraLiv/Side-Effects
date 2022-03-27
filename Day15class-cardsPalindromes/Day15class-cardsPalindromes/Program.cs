// See https://aka.ms/new-console-template for more information
/*
using System.Text.RegularExpressions;

Console.WriteLine($"===Palindromes===");

Console.WriteLine($"Write your sentence:");
string sentence1 = Console.ReadLine().ToLower();
Regex nospaces = new Regex("[a-zA-Z]");
string sentence1nospace = string.Empty;   
for (int i = 0; i < sentence1.Length; i++)
{
    if (nospaces.IsMatch(sentence1[i].ToString()))
    {
        sentence1nospace += sentence1[i];

    }
}
string sentence1reversed = string.Empty;
bool ispalindrome;
for (int i = sentence1nospace.Length-1; i >=0 ; i--)
{
    sentence1reversed += sentence1nospace[i];
}

ispalindrome = sentence1nospace.Equals(sentence1reversed);
Console.WriteLine(sentence1reversed);
Console.WriteLine($"You have entered a palindrome: {ispalindrome}");
*/


/*
Console.WriteLine($"===Cards===");

    public enum Suits
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }
    public enum CardValues
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public class cards
    {
        static public void Shuffle(string[] cardPack)
        {
            Random rnd = new Random();
            for (int i = cardPack.Length-1; i>0; --i)
            {
                int k = rnd.Next(i+1);
                string temp = cardPack[i];
                cardPack[i] = cardPack[k];
                cardPack[k] = temp;
            }

        }
        static void Main(string[] args)
        {
            string[] cardPack = new string[52];
            int position = 0;
            foreach (string suit in Enum.GetNames(typeof(Suits)))
            {
                foreach (string values in Enum.GetNames(typeof(CardValues)))
                {
                    cardPack[position] = $"{values} of {suit}";
                    position++;
                }
            }
            Console.WriteLine($"The first card is {cardPack[0]}");
            Shuffle(cardPack);
            for (int i = 0; i <6; i++)    //getting random 6 cards
            {
                Console.Write($"{cardPack[i]}");
            }
        }
    }
*/

