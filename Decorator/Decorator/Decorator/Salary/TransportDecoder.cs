using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Salary
{
    public class TransportDecoder : SalaryDecoder
    {
        public TransportDecoder(ISalaryStruct salaryStruct) : base(salaryStruct)
        {
        }

        public override double Amount()
        {
            return ( base.Amount() + (base.Amount() * 0.15));
        }

        public override string Description()
        {
            return base.Description() + " , Transport Part Add";
        }

    }
}
