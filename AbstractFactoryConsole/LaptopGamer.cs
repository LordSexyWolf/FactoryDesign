using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsole
{
    public class LaptopGamer : Department
    {
        public override Celular Garantia()
        {
            return new Huawei();
        }

        public override Laptop Comprar()
        {
            return new Alienware();
        }
    }
}
