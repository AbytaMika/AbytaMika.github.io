using PlantShop;
using Midterm.Scenes;
using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


namespace PlantShop
{
    public class Item
    {

        public string Name;
        public string Description;
        public double Price;

        public Item()
        {

        }


        public Item(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public void About()
        {
            Console.WriteLine($"{Name} {Description} ${Price}");
        }


        public static void RunShop()
        {

            Console.Clear();

            string input;
            int MonsteraTotal = 0;
            int CactusTotal = 0;
            int FernTotal = 0;
            int YuccaTotal = 0;
            int IvyTotal = 0;
            int AloeVeraTotal = 0;
            double total;
            int i = 0, j = 0;

            Console.WriteLine(@" /////////////\\\\
(((((((((((((( \\\\
))) ~~      ~~  (((
((( (*)     (*) )))
)))     <       (((
((( '\______/`  )))
)))\___________/(((
       _) (_
      / \_/ \
     /(     )\
    // )___( \\

Hey there sweetheart! You seem new here. I'm Patty, the shopkeepa' here. Welcome to Plantopia! What's your name?");

            Console.WriteLine();
            Console.WriteLine("(Type to enter your name:)");

            string Name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Well, nice to meet ya, " + Name + "! What would you like?");
            Console.WriteLine($"You have {Game.hasCoins} coins.");
            Console.WriteLine("If you don't want something, just enter 0.");

            Console.WriteLine();

            Console.WriteLine("(Press any key to view the available plants.)");

            Console.ReadKey(true);

            Console.Clear();

            Item Monstera = new Item("Monstera", "- Part of the Araceae family.", 2);
            Item Cactus = new Item("Cactus", "- Part of the Cactaceae family.", 1);
            Item Fern = new Item("Fern", "- A fancy weed.", 2);
            Item Yucca = new Item("Yucca", "- Part of the Asparagaceae family.", 2);
            Item Ivy = new Item("Ivy", "- For midterm reasons, NOT poison.", 2);
            Item AloeVera = new Item("Aloe Vera", "- A very beneficial succulent.", 1);

            Console.WriteLine();
            Monstera.About();
            Console.WriteLine();

            Console.WriteLine("How many " + Monstera.Name + " would you like?");
            input = Console.ReadLine();
            MonsteraTotal = Convert.ToInt32(input);
            

            Console.WriteLine();
            Cactus.About();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("How many " + Cactus.Name + " would you like?");
            input = Console.ReadLine();
            CactusTotal = Convert.ToInt32(input);

            Console.WriteLine();
            Fern.About();
            Console.WriteLine();

            Console.WriteLine("How many " + Fern.Name + " would you like?");
            input = Console.ReadLine();
            FernTotal = Convert.ToInt32(input);


            Console.WriteLine();
            Yucca.About();
            Console.WriteLine();

            Console.WriteLine("How many " + Yucca.Name + " would you like?");
            input = Console.ReadLine();
            YuccaTotal = Convert.ToInt32(input);


            Console.WriteLine();
            Ivy.About();
            Console.WriteLine();

            Console.WriteLine("How many " + Ivy.Name + " would you like?");
            input = Console.ReadLine();
            IvyTotal = Convert.ToInt32(input);


            Console.WriteLine();
            AloeVera.About();

            Console.WriteLine("How many " + AloeVera.Name + " would you like?");
            input = Console.ReadLine();
            AloeVeraTotal = Convert.ToInt32(input);


            total = (MonsteraTotal * Monstera.Price) + (CactusTotal * Cactus.Price) + (FernTotal * Fern.Price) + (YuccaTotal * Yucca.Price) + (IvyTotal * Ivy.Price) + (AloeVeraTotal * AloeVera.Price);

            double finalCoins;

            finalCoins = Game.hasCoins - total;

            Console.WriteLine();
            Console.WriteLine("Your total today will be " + total.ToString("c"));

            Console.WriteLine("You now have " + finalCoins);

            Keys.WaitForKey();

            if (finalCoins <0)
            {
                Console.Clear();
                Console.WriteLine("\nYou're in debt now, sugar. Unfortunately, I won't let you back in until you work for what you owe me.");
                Console.WriteLine("\nUntil Next time baby!");
                Keys.WaitForKey();
                Game.RunMainMenu();
            }

            else
            {
                    Console.Clear();
                    Console.WriteLine("Thanks for stopping by, " + Name + "! I'm so proud of you!!");
                    Keys.WaitForKey();
                    Console.ReadKey();
                    Console.Clear();
                
                
                    string prompt = "Again. This is just a midterm. This is assuming you have 4 plants. " + "\n" +
                    "\nCONTINUE GAME?";

                    string[] options = { "YES", "NO" };
                    Menu End = new Menu(prompt, options);
                    int selectedIndex = End.Run();

                switch (selectedIndex)
                {
                case 0:
                    Game.EnterApartment();
                    break;
                case 1:
                    Console.WriteLine("Thank you for playing!");
                    Keys.Quit();
                    break;
                }
            }


            
        }
    }
}

