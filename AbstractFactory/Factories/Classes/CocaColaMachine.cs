using AbstractFactory.Models.Classes;
using AbstractFactory.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories.Classes
{
    public class CocaColaMachine : ISodaMachine
    {
        public ISoda Dispense()
        {
            return new CocaColaDispenser();
        }

    }
}
