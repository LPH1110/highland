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
    internal partial class DrinkWidget : UserControl
    {
        Drink drink;
        FlowLayoutPanel billPanel;
        public DrinkWidget(Drink drink, FlowLayoutPanel billPanel)
        {
            InitializeComponent();
            this.drink = drink;
            this.billPanel = billPanel;
        }

        private void DrinkWidget_Load(object sender, EventArgs e)
        {
            if (drink != null)
            {
                lb_drinkTitle.Text = drink.NameV;
            }
        }

        private void showDrinkDetail(Drink drink)
        {
            DrinkOption drinkOption = new DrinkOption(this.drink, this.billPanel);
            drinkOption.ShowDialog();
        }

        private void pb_drinkThumbnail_DoubleClick(object sender, EventArgs e)
        {
            showDrinkDetail(this.drink);
        }
    }
}
