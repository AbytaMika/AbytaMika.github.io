using Midterm.Scenes;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Midterm;


// Fall 2024 Midterm Project
// Created by Mikaela Abeyta
// Class: PROG 101, Cameron Sintron 


namespace PlantShop
{
    class Game
    {

        public TitleScene AbeytaTitleScene;
        private string prompt;
        public static int hasCoins = 0;
        public Game()
        {
            AbeytaTitleScene = new TitleScene(this);
        }

        public void Start()
        {

            RunMainMenu();

            AbeytaTitleScene.Run();

        }
        public static void RunMainMenu()
        {
            string prompt = @"
.-------.   .---.        ____    ,---.   .--.,---------.    ,-----.    .-------. .-./`)    ____     
\  _(`)_ \  | ,_|      .'  __ `. |    \  |  |\          \ .'  .-,  '.  \  _(`)_ \\ .-.') .'  __ `.  
| (_ o._)|,-./  )     /   '  \  \|  ,  \ |  | `--.  ,---'/ ,-.|  \ _ \ | (_ o._)|/ `-' \/   '  \  \ 
|  (_,_) /\  '_ '`)   |___|  /  ||  |\_ \|  |    |   \  ;  \  '_ /  | :|  (_,_) / `-'`""`|___|  /  | 
|   '-.-'  > (_)  )      _.-`   ||  _( )_\  |    :_ _:  |  _`,/ \ _/  ||   '-.-'  .---.    _.-`   | 
|   |     (  .  .-'   .'   _    || (_ o _)  |    (_I_)  : (  '\_/ \   ;|   |      |   | .'   _    | 
|   |      `-'`-'|___ |  _( )_  ||  (_,_)\  |   (_(=)_)  \ `""/  \  ) / |   |      |   | |  _( )_  | 
/   )       |        \\ (_ o _) /|  |    |  |    (_I_)    '. \_/``"".'  /   )      |   | \ (_ o _) / 
`---'       `--------` '.(_,_).' '--'    '--'    '---'      '-----'    `---'      '---'  '.(_,_).'  
                                                                                                    
Welcome in, fellow plant-head! Choose an option:
(Use the arrow keys to cycle through your options. Press enter to make a selection.)";

            string[] options = { "Enter Apartment", "Enter Shop", "Earn Coins", "About", "Exit" };

            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
             

            switch (selectedIndex)
            {
                case 0:
                    EnterApartment();
                    break;
                case 1:
                    if (hasCoins < 8)
                    {

                        if (hasCoins < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You're in debt. That's embarrasing.");
                            Console.WriteLine("\nGet to work and come back when you have coins.");
                            Console.WriteLine();
                            Keys.WaitForKey();
                            RunMainMenu();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Why are you trying to go shopping? You're broke.");
                            Console.WriteLine("\nReturn once you've recieved enough coins to finish your duties.");
                            Keys.WaitForKey();
                            RunMainMenu();
                        }
                        
                    }
                    else if (hasCoins >= 8)
                    {
                        EnterShop();
                    }
                    break;
                case 2:
                    EnterTrivia();
                    break;
                case 3:
                    DisplayAboutInfo();
                    break;
                case 4:
                    ExitGame();
                    break;
            }
        }
        public static void ExitGame()
        {
            Keys.Quit();
        }

        public static void DisplayAboutInfo()
        {
            Console.Clear();
            Console.WriteLine("This is a midterm project created by Mikaela Abeyta.");
            Console.WriteLine("Your goal is to obtain 4 plants by earning coins.");
            Console.WriteLine();
            Console.WriteLine("Title is created from https://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Plantopia");
            Console.WriteLine("Other elements created with https://www.asciiart.eu/ or referenced from Michael Hadley's videos via YouTube.");
            Console.WriteLine("This is for Mikaela's PROG 101 class.");
            Console.WriteLine();
            Keys.WaitForKey();
            RunMainMenu();
        }
        public static void EnterApartment()
        {
            string prompt = @"      ()___ 
    ()//__/)_________________()
    ||(___)//#/_/#/_/#/_/#()/||
    ||----|#| |#|_|#|_|#|_|| ||
    ||____|_|#|_|#|_|#|_|#||/||
    ||    |#|_|#|_|#|_|#|_||


Home sweet home. What would you like to do?

";
            string[] options = { "Go shopping", "Water your plants", "Feed your plants", "The Prophecy", "Back to Title Screen.." };
            Menu ApartmentMenu = new Menu(prompt, options);
            int selectedIndex = ApartmentMenu.Run();
            

            switch (selectedIndex)
            {
                case 0:
                    if (hasCoins < 8)
                    {

                        if (hasCoins < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You're in debt. That's embarrasing.");
                            Console.WriteLine("\nDid you hit your head while rolling out of bed?? Go back home. Better yet, EARN MONEY!!");
                            Console.WriteLine("\nGet to work and come back when you have coins.");
                            Console.WriteLine();
                            Keys.WaitForKey();
                            EnterApartment();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Why are you trying to go shopping? You're broke.");
                            Console.WriteLine("\nReturn once you've recieved enough coins to finish your duties.");
                            Keys.WaitForKey();
                            EnterApartment();
                        }
                        
                    }
                    else if (hasCoins >= 8)
                    {
                        EnterShop();
                    }
                    break;
                case 1:
                    Console.Clear();

                    if (hasCoins < 8)
                    {
                        Console.WriteLine("Erm....What plants..?");
                        Keys.WaitForKey();
                        EnterApartment();
                    }
                    else if (hasCoins >= 8)
                    {
                        Console.WriteLine("You are now watering your plants. They start to perk up!");
                        Keys.WaitForKey();
                        EnterApartment();
                    }
                    
                    break;
                case 2:

                    Console.Clear();

                    if (hasCoins < 8)
                    {
                        Console.WriteLine("What.......plants??? Get to working.");
                        Keys.WaitForKey();
                        EnterApartment();
                    }
                    else if (hasCoins >= 8)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You give your plants some nutrients. Plants can't talk, but you swear you just heard a faint thank you.");
                        Keys.WaitForKey();
                        EnterApartment();
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("You look up to the mysterious note you were given. It says:");
                    Console.WriteLine();
                    Console.WriteLine("In order to fulfill your destiny, collect FOUR plants and achieve the Collection.");
                    Keys.WaitForKey();
                    EnterApartment();
                    break;
                case 4:
                    RunMainMenu();
                    break;
            }
        }

        public static void EnterTrivia()
        {
            Trivia.RunTrivia();
        }
        public static void EnterShop()
        {
            Item.RunShop();
        }
    }
}
