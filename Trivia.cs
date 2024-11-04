using Midterm.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantShop
{
    public class Trivia
    {
        public static void RunTrivia()
        {
            Console.Clear();

            string prompt = "Welcome, brave soul. Are you ready to try your luck at some coins?";

            string[] options = { "YES", "NO" };
            Menu TriviaMenu = new Menu(prompt, options);
            int selectedIndex = TriviaMenu.Run();

            switch (selectedIndex)
            {
                case 0:

                    Console.Clear();
                    Console.WriteLine("Very well.");
                    Keys.WaitForKey();
                    Console.Clear();
                    Console.WriteLine("The premise is simple. Answer each question to the best of your ability.");
                    Console.WriteLine("\nShould you answer correctly, you'll recieve a coin.");
                    Console.WriteLine("\nShould you not, however..you lose them.");
                    Console.WriteLine("\nDo note: Just because there are 4 questions does not mean you only need 4 coins. Repeat as you deem fit.");
                    Console.WriteLine("\nDo the EXACT spelling and you only need 8 coins. This is only a midterm.");
                    Keys.WaitForKey();


                    Console.Clear();
                    Console.WriteLine($"\nCoins: {Game.hasCoins}");
                    Console.WriteLine("\nQuestion 1: Approximately how old is the Universe?");
                    Console.WriteLine("\nAnswers: 13.7 Billion years old OR 20 Billion years old");
                    Console.WriteLine("\nPlease enter your answer:");

                    string triviaResponse = Console.ReadLine();
                    if (triviaResponse == "13.7 Billion years old")
                    {
                        Console.WriteLine("\nThat's correct!");
                        Game.hasCoins++;
                    }

                    else
                    {
                        Console.WriteLine("\n20 Billion reasons for you to open a book. No.");
                        Game.hasCoins--;
                    }
                    Keys.WaitForKey();

                    Console.Clear();
                    Console.WriteLine($"\nCoins: {Game.hasCoins}");
                    Console.WriteLine("\nQuestion 2: What is the largest mammal in the world?");
                    Console.WriteLine("\nAnswers: Shark OR Blue Whale");
                    Console.WriteLine("\nPlease enter your answer:");
                    triviaResponse = Console.ReadLine();
                    if (triviaResponse == "Blue Whale")
                    {
                        Console.WriteLine("\nYes!");
                        Game.hasCoins++;
                    }
                    else
                    {
                        Console.WriteLine("\nShark bait, hoo ha ha! No.");
                        Game.hasCoins--;
                    }
                    Keys.WaitForKey();

                    Console.Clear();
                    Console.WriteLine($"\nCoins: {Game.hasCoins}");
                    Console.WriteLine("\nQuestion 3: Who painted the Mona Lisa?");
                    Console.WriteLine("\nAnswers: Van Gough OR da Vinci");
                    Console.WriteLine("\nPlease enter your answer:");
                    triviaResponse = Console.ReadLine();
                    if (triviaResponse == "da Vinci")
                    {
                        Console.WriteLine("\nGreat job!");
                        Game.hasCoins++;
                    }
                    else 
                    {
                        Console.WriteLine("\nGough........back to school because no.");
                        Game.hasCoins--;
                    }
                    Keys.WaitForKey();

                    Console.Clear();
                    Console.WriteLine($"\nCoins: {Game.hasCoins}");
                    Console.WriteLine("\nQuestion 4: Which planet is known as the \"Blue Planet\"?");
                    Console.WriteLine("\nAnswers: Neptune OR Earth");
                    Console.WriteLine("\nPlease enter your answer:");
                    triviaResponse = Console.ReadLine();
                    if (triviaResponse == "Earth")
                    {
                        Console.WriteLine("\nGreat job!");
                        Game.hasCoins++;
                    }
                    else
                    {
                        Console.WriteLine("\nHonestly......I would've picked this too. But no.");
                        Game.hasCoins--;
                    }
                    Keys.WaitForKey();

                    Console.Clear();
                    Console.WriteLine($"\nFinal coin count for this run: {Game.hasCoins}.");
                    Console.WriteLine("\nContinue fourth to decide if you shall try again or return home.");
                    Keys.WaitForKey();
                    RunTrivia();
                    break;
                case 1:
                    Console.WriteLine("\nMay we see you another time then.");
                    Keys.WaitForKey();
                    Game.RunMainMenu();
                    break;
            }


            Console.ReadLine();
        }
    }

    
    
}
