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
                // Print that character
                if (c.ToString() == " ")
                {
                    Console.Write("  ");
                }
                else if (c.ToString() == ":")
                {
                    Console.Write(": ");
                }
                else if (c.ToString() == "-")
                {
                    Console.Write("- ");
                }
                else if (c.ToString() == "?")
                {
                    Console.Write("? ");
                }
                else if (c.ToString() == ".")
                {
                    Console.Write(". ");
                }
                else if (c.ToString() == ",")
                {
                    Console.Write(", ");
                }
                else if (c.ToString() == "'")
                {
                    Console.Write("' ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman :)");
            Console.WriteLine("-----------------------------------------");

            while (true)
            {
                // Use random built in class to create another instance of it
                Random random = new Random();
                // create a list of words containing the following
                // TODO: Put movie titles in another file to simplify code
                List<string> wordDictionary = new List<string> { "The, Shawshank. Re-demption",
  "The Godfather",
  "The Godfather: Part II",
  "The Dark Knight",
  "Schindler's List",
  "Pulp Fiction",
  "The Lord of the Rings: The Return of the King",
  "The Good, the Bad and the Ugly",
  "Fight Club",
  "The Lord of the Rings: The Fellowship of the Ring",
  "Forrest Gump",
  "Star Wars: Episode V - The Empire Strikes Back",
  "Inception",
  "The Lord of the Rings: The Two Towers",
  "One Flew Over the Cuckoo's Nest",
  "Goodfellas",
  "The Matrix",
  "Seven Samurai",
  "Star Wars: Episode IV - A New Hope",
  "City of God",
  "The Silence of the Lambs",
  "It's a Wonderful Life",
  "Life Is Beautiful",
  "The Usual Suspects",
  "Léon: The Professional",
  "Saving Private Ryan",
  "Spirited Away",
  "American History X",
  "Once Upon a Time in the West",
  "Interstellar",
  "Psycho",
  "The Green Mile",
  "Casablanca",
  "City Lights",
  "The Intouchables",
  "Modern Times",
  "Raiders of the Lost Ark",
  "The Pianist",
  "The Departed",
  "Rear Window",
  "Back to the Future",
  "Whiplash",
  "Gladiator",
  "The Prestige",
  "The Lion King",
  "Memento",
  "Apocalypse Now",
  "Alien",
  "The Great Dictator",
  "Sunset Boulevard",
  "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb",
  "Cinema Paradiso",
  "The Lives of Others",
  "Grave of the Fireflies",
  "Paths of Glory",
  "Django Unchained",
  "The Shining",
  "WALL-E",
  "American Beauty",
  "The Dark Knight Rises",
  "Princess Mononoke",
  "Oldboy",
  "Aliens",
  "Witness for the Prosecution",
  "Once Upon a Time in America",
  "Das Boot",
  "Citizen Kane",
  "Dangal",
  "Vertigo",
  "North by Northwest",
  "Star Wars: Episode VI - Return of the Jedi",
  "Braveheart",
  "Reservoir Dogs",
  "Requiem for a Dream",
  "Amélie",
  "Like Stars on Earth",
  "A Clockwork Orange",
  "Your Name",
  "Lawrence of Arabia",
  "Dunkirk",
  "Double Indemnity",
  "Amadeus",
  "Taxi Driver",
  "Eternal Sunshine of the Spotless Mind",
  "To Kill a Mockingbird",
  "Full Metal Jacket",
  "Singin' in the Rain",
  "The Sting",
  "Toy Story",
  "Bicycle Thieves",
  "Inglourious Basterds",
  "The Kid",
  "Snatch",
  "Monty Python and the Holy Grail",
  "Good Will Hunting",
  "For a Few Dollars More",
  "The Hunt",
  "L.A. Confidential",
  "Scarface",
  "The Apartment",
  "Metropolis",
  "Rashomon",
  "A Separation",
  "Indiana Jones and the Last Crusade",
  "My Father and My Son",
  "Yojimbo",
  "All About Eve",
  "Batman Begins",
  "Some Like It Hot",
  "The Treasure of the Sierra Madre",
  "Unforgiven",
  "Downfall",
  "Die Hard",
  "Raging Bull",
  "Children of Heaven",
  "The Third Man",
  "The Great Escape",
  "Chinatown",
  "Ikiru",
  "Pan's Labyrinth",
  "My Neighbor Totoro",
  "The Gold Rush",
  "Inside Out",
  "Incendies",
  "The Secret in Their Eyes",
  "On the Waterfront",
  "Judgment at Nuremberg",
  "The Bridge on the River Kwai",
  "Howl's Moving Castle",
  "Blade Runner",
  "The Seventh Seal",
  "Lock, Stock and Two Smoking Barrels",
  "Mr. Smith Goes to Washington",
  "Casino",
  "A Beautiful Mind",
  "The Elephant Man",
  "Wild Strawberries",
  "V for Vendetta",
  "The Wolf of Wall Street",
  "The General",
  "Warrior",
  "Trainspotting",
  "Dial M for Murder",
  "Andrei Rublev",
  "Gran Torino",
  "Sunrise",
  "Gone with the Wind",
  "The Deer Hunter",
  "The Bandit",
  "Fargo",
  "The Sixth Sense",
  "La La Land",
  "The Thing",
  "The Big Lebowski",
  "No Country for Old Men",
  "Finding Nemo",
  "Tokyo Story",
  "Hacksaw Ridge",
  "Cool Hand Luke",
  "There Will Be Blood",
  "Rebecca",
  "Come and See",
  "Rang De Basanti",
  "The Passion of Joan of Arc",
  "Kill Bill: Vol. 1",
  "How to Train Your Dragon",
  "Logan",
  "Mary and Max",
  "Gone Girl",
  "Into the Wild",
  "Shutter Island",
  "A Wednesday",
  "It Happened One Night",
  "Life of Brian",
  "Wild Tales",
  "Platoon",
  "The Wages of Fear",
  "Hotel Rwanda",
  "Network",
  "Rush",
  "In the Name of the Father",
  "Stand by Me",
  "Persona",
  "The Grand Budapest Hotel",
  "Mad Max: Fury Road",
  "Memories of Murder",
  "Spotlight",
  "Million Dollar Baby",
  "Jurassic Park",
  "Butch Cassidy and the Sundance Kid",
  "Stalker",
  "Amores Perros",
  "The Truman Show",
  "The Maltese Falcon",
  "Hachi: A Dog's Tale",
  "Nausicaä of the Valley of the Wind",
  "Paper Moon",
  "The Princess Bride",
  "The Nights of Cabiria",
  "Before Sunrise",
  "Prisoners",
  "Harry Potter and the Deathly Hallows: Part 2",
  "The Grapes of Wrath",
  "Rocky",
  "Catch Me If You Can",
  "Diabolique",
  "Touch of Evil",
  "Gandhi",
  "Star Wars: The Force Awakens",
  "Donnie Darko",
  "Monsters, Inc.",
  "Annie Hall",
  "The Terminator",
  "Barry Lyndon",
  "The Bourne Ultimatum",
  "Sholay",
  "The Wizard of Oz",
  "Groundhog Day",
  "Twelve Monkeys",
  "The Best Years of Our Lives",
  "Infernal Affairs",
  "Paris, Texas",
  "The Help",
  "In the Mood for Love",
  "Beauty and the Beast",
  "The Battle of Algiers",
  "Dog Day Afternoon",
  "Pirates of the Caribbean: The Curse of the Black Pearl",
  "Gangs of Wasseypur",
  "The Handmaiden",
  "What Ever Happened to Baby Jane?"
  };

                // generate random number between 0 and number of words in wordDictionary, then assigns that word to randomWord
                int index = random.Next(wordDictionary.Count);
                String randomWord = wordDictionary[index].ToUpper();

                // Print dashed lines that make up the word
                foreach (char x in randomWord)
                {
                    //  Checks for spaces, periods, dashes, and other symbols to display
                    if (x.ToString() == " ")
                    {
                        Console.Write("  ");
                    }
                    else if (x.ToString() == ":")
                    {
                        Console.Write(": ");
                    }
                    else if (x.ToString() == "-")
                    {
                        Console.Write("- ");
                    }
                    else if (x.ToString() == "?")
                    {
                        Console.Write("? ");
                    }
                    else if (x.ToString() == ".")
                    {
                        Console.Write(". ");
                    }
                    else if (x.ToString() == ",")
                    {
                        Console.Write(", ");
                    }
                    else if (x.ToString() == "'")
                    {
                        Console.Write("' ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }

                int lengthOfWordToGuess = randomWord.Length;
                int amountOfTimesWrong = 0;
                List<char> currentLettersGuessed = new List<char>();
                int currentLettersRight = 0;
                int randomWordSymbols = (randomWord.Split(' ').Length - 1) + (randomWord.Split(':').Length - 1) + (randomWord.Split(',').Length - 1) + (randomWord.Split("'").Length - 1) + (randomWord.Split('?').Length - 1) + (randomWord.Split('.').Length - 1);

                // Displays previously guessed letters while game is still going
                //  Adds currentLetterRight point for every space, to bypass bug of not needing to enter spaces
                while (amountOfTimesWrong != 6 && currentLettersRight + randomWordSymbols != lengthOfWordToGuess)
                {
                    Console.Write("\nLetters guessed so far: ");
                    foreach (char letter in currentLettersGuessed)
                    {
                        Console.Write(letter + " ");
                    }
                    // Prompt user to guess a letter
                    Console.Write("\nGuess a letter: ");
                    char letterGuessed = Console.ReadLine().ToUpper()[0];

                    // Check if input letter is a character from A-Z and not a number or symbol
                    if (Char.IsLetter(letterGuessed) == false)
                    {
                        Console.WriteLine("\nMust be a letter (a-z).  Guess again");
                    }
                    else
                    {
                        // Check if that letter has already been guessed
                        if (currentLettersGuessed.Contains(letterGuessed))
                        {
                            Console.Write("\r\n You have already guessed this letter");
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
                            // User was wrong
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
                if (amountOfTimesWrong == 6)
                {
                    // End game if word not guessed, displays and asks to play again
                    Console.WriteLine("\r\nGame is over! The word was " + randomWord);
                    Console.WriteLine("\r\nPlay again ? ... [Y] /[N]");
                    string playAgain = Console.ReadLine().ToUpper();
                    // TODO: gameOver(playAgain);  <- turn ito owm method to simplify
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
                else
                {
                    // End game if word is guesed, ask to play again
                    Console.WriteLine("\r\nCongrats, you got it!");
                    Console.WriteLine("\r\nPlay again ? ... [Y] /[N]");
                    string playAgain = Console.ReadLine().ToUpper();
                    // TODO: gameOver(playAgain);  <- turn ito owm method to simplify
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
}