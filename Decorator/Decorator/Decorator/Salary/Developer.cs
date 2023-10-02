using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Salary
{
    public class Developer : ISalaryStruct
    {
        public double Amount()
        {
            return 100.00;
        }

        public string Description()
        {
            return "Developer ";
        }
    }
}
