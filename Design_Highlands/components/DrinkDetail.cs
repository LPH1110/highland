using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands.components
{
    internal partial class DrinkDetail : UserControl
    {
        Drink drink;
        String size;
        int sweet;
        int ice;
        public DrinkDetail()
        {
            InitializeComponent();
        }

        public DrinkDetail(Drink drink, string size, int sweet, int ice)
        {
            InitializeComponent();
            this.drink = drink;
            this.size = size;
            this.sweet = sweet;
            this.ice = ice;
        }

        private void DrinkDetail_Load(object sender, EventArgs e)
        {
            txt_drinkName.Text = this.drink.NameV;
            txt_drinkSize.Text = this.size;
            txt_drinkSweet.Text = this.sweet.ToString() + "%";
            txt_drinkIce.Text = this.ice.ToString() + "%";
            switch(size)
            {
                case "S":
                    txt_drinkPrice.Text = this.drink.Price.S.ToString() + "đ";
                    break;
                case "M":
                    txt_drinkPrice.Text = this.drink.Price.M.ToString() + "đ";
                    break;
                case "L":
                    txt_drinkPrice.Text = this.drink.Price.L.ToString() + "đ";
                    break;
                default:
                    break;
            }
        }
    }
}
