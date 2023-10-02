using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Salary
{
    public class Manager : ISalaryStruct
    {
        public double Amount()
        {
            return 500.00;
        }

        public string Description()
        {
            return "Manager";
        }
    }
}
