using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar aCar) : base(aCar)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 76;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Sports Accessories Package";
        }
    }
}
