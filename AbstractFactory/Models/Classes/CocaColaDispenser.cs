﻿using AbstractFactory.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.Classes
{
    public class CocaColaDispenser : ISoda
    {
        public void Dispense(string sodaChoice)
        {
            Console.WriteLine($"Dispensing {sodaChoice} now...");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Ding!");
            Console.WriteLine($"Enjoy your refreshing {sodaChoice}");
        }
    }
}
