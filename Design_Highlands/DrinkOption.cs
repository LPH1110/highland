using Design_Highlands.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands
{
    internal partial class DrinkOption : Form
    {
        Drink drink;
        FlowLayoutPanel billPanel;
        String size;
        int sweet;
        int ice;
        public DrinkOption()
        {
            InitializeComponent();
            this.size = "";
            this.sweet = 0;
            this.ice = 0;
        }
        public DrinkOption(Drink drink, FlowLayoutPanel billPanel)
        {
            InitializeComponent();
            this.drink = drink;
            this.size = "";
            this.sweet = 0;
            this.ice = 0;
            this.billPanel = billPanel;
        }

        private bool validateOptions()
        {
            return this.size.Trim() != "" && this.sweet != 0 && this.ice != 0;
        }

        // Events
        private void btn_sizeS_Click(object sender, EventArgs e)
        {
            this.size = "S";
            txt_size.Text = this.size;
        }
        private void btn_sizeM_Click(object sender, EventArgs e)
        {
            this.size = "M";
            txt_size.Text = this.size;
        }
        private void btn_sizeL_Click(object sender, EventArgs e)
        {
            this.size = "L";
            txt_size.Text = this.size;
        }

        private void btn_optionConfirm_Click(object sender, EventArgs e)
        {
            if (validateOptions())
            {
                DrinkDetail drinkDetailWidget = new DrinkDetail(this.drink, size, sweet, ice);
                billPanel.Controls.Add(drinkDetailWidget);
                this.Hide();
            } else
            {
                MessageBox.Show("Bạn vui lòng chọn đầy đủ các tùy chọn nhé!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DrinkOption_Load(object sender, EventArgs e)
        {
            txt_sweet.Text = "0%";
            txt_ice.Text = "0%";
        }

        // Sweet option
        private void btn_sweet0_Click(object sender, EventArgs e)
        {
            this.sweet = 0;
            txt_sweet.Text = "0%";
        }
        private void btn_sweet30_Click(object sender, EventArgs e)
        {
            this.sweet = 30;
            txt_sweet.Text = "30%";
        }
        private void btn_sweet50_Click(object sender, EventArgs e)
        {
            this.sweet = 50;
            txt_sweet.Text = "50%";
        }
        private void btn_sweet100_Click(object sender, EventArgs e)
        {
            this.sweet = 100;
            txt_sweet.Text = "100%";
        }

        // Ice option
        private void btn_ice0_Click(object sender, EventArgs e)
        {
            this.ice = 0;
            txt_ice.Text = "0%";
        }
        private void btn_ice30_Click(object sender, EventArgs e)
        {
            this.ice = 30;
            txt_ice.Text = "30%";
        }
        private void btn_ice50_Click(object sender, EventArgs e)
        {
            this.ice = 50;
            txt_ice.Text = "50%";
        }
        private void btn_ice100_Click(object sender, EventArgs e)
        {
            this.ice = 100;
            txt_ice.Text = "100%";
        }
    }
}
