namespace Design_Highlands
{
    partial class AddNewDrink
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tb_drinkNameEng = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tb_drinkPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pb_drinkImage = new System.Windows.Forms.PictureBox();
            this.cb_drinkSizeS = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cb_drinkSizeM = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cb_drinkSizeL = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addNewDrink = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openDrinkFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tb_drinkNameViet = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_drinkImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 32);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Tên món (English)";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 114);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Kích cỡ";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 164);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Giá thành";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(26, 225);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Hình ảnh";
            // 
            // tb_drinkNameEng
            // 
            this.tb_drinkNameEng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_drinkNameEng.Location = new System.Drawing.Point(162, 32);
            this.tb_drinkNameEng.Name = "tb_drinkNameEng";
            this.tb_drinkNameEng.Size = new System.Drawing.Size(187, 20);
            this.tb_drinkNameEng.TabIndex = 4;
            // 
            // tb_drinkPrice
            // 
            this.tb_drinkPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_drinkPrice.Location = new System.Drawing.Point(162, 164);
            this.tb_drinkPrice.Name = "tb_drinkPrice";
            this.tb_drinkPrice.Size = new System.Drawing.Size(187, 20);
            this.tb_drinkPrice.TabIndex = 5;
            // 
            // pb_drinkImage
            // 
            this.pb_drinkImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_drinkImage.Enabled = false;
            this.pb_drinkImage.Location = new System.Drawing.Point(162, 225);
            this.pb_drinkImage.Name = "pb_drinkImage";
            this.pb_drinkImage.Size = new System.Drawing.Size(103, 97);
            this.pb_drinkImage.TabIndex = 6;
            this.pb_drinkImage.TabStop = false;
            this.pb_drinkImage.Click += new System.EventHandler(this.pb_drinkImage_Click);
            // 
            // cb_drinkSizeS
            // 
            this.cb_drinkSizeS.Location = new System.Drawing.Point(162, 114);
            this.cb_drinkSizeS.Name = "cb_drinkSizeS";
            this.cb_drinkSizeS.Size = new System.Drawing.Size(30, 20);
            this.cb_drinkSizeS.TabIndex = 7;
            this.cb_drinkSizeS.Values.Text = "S";
            // 
            // cb_drinkSizeM
            // 
            this.cb_drinkSizeM.Location = new System.Drawing.Point(208, 114);
            this.cb_drinkSizeM.Name = "cb_drinkSizeM";
            this.cb_drinkSizeM.Size = new System.Drawing.Size(35, 20);
            this.cb_drinkSizeM.TabIndex = 8;
            this.cb_drinkSizeM.Values.Text = "M";
            // 
            // cb_drinkSizeL
            // 
            this.cb_drinkSizeL.Location = new System.Drawing.Point(258, 114);
            this.cb_drinkSizeL.Name = "cb_drinkSizeL";
            this.cb_drinkSizeL.Size = new System.Drawing.Size(29, 20);
            this.cb_drinkSizeL.TabIndex = 9;
            this.cb_drinkSizeL.Values.Text = "L";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_addNewDrink, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 360);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 38);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btn_addNewDrink
            // 
            this.btn_addNewDrink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addNewDrink.Location = new System.Drawing.Point(3, 3);
            this.btn_addNewDrink.Name = "btn_addNewDrink";
            this.btn_addNewDrink.Size = new System.Drawing.Size(148, 32);
            this.btn_addNewDrink.TabIndex = 0;
            this.btn_addNewDrink.Values.Text = "Tạo mới";
            this.btn_addNewDrink.Click += new System.EventHandler(this.btn_addNewDrink_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(157, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(148, 32);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Values.Text = "Hủy";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // openDrinkFileDialog
            // 
            this.openDrinkFileDialog.FileName = "openFileDialog1";
            // 
            // tb_drinkNameViet
            // 
            this.tb_drinkNameViet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_drinkNameViet.Location = new System.Drawing.Point(162, 72);
            this.tb_drinkNameViet.Name = "tb_drinkNameViet";
            this.tb_drinkNameViet.Size = new System.Drawing.Size(187, 20);
            this.tb_drinkNameViet.TabIndex = 12;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(26, 72);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(133, 20);
            this.kryptonLabel5.TabIndex = 11;
            this.kryptonLabel5.Values.Text = "Tên món (Vietnamese)";
            // 
            // AddNewDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 492);
            this.Controls.Add(this.tb_drinkNameViet);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cb_drinkSizeL);
            this.Controls.Add(this.cb_drinkSizeM);
            this.Controls.Add(this.cb_drinkSizeS);
            this.Controls.Add(this.pb_drinkImage);
            this.Controls.Add(this.tb_drinkPrice);
            this.Controls.Add(this.tb_drinkNameEng);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "AddNewDrink";
            this.Text = "AddNewDrink";
            ((System.ComponentModel.ISupportInitialize)(this.pb_drinkImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_drinkNameEng;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_drinkPrice;
        private System.Windows.Forms.PictureBox pb_drinkImage;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cb_drinkSizeS;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cb_drinkSizeM;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cb_drinkSizeL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_addNewDrink;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private System.Windows.Forms.OpenFileDialog openDrinkFileDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_drinkNameViet;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}