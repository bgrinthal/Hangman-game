﻿// using System;
// using System.Collections.Generic;
// using static System.Random;
// using System.Text;

// namespace HangmanGame
// {
//     class Program
//     {
//         private static void printHangman(int wrong)
//         {
//             if (wrong == 0)
//             {
//                 Console.WriteLine("\n+---+");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("   ===");
//                 Console.Write("you have 6 guesses");
//             }
//             else if (wrong == 1)
//             {
//                 Console.WriteLine("\n+---+");
//                 Console.WriteLine("O   |");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("   ===");
//                 Console.Write("You have 5 guesses left");
//             }
//             else if (wrong == 2)
//             {
//                 Console.WriteLine("\n+---+");
//                 Console.WriteLine("O   |");
//                 Console.WriteLine("|   |");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("   ===");
//                 Console.Write("You have 4 guesses left");
//             }
//             else if (wrong == 3)
//             {
//                 Console.WriteLine("\n+---+");
//                 Console.WriteLine(" O  |");
//                 Console.WriteLine("/|  |");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("   ===");
//                 Console.Write("You have 3 guesses left");
//             }
//             else if (wrong == 4)
//             {
//                 Console.WriteLine("\n+---+");
//                 Console.WriteLine(" O  |");
//                 Console.WriteLine("/|\\ |");
//                 Console.WriteLine("    |");
//                 Console.WriteLine("   ===");
//                 Console.Write("You have 2 guesses left");
//             }
//             else if (wrong == 5)
//             {
//                 Console.WriteLine("\n+---+");
//                 Console.WriteLine(" O  |");
//                 Console.WriteLine("/|\\ |");
//                 Console.WriteLine("/   |");
//                 Console.WriteLine("   ===");
//                 Console.Write("You have 1 guesse left");
//             }
//             else if (wrong == 6)
//             {
//                 Console.WriteLine("\n+---+");
//                 Console.WriteLine(" O   |");
//                 Console.WriteLine("/|\\  |");
//                 Console.WriteLine("/ \\  |");
//                 Console.WriteLine("    ===");
//                 Console.Write("Game Over");
//             }
//         }

//         // List<char>guessedLetters represents list of objects called "guessedLetters", with the type "char" (A, B, C, D, etc.)
//         private static int printWord(List<char> guessedLetters, String randomWord)
//         {
//             // counter to iterate through random word
//             int counter = 0;
//             // number of correctly guessed letteres
//             int rightLetters = 0;
//             // spacing
//             Console.Write("\r\n");
//             // iterates through each character "c" inside randomWord string
//             foreach (char c in randomWord)
//             {
//                 //  checks if the character in randomWord is inside guessedLetters
//                 if(guessedLetters.Contains(c))
//                 {
//                     Console.Write(c + " ");
//                     rightLetters += 1;
//                 }
//                 else
//                 {
//                     Console.Write(" ");
//                 }
//                 counter += 1;
//             }
//             return rightLetters;
//         }

//         // prints lines below words for "empty" letters not guessed yet
//         private static void printLines(String randomWord)
//         {
//             // spacing
//             Console.Write("\r");
//             foreach(char c in randomWord)
//             {
//                 // Allows console to encode Unicode characterse listed in the line below
//                 Console.OutputEncoding = System.Text.Encoding.Unicode;
//                 // print overline character 
//                 Console.Write("\u0305 ");
//             }
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to hangman :");
//             Console.WriteLine("----------------------------------------------");

//             // Use random built in class to create another instance of it
//             Random random = new Random();
//             // create a list of words containing the following
//             List<string> wordDictionary = new List<string> { "celebration", "understand", "vegetarian", "transition", "exception", "candidate", "negligence", "difficulty", "treatment" };

//             // generate random number between 0 and number of words in wordDictionary, then assigns that word to randomWord
//             int index = random.Next(wordDictionary.Count);
//             String randomWord = wordDictionary[index];

//             // Print dashed lines that make up the word
//             foreach (char c in randomWord)
//             {
//                 Console.Write("_ ");
//             }

//             // Some necessary variables
//             int lengthOfWordToGuess = randomWord.Length;
//             int amountOfTimesWrong = 0;
//             List<char> currentLettersGuessed = new List<char>();
//             int currentLettersRight = 0;

//             // Displays previously guessed letters while game is still going
//             while(amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess)
//             {
//                 Console.Write("\nLetters guessed so far: ");
//                 foreach(char letter in currentLettersGuessed)
//                 {
//                     Console.Write(letter + " ");
//                 }
//                 // Prompt user to guess a letter
//                 Console.Write("\nGuess a letter: ");
//                 char letterGuessed = Console.ReadLine()[0];
//                 // Check if letter has already been guessed
//                 if(currentLettersGuessed.Contains(letterGuessed))
//                 {
//                     Console.Write("\r\nYou have already guessed this letter");
//                     printHangman(amountOfTimesWrong);
//                     currentLettersRight = printWord(currentLettersGuessed, randomWord);
//                     printLines(randomWord);
//                 }
//                 else
//                 {
//                     // Check if guessed letter is in the word
//                     bool right = false;
//                     for(int i = 0; i < randomWord.Length; i++){
//                         if(letterGuessed == randomWord[i]){ right = true;}

//                         if(right)
//                         {
//                             // Prints hangman with no wrong ansers
//                             printHangman(amountOfTimesWrong);
//                             //  Adds current guessed letter to out list of letters guessed
//                             currentLettersGuessed.Add(letterGuessed);
//                             //  sets current correct letters
//                             currentLettersRight = printWord(currentLettersGuessed, randomWord);
//                             Console.Write("\r\n");
//                             printLines(randomWord);
//                         }
//                         else
//                         {
//                             amountOfTimesWrong += 1;
//                             currentLettersGuessed.Add(letterGuessed);
//                             printHangman(amountOfTimesWrong);
//                             currentLettersRight = printWord(currentLettersGuessed, randomWord);
//                             Console.Write("\r\n");
//                             printLines(randomWord);
//                         }
//                     }
//                 }
//                 Console.WriteLine("\r\nGame is over!  Thanks for playing!");
//             }
//         }
//     }
// }

using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace HangmanGame
{
    internal class Program
    {
        // Prints out hangman for each guess
        private static void printHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine("    ===");
            }
        }
        // List<char>guessedLetters represents list of objects called "guessedLetters", with the type "char" (A, B, C, D, etc.)
        private static int printWord(List<char> guessedLetters, String randomWord)
        {
            // counter to iterate through random words
            int counter = 0;
            // tracks the number of correct letters guessed
            int rightLetters = 0;
            // spacing
            Console.Write("\r\n");
            // iterates through each character "c" inside randomWord string
            foreach (char c in randomWord)
            {
                // Checks if character c in guessed letter is in the random word
                if (guessedLetters.Contains(c))
                {
                    // if yes, display and incriment number of correct letters
                    Console.Write(c + " ");
                    rightLetters += 1;
                }
                else
                {
                    // if wrong, display nothing
                    Console.Write("  ");
                }
                counter += 1;
            }
            //Console.Write("\r\n");
            return rightLetters;
        }

        // prints lines below words for "empty" letters not guessed yet
        private static void printLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                // Allows console to encode Unicode character listed in the line below
                // Console.OutputEncoding = System.Text.Encoding.Unicode;
                // Print that character
                Console.Write("- ");
            }
        }

        // bool IsAllAlphabetic(string value)
        // {
        //     foreach (char c in value)
        //     {
        //         if (!char.IsLetter(c))
        //             return false;
        //     }

        //     return true;
        // }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman :)");
            Console.WriteLine("-----------------------------------------");

            while (true)
            {
                // Use random built in class to create another instance of it
                Random random = new Random();
                // create a list of words containing the following
                List<string> wordDictionary = new List<string> { "CELEBRATION", "UNDERSTAND", "VEGETARIAN", "TRANSITION", "EXCEPTION", "CANDIDATE", "NEGLIGENCE", "DIFFICULTY", "TREATMENT" };

                // generate random number between 0 and number of words in wordDictionary, then assigns that word to randomWord
                int index = random.Next(wordDictionary.Count);
                String randomWord = wordDictionary[index];

                // Print dashed lines that make up the word
                foreach (char x in randomWord)
                {
                    Console.Write("_ ");
                }

                int lengthOfWordToGuess = randomWord.Length;
                int amountOfTimesWrong = 0;
                List<char> currentLettersGuessed = new List<char>();
                int currentLettersRight = 0;

                // Displays previously guessed letters while game is still going
                while (amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess)
                {
                    Console.Write("\nLetters guessed so far: ");
                    foreach (char letter in currentLettersGuessed)
                    {
                        Console.Write(letter + " ");
                    }
                    // Prompt user to guess a letter
                    Console.Write("\nGuess a letter: ");
                    char letterGuessed = Console.ReadLine().ToUpper()[0];

                    if(Char.IsLetter(letterGuessed) == false)
                    {
                        Console.WriteLine("Must be a letter (a-z).  Guess again");
                    }
                    else
                    {
                        // Check if that letter has already been guessed
                        if (currentLettersGuessed.Contains(letterGuessed))
                        {
                            Console.Write("\r\n You have already guessed this letter");
                            printHangman(amountOfTimesWrong);
                            currentLettersRight = printWord(currentLettersGuessed, randomWord);
                            printLines(randomWord);
                        }
                        else
                        {
                            // Check if guessed letter is in the randomWord
                            bool right = false;
                            for (int i = 0; i < randomWord.Length; i++) { if (letterGuessed == randomWord[i]) { right = true; } }

                            // User is right
                            if (right)
                            {
                                // Prints hangman with no wrong ansers
                                printHangman(amountOfTimesWrong);
                                //  Adds current guessed letter to out list of letters guessed and displays
                                currentLettersGuessed.Add(letterGuessed);
                                //  Sets current correct letters
                                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                                Console.Write("\r\n");
                                printLines(randomWord);
                            }
                            // User was wrong af
                            else
                            {
                                amountOfTimesWrong += 1;
                                currentLettersGuessed.Add(letterGuessed);
                                // Update the drawing
                                printHangman(amountOfTimesWrong);
                                // Print word
                                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                                Console.Write("\r\n");
                                printLines(randomWord);
                            }
                        }
                    }
                    
                }
                // End game, ask to play again
                Console.WriteLine("\r\nGame is over! Play again?... [Y]/[N]");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }
                else if (playAgain == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }
    }
}