using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            LetterCounter('i', "I Love biscuts and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            TextStats("People are awesome");
            Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            if (number == 0)
            {
                Console.WriteLine(number);
            }
            else if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        static void LetterCounter(char letter, string inString)
        {
            int lowerCount = 0;
            int upperCount = 0;
            int totalCount = 0;
            var coolArray = inString.Split(' ');
            var lowLetter = letter.ToString().ToLower();
            var upLetter = letter.ToString().ToUpper();
            for (int i = 0; i < inString.Length; i++)
			{
			    if(inString[i].ToString() == lowLetter)
	            {
		            lowerCount = lowerCount + 1;
                    totalCount = totalCount + 1;
	            }
                else if(inString[i].ToString() == upLetter)
                {
                    upperCount = upperCount + 1;
                    totalCount = totalCount + 1;
                }
			}
            Console.WriteLine();
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase: " + lowerCount);
            Console.WriteLine("Number of UPPERCASE: " + upperCount);
            Console.WriteLine("Number of the letter total: " + totalCount);


        }
        static void TextStats(string input)
        {
            Console.WriteLine();
            Console.WriteLine("In: " + input);
            string text = input;
            Console.WriteLine("There are " + text.Length + " characters in the string.");
            string[] wordArray = text.Split(' ');
            Console.WriteLine("There are " + wordArray.Length + " words in the string.");
            int vowels = 0;
            int specials = 0;
            int consonants = 0;
            var bigWord = "";
            var smallWord = "XXXXXXXXXXXX";
            for (var i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == "a" || text[i].ToString() == "e" || text[i].ToString() == "i" || text[i].ToString() == "o" || text[i].ToString() == "u")
                {
                    vowels = vowels + 1;
                }
                else if (text[i].ToString() == "." || text[i].ToString() == "?" || text[i].ToString() == "!" || text[i].ToString() == "," || text[i].ToString() == "'")
                {
                    specials = specials + 1;
                }
                else 
                {
                    consonants = consonants + 1;
                }
            }
            for (var i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i].Length > bigWord.Length) 
                {
                    bigWord = wordArray[i];
                }
            }
            for (var i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i].Length < smallWord.Length)
                {
                    smallWord = wordArray[i];
                }
            }

            Console.WriteLine("There are " + vowels + " vowels in the string.");
            Console.WriteLine("There are " + specials + " specials in the string.");
            Console.WriteLine("There are " + consonants + " consonants in the string.");
            Console.WriteLine("The biggest word is: " + bigWord);
            Console.WriteLine("The smallest word is: " + smallWord);

        }
    }
}
