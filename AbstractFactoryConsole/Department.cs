using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsole
{
    public abstract class Department
    {
        public abstract Laptop Comprar();
        public abstract Celular Garantia();
    }
}
