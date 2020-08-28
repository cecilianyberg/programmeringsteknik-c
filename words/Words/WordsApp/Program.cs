using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar emot en skriven text.
            Console.WriteLine("Enter a string, prefferably ")
            char [] vowels = new char [] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' }

            string myTestString = "this is a test";
            string myLowercaseString = myTestString.ToLower();

            string[] words = myLowercaseString.Split(" "), StringSplitOptions.RemoveEmptyEntries);

            foreach (var character in myLowercaseString)
            {
                if (vowels.Contains(character))
                {

                }   
            }

            for (var i = 0; i < enteredString.LLenght; i++)

            Console.WriteLine("Word coaunt" + wordCount);
            Console.WriteLine(")


            // Vi vill ha ut följande:
            // Antal ord?
            // Antal vokaler?
            // Vilket är det längsta ordet?

            // Word count
            // Vowel count
            // Longest word

            
        }
    }
}
