using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Salary
{
    public class BasicDecoder : SalaryDecoder
    {
        public BasicDecoder(ISalaryStruct salaryStruct) : base(salaryStruct)
        {
        }

        public override double Amount()
        {
            return (base.Amount() + (base.Amount() * 0.4));
        }

        public override string Description()
        {
            return base.Description() + " , Basic Part Add ";
        }
    }
}
