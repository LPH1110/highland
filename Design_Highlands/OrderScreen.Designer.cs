namespace Design_Highlands
{
    partial class OrderScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flp_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_topping = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_coffee = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_food = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_drink = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.lb_back = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_payment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dd_orderType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dd_orderType)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93814F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flp_menu, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(589, 375);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // flp_menu
            // 
            this.flp_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_menu.Location = new System.Drawing.Point(3, 3);
            this.flp_menu.Name = "flp_menu";
            this.flp_menu.Size = new System.Drawing.Size(583, 315);
            this.flp_menu.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_topping, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_coffee, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_food, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_drink, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 324);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 48);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_topping
            // 
            this.btn_topping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_topping.Location = new System.Drawing.Point(439, 3);
            this.btn_topping.Name = "btn_topping";
            this.btn_topping.Size = new System.Drawing.Size(139, 42);
            this.btn_topping.TabIndex = 3;
            this.btn_topping.Values.Text = "Topping";
            // 
            // btn_coffee
            // 
            this.btn_coffee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_coffee.Location = new System.Drawing.Point(293, 3);
            this.btn_coffee.Name = "btn_coffee";
            this.btn_coffee.Size = new System.Drawing.Size(139, 42);
            this.btn_coffee.TabIndex = 2;
            this.btn_coffee.Values.Text = "Cà phê";
            // 
            // btn_food
            // 
            this.btn_food.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_food.Location = new System.Drawing.Point(148, 3);
            this.btn_food.Name = "btn_food";
            this.btn_food.Size = new System.Drawing.Size(139, 42);
            this.btn_food.TabIndex = 1;
            this.btn_food.Values.Text = "Đồ ăn";
            // 
            // btn_drink
            // 
            this.btn_drink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_drink.Location = new System.Drawing.Point(3, 3);
            this.btn_drink.Name = "btn_drink";
            this.btn_drink.Size = new System.Drawing.Size(139, 42);
            this.btn_drink.TabIndex = 0;
            this.btn_drink.Values.Text = "Thức uống";
            // 
            // pb_back
            // 
            this.pb_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = ((System.Drawing.Image)(resources.GetObject("pb_back.Image")));
            this.pb_back.Location = new System.Drawing.Point(12, 414);
            this.pb_back.Margin = new System.Windows.Forms.Padding(2);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(29, 18);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_back.TabIndex = 20;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // lb_back
            // 
            this.lb_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_back.AutoSize = true;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lb_back.ForeColor = System.Drawing.Color.Black;
            this.lb_back.Location = new System.Drawing.Point(45, 414);
            this.lb_back.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(58, 17);
            this.lb_back.TabIndex = 21;
            this.lb_back.Text = "Trở về";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btn_payment, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.dd_orderType, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(600, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.886436F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.11356F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(172, 375);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btn_payment
            // 
            this.btn_payment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_payment.Location = new System.Drawing.Point(3, 320);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(166, 52);
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Values.Text = "Thanh toán";
            // 
            // dd_orderType
            // 
            this.dd_orderType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dd_orderType.DropDownWidth = 166;
            this.dd_orderType.Items.AddRange(new object[] {
            "Ăn tại chỗ",
            "Take away",
            "Delivery"});
            this.dd_orderType.Location = new System.Drawing.Point(3, 3);
            this.dd_orderType.Name = "dd_orderType";
            this.dd_orderType.Size = new System.Drawing.Size(166, 21);
            this.dd_orderType.TabIndex = 1;
            this.dd_orderType.Text = "Loại đơn";
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderScreen";
            this.Text = "OrderScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dd_orderType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flp_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_topping;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_coffee;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_food;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_drink;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_payment;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox dd_orderType;
    }
}