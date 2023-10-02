using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Salary
{
    public class SeniorDeveloper : ISalaryStruct
    {
        public double Amount()
        {
            return 300.00;
        }

        public string Description()
        {
            return "Senior Developer";
        }
    }
}
