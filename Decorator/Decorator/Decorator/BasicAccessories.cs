﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar aCar) : base(aCar)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 34;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Basic Accessories Package";
        }
    }
}
