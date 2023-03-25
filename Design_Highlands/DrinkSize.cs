using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Highlands
{
    internal class DrinkSize
    {
       public DrinkSize()
        {
            this.S = 0;
            this.M = 0;
            this.L = 0;
        }

        public DrinkSize(int s, int m, int l)
        {
            this.S = s;
            this.M = m;
            this.L = l;
        }

        private int S { get; set; }
        private int M { get; set; }
        private int L { get; set; }
        
    }
}
