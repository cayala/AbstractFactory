using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.Contracts
{
    public interface ISodaMachine
    {
        ISoda Dispense();
    }
}
