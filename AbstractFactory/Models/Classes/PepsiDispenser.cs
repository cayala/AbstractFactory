using AbstractFactory.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.Classes
{
    public class PepsiDispenser: ISoda
    {
        public void Dispense(string sodaChoice)
        {
            Console.WriteLine($"Dispensing {sodaChoice} now...");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Fizz...");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Fizz...");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Fizz...");
            Console.ResetColor();
            Console.WriteLine("Ding!");
            Console.WriteLine($"Enjoy your refreshing {sodaChoice}");
        }
    }
}
