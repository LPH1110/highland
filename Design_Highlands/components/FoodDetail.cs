using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Highlands.models;

namespace Design_Highlands.components
{
    internal partial class FoodDetail : UserControl
    {
        Food food;
        FlowLayoutPanel billPanel;

        public FoodDetail()
        {
            InitializeComponent();
        }

        public FoodDetail(Food food, FlowLayoutPanel billPanel)
        {
            InitializeComponent();
            this.food = food;
            this.billPanel = billPanel;
        }

        private void FoodDetail_Load(object sender, EventArgs e)
        {
            txt_foodName.Text = food.NameV;
            txt_foodEngName.Text = food.NameE;
            txt_foodClass.Text = food.Type;
            txt_foodPrice.Text = food.Price.ToString();
        }

        private void lb_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này ra khỏi hóa đơn không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    foreach (FoodDetail control in billPanel.Controls)
                    {
                        if (control.food != null && control.food.Id.Equals(this.food.Id))
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
