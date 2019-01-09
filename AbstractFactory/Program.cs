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

            switch (machineChoice.Key)
            {
                case ConsoleKey.NumPad1 :
                    Console.Write("test");
                    break;
                case ConsoleKey.D1:
                    Console.Write("test");
                    break;
                case ConsoleKey.NumPad2:
                    Console.Write("test");
                    break;
                case ConsoleKey.D2:
                    Console.Write("test");
                    break;
                default:
                    break;
            }
        }

        //private ISodaMachine LoadSodaMachine()
        //{

        //}
    }
}
