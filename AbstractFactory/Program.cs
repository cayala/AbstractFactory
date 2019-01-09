using AbstractFactory.Factories.Classes;
using AbstractFactory.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Soda Machine!");
            Console.WriteLine("Would you like Coca Cola sodas or Pepsi Sodas?");
            Console.WriteLine("If you want Coca Cola sodas then press 1");
            Console.WriteLine("If you want Pepsi sodas then press 2");
            ConsoleKeyInfo machineChoice = Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            ISodaMachine sodaMachine = null;

            switch (machineChoice.Key)
            {
                case ConsoleKey.NumPad1 :
                    sodaMachine = new CocaColaMachine();
                    break;
                case ConsoleKey.D1:
                    sodaMachine = new CocaColaMachine();
                    break;
                case ConsoleKey.NumPad2:
                    sodaMachine = new PepsiMachine();
                    break;
                case ConsoleKey.D2:
                    sodaMachine = new PepsiMachine();
                    break;
                default:
                    Console.WriteLine("No Choice Selected.");
                    Console.WriteLine("Closing Program.");
                    Environment.Exit(0);
                    break;
            }

            ISoda machine = sodaMachine.LoadSelection();
            machine.Dispense("test");

            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
