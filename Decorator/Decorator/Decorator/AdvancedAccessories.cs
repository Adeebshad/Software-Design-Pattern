using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar aCar) : base(aCar)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 74;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Advanced Accessories Package";
        }
    }
}
