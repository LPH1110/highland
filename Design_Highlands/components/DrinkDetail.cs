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
        List<DrinkDetail> invoices;
        FlowLayoutPanel billPanel;
        String size;
        int sweet;
        int ice;
        public DrinkDetail()
        {
            InitializeComponent();
        }

        public DrinkDetail(Drink drink, string size, int sweet, int ice, List<DrinkDetail> invoices, FlowLayoutPanel billPanel)
        {
            InitializeComponent();
            this.drink = drink;
            this.size = size;
            this.sweet = sweet;
            this.ice = ice;
            this.invoices = invoices;
            this.billPanel = billPanel;
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

        private void lb_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này ra khỏi hóa đơn không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes:
                    foreach (DrinkDetail control in billPanel.Controls.OfType<DrinkDetail>())
                    {
                        if (control.drink != null && control.drink.Id.Equals(this.drink.Id))
                        {
                            billPanel.Controls.Remove(control);
                            control.Dispose();
                        }
                    }
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            
        }
    }
}
