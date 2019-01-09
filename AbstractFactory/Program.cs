using AbstractFactory.Enums;
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
            ISoda brand = null;
            string sodaName = String.Empty;
            switch (machineChoice.Key)
            {
                case ConsoleKey.NumPad1 :
                    sodaMachine = new CocaColaMachine();
                    brand = sodaMachine.LoadSelection();
                    DisplaySelection(typeof(CocaColaSelection));
                    sodaName = GetSodaChoice(typeof(CocaColaSelection));
                    break;
                case ConsoleKey.D1:
                    sodaMachine = new CocaColaMachine();
                    brand = sodaMachine.LoadSelection();
                    DisplaySelection(typeof(CocaColaSelection));
                    sodaName = GetSodaChoice(typeof(CocaColaSelection));
                    break;
                case ConsoleKey.NumPad2:
                    sodaMachine = new PepsiMachine();
                    brand = sodaMachine.LoadSelection();
                    DisplaySelection(typeof(PepsiSelection));
                    sodaName = GetSodaChoice(typeof(PepsiSelection));
                    break;
                case ConsoleKey.D2:
                    sodaMachine = new PepsiMachine();
                    brand = sodaMachine.LoadSelection();
                    DisplaySelection(typeof(PepsiSelection));
                    sodaName = GetSodaChoice(typeof(PepsiSelection));
                    break;
                default:
                    Console.WriteLine("No Choice Selected.");
                    Console.WriteLine("Closing Program.");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine(Environment.NewLine);
            if(!String.IsNullOrWhiteSpace(sodaName))
                brand.Dispense(sodaName);
            else
            {
                Console.WriteLine("Invalid soda choosen");
            }
            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static void DisplaySelection(Type choice)
        {

            string[] sodaSelection = Enum.GetNames(choice);

            Console.WriteLine("Your soda selection are the following choices below");

            for (int index = 0; index < sodaSelection.Length; index++)
            {
                Console.WriteLine($"Press {index + 1} for {sodaSelection[index]}");
            }


        }

        private static string GetSodaChoice(Type choice)
        {
            string[] sodaSelection = Enum.GetNames(choice);
            ConsoleKeyInfo keySelection = Console.ReadKey();

            if (char.IsDigit(keySelection.KeyChar))
            {
                int num = int.Parse(keySelection.KeyChar.ToString());

                if (num <= sodaSelection.Length && num != 0)
                {
                    return Enum.GetName(choice, num);
                }
            }
            return String.Empty;
        }
    }
}
