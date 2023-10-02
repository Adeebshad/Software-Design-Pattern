using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Salary
{
    public abstract class SalaryDecoder : ISalaryStruct
    {
        ISalaryStruct _salaryStruct;

        public SalaryDecoder(ISalaryStruct salaryStruct) {
            _salaryStruct = salaryStruct;
        }
        public virtual double Amount()
        {
            return _salaryStruct.Amount();
        }

        public virtual string Description()
        {
            return _salaryStruct.Description();
        }
    }
}
