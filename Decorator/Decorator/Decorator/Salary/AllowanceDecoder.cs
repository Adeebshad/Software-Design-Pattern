using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Salary
{
    public class AllowanceDecoder : SalaryDecoder
    {
        public AllowanceDecoder(ISalaryStruct salaryStruct) : base(salaryStruct)
        {
        }

        public override double Amount()
        {
            return base.Amount() + (base.Amount() * 0.25);
        }

        public override string Description()
        {
            return base.Description() + " , Allowance Part Add";
        }
    }
}
