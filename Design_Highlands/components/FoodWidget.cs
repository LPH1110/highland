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
using Design_Highlands.components;
using static System.Windows.Forms.LinkLabel;

namespace Design_Highlands.components
{
    internal partial class FoodWidget : UserControl
    {
        Food food;
        FlowLayoutPanel billPanel;
        public FoodWidget()
        {
            InitializeComponent();
        }

        public FoodWidget(Food food, FlowLayoutPanel billPanel)
        {
            InitializeComponent();
            this.food = food;
            this.billPanel = billPanel;
        }

        private void FoodWidget_Load(object sender, EventArgs e)
        {
            if (this.food != null)
            {
                lb_foodTitle.Text = food.NameV;
            }
        }

        

        private void pb_foodThumbnail_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thêm món này vào hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes:
                    FoodDetail foodDetailWidget = new FoodDetail(this.food, billPanel);
                    billPanel.Controls.Add(foodDetailWidget);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

    }
}
