using System.Numerics;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, stranger, type your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Add a number: ");
            string num = Console.ReadLine();
            Console.WriteLine($"Hello, {name}, you added number " + num + "!");


            string characterName = "Teppo the cat";
            int characterAge = 5;
            char letter = 'K';
            bool isAmazing = true;

            Console.WriteLine(" ");
            Console.WriteLine("Here is a story: ");
            Console.WriteLine(characterName + " was a happy cat, and he was " + characterAge + " years young.");
            characterName = "Seppo the dog";
            Console.WriteLine("Oh, but here comes " + characterName + ".\nHis favorite colour is red.");

            string favoritePhrase = "be happy";
            Console.WriteLine("How many letters in " + favoritePhrase.ToUpper() + "?");
            Console.WriteLine(favoritePhrase.Length);
            Console.WriteLine("Does it contain word 'sad'? " + favoritePhrase.Contains("Sad"));
            Console.WriteLine("What is the first letter of the phrase? " + favoritePhrase[0]);
            Console.WriteLine("and what is the indexs of letter 'h'? " + favoritePhrase.IndexOf("h"));

            Console.WriteLine(favoritePhrase.Substring(5, 1));


            //working with numbers

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(2, 360));
            Console.WriteLine(Math.Min(2, 360));
            Console.WriteLine(Math.Round(5.8));

            int number = Convert.ToInt32("45");
            Console.WriteLine(number + 6);
        }

    }
}
                                                                                                                                                                                                             