using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Highlands
{
    internal class DrinkSize
    {
        private int s;
        private int m;
        private int l;
        public DrinkSize()
        {
            this.s = 0;
            this.m = 0;
            this.l = 0;
        }

        public DrinkSize(int s, int m, int l)
        {
            this.s = s;
            this.m = m;
            this.l = l;
        }

        public int S { get { return this.s; } set { this.s = value; } }
        public int M { get { return this.m; } set { this.m = value; } }
        public int L { get { return this.l; } set { this.l = value; } }

    }
}
