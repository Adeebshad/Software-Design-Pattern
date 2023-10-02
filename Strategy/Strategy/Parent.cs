using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Parent
    {
        private IStrategy _strategy;

        /*
        public void SetStrategy(IStrategy strategy) {
            _strategy = strategy;
        }
        */

        public Parent(IStrategy strategy) {
            _strategy = strategy;
        }

        public string ExecuteStrategy()
        {
            return _strategy.Execute();
        }
    }
}
