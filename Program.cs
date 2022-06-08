using System;

namespace DefenseofConsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Defend the City of Consolas from the evil ship called the Manicore!");
            Console.WriteLine("Tell the four wizards the row and column of the tile where the Manticore is shooting!");
            Console.WriteLine("They will deploy to the adjacent blocks and place a magical barrier over it!");
            
            Console.Write("Target Row? ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Target Column? ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Deploy to: ");
            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");

            Console.Beep();
        }
    }
}
