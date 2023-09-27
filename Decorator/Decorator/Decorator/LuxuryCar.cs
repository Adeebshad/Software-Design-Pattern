using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LuxuryCar : ICar
    {
        public double GetCost()
        {
            return 100.0;
        }

        public string GetDescription()
        {
            return "Luxury Car";
        }
    }
}
