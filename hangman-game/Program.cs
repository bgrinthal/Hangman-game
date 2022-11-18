using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace HangmanGame
{
    class Program
    {
        private static void printHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.Write("you have 6 guesses");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.Write("You have 5 guesses left");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.Write("You have 4 guesses left");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.Write("You have 3 guesses left");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.Write("You have 2 guesses left");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
                Console.Write("You have 1 guesse left");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine("    ===");
                Console.Write("Game Over");
            }
        }

        // List<char>guessedLetters represents list of objects called "guessedLetters", with the type "char" (A, B, C, D, etc.)
        private static int printWord(List<char>guessedLetters, String randomWord)
        {
            // counter to iterate through random word
            int counter = 0;
            // number of correctly guessed letteres
            int rightLetters = 0;
            // spacing
            Console.Write("\r\n");
            // iterates through each character "c" inside randomWord string
            foreach (Char c in randomWord)
            {
                //  checks if the character in randomWord is inside guessedLetters
                if(guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetters;
        }

        // prints lines below words for "empty" letters not guessed yet
        private static void pringLines(String randomWord)
        {
            // spacing
            Console.Write("\r");
            foreach(char c in randomWord)
            {
                // Allows console to encode Unicode characterse listed in the line below
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                // print overline character 
                Console.Write("\u0305");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman!");
            Console.Write("----------------------------------------------");

            // Use random built in class to create another instance of it
            Random random = new Random();
            // create a list of words containing the following
            List<string> wordDictionary = new List<string> { "celebration", "understand", "vegetarian", "transition", "exception", "candidate", "negligence", "difficulty", "treatment" };

            // generate random number between 0 and number of words in wordDictionary, then assigns that word to randomWord
            int index = random.Next(wordDictionary.Count);
            String randomWord = wordDictionary[index];

            // Print dashed lines that make up the word
            foreach (char c in randomWord)
            {
                Console.Write("_ ");
            }

            int lengthOfWordToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;
        }
    }
}