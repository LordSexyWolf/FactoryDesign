using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsole
{
    public abstract class Laptop
    {
        protected string _description;

        public object Description
        {
            get { return _description; }
        }
    }
}