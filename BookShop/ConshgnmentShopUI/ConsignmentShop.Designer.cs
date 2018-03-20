namespace ConshgnmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.ItemsListboxLabel = new System.Windows.Forms.Label();
            this.purchaseItem = new System.Windows.Forms.Button();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorboxList = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.PanelFront = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.userControl11 = new ConshgnmentShopUI.UserControl1();
            this.userControl12 = new ConshgnmentShopUI.UserControl1();
            this.PanelFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(218, 33);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(193, 20);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop demo ";
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.ItemHeight = 20;
            this.itemListbox.Location = new System.Drawing.Point(236, 111);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(175, 144);
            this.itemListbox.TabIndex = 1;
            // 
            // ItemsListboxLabel
            // 
            this.ItemsListboxLabel.AutoSize = true;
            this.ItemsListboxLabel.Location = new System.Drawing.Point(232, 88);
            this.ItemsListboxLabel.Name = "ItemsListboxLabel";
            this.ItemsListboxLabel.Size = new System.Drawing.Size(92, 20);
            this.ItemsListboxLabel.TabIndex = 2;
            this.ItemsListboxLabel.Text = "Store Items";
            // 
            // purchaseItem
            // 
            this.purchaseItem.Location = new System.Drawing.Point(437, 136);
            this.purchaseItem.Name = "purchaseItem";
            this.purchaseItem.Size = new System.Drawing.Size(85, 36);
            this.purchaseItem.TabIndex = 3;
            this.purchaseItem.Text = "Add to cart";
            this.purchaseItem.UseVisualStyleBackColor = true;
            this.purchaseItem.Click += new System.EventHandler(this.purchaseIm_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(579, 111);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(175, 144);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(574, 88);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(111, 20);
            this.shoppingCartListboxLabel.TabIndex = 5;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(679, 261);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(75, 23);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Location = new System.Drawing.Point(232, 343);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(69, 20);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorboxList
            // 
            this.vendorboxList.FormattingEnabled = true;
            this.vendorboxList.ItemHeight = 20;
            this.vendorboxList.Location = new System.Drawing.Point(236, 385);
            this.vendorboxList.Name = "vendorboxList";
            this.vendorboxList.Size = new System.Drawing.Size(175, 144);
            this.vendorboxList.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Location = new System.Drawing.Point(597, 369);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(88, 20);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store profit";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Location = new System.Drawing.Point(691, 369);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(49, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // PanelFront
            // 
            this.PanelFront.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelFront.Controls.Add(this.button5);
            this.PanelFront.Controls.Add(this.button4);
            this.PanelFront.Controls.Add(this.button3);
            this.PanelFront.Controls.Add(this.button2);
            this.PanelFront.Controls.Add(this.button1);
            this.PanelFront.Location = new System.Drawing.Point(-3, -1);
            this.PanelFront.Name = "PanelFront";
            this.PanelFront.Size = new System.Drawing.Size(200, 575);
            this.PanelFront.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(3, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(3, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(222, 33);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(644, 517);
            this.userControl11.TabIndex = 15;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(753, 209);
            this.userControl12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(8, 8);
            this.userControl12.TabIndex = 12;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 570);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.PanelFront);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorboxList);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.purchaseItem);
            this.Controls.Add(this.ItemsListboxLabel);
            this.Controls.Add(this.itemListbox);
            this.Controls.Add(this.headerText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.PanelFront.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.Label ItemsListboxLabel;
        private System.Windows.Forms.Button purchaseItem;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorboxList;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
        private UserControl1 userControl12;
        private System.Windows.Forms.Panel PanelFront;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private UserControl1 userControl11;
    }
}

