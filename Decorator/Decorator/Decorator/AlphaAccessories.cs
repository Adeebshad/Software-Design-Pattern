using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AlphaAccessories : CarAccessoriesDecorator
    {
        public AlphaAccessories(ICar aCar) : base(aCar)
        {
        }

        public override double GetCost() { 
            return base.GetCost() + 50;
        }

        public override string GetDescription() {
            return base.GetDescription() + ", Alpha Accessories Package added";
        }
    }
}
