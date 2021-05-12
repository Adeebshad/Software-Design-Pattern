using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class singleton_fn
    {
        private static singleton_fn single;
        private singleton_fn() {

        }
        
        public static singleton_fn GetInstance(){
            //var value;
             if (single == null) {
                Console.WriteLine("New value");
                single = new singleton_fn();
             }
            return single;
        }
    }
    
}
