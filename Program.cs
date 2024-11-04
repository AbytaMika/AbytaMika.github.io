using System;
using static System.Console;

namespace PlantShop
{


    // Plantopia
    // Mikaela Abeyta
    // October 16, 2024
    // References from Michael Hadley via YouTube [https://youtu.be/qAWhGEPMlS8?si=5_-YRiS00bgZ5lei]
    // ASCII Art https://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Plantopia and https://www.asciiart.eu/
    // Click on the "About" scene while playing for another credit scene.
    class Program
    {
        public static void Main(string[] args)
        {
            Title = "Mikaela's Plant Shop";
            CursorVisible = false;

            Game plantShop = new Game();
            plantShop.Start();
        }
    }

    static class Keys
    {
        public static void WaitForKey()
        {
            WriteLine("(Press any key to continue...)");
            ReadKey(true);
        }

        public static void Quit()
        {
            WriteLine("(Press any key to exit..)");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}