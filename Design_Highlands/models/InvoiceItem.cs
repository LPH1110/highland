using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Highlands.models
{
    internal class InvoiceItem
    {
        private Drink drink;
        private String size;
        private int sweet;
        private int ice;

        public InvoiceItem(Drink drink, string size, int sweet, int ice)
        {
            this.drink = drink;
            this.size = size;
            this.sweet = sweet;
            this.ice = ice;
        }

        public Drink Drink { get { return this.drink; } set { this.drink = value; } }
        public String Size { get { return this.size; } set { this.size = value; } }
        public int Sweet { get { return this.sweet; } set { this.sweet = value; } }
        public int Ice { get { return this.ice; } set { this.ice = value; } }

    }
}
