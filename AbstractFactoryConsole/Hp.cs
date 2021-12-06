using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsole
{
    public class Hp : Laptop
    {
        public Hp()
        {
            _description = "Welcome to your Workstation.";
        }
    }
}