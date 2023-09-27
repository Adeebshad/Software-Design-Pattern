using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DeluxCar : ICar
    {
        public double GetCost()
        {
            return 75.0;
        }

        public string GetDescription()
        {
            return "Delux Car";
        }
    }
}
