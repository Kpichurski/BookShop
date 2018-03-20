namespace ConshgnmentShopUI
{
    partial class UserControl1
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorboxList = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.purchaseItem = new System.Windows.Forms.Button();
            this.ItemsListboxLabel = new System.Windows.Forms.Label();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.headerText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Location = new System.Drawing.Point(551, 343);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(34, 13);
            this.storeProfitValue.TabIndex = 21;
            this.storeProfitValue.Text = "$0.00";
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Location = new System.Drawing.Point(457, 343);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(58, 13);
            this.storeProfitLabel.TabIndex = 20;
            this.storeProfitLabel.Text = "Store profit";
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Location = new System.Drawing.Point(92, 317);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(46, 13);
            this.vendorListboxLabel.TabIndex = 19;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorboxList
            // 
            this.vendorboxList.FormattingEnabled = true;
            this.vendorboxList.Location = new System.Drawing.Point(96, 359);
            this.vendorboxList.Name = "vendorboxList";
            this.vendorboxList.Size = new System.Drawing.Size(175, 134);
            this.vendorboxList.TabIndex = 18;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(539, 235);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(75, 23);
            this.makePurchase.TabIndex = 17;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click_1);
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(434, 62);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(74, 13);
            this.shoppingCartListboxLabel.TabIndex = 16;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.Location = new System.Drawing.Point(439, 85);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(175, 134);
            this.shoppingCartListbox.TabIndex = 15;
            // 
            // purchaseItem
            // 
            this.purchaseItem.Location = new System.Drawing.Point(297, 110);
            this.purchaseItem.Name = "purchaseItem";
            this.purchaseItem.Size = new System.Drawing.Size(85, 36);
            this.purchaseItem.TabIndex = 14;
            this.purchaseItem.Text = "Add to cart";
            this.purchaseItem.UseVisualStyleBackColor = true;
            this.purchaseItem.Click += new System.EventHandler(this.purchaseItem_Click_1);
            // 
            // ItemsListboxLabel
            // 
            this.ItemsListboxLabel.AutoSize = true;
            this.ItemsListboxLabel.Location = new System.Drawing.Point(92, 62);
            this.ItemsListboxLabel.Name = "ItemsListboxLabel";
            this.ItemsListboxLabel.Size = new System.Drawing.Size(60, 13);
            this.ItemsListboxLabel.TabIndex = 13;
            this.ItemsListboxLabel.Text = "Store Items";
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Location = new System.Drawing.Point(96, 85);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(175, 134);
            this.itemListbox.TabIndex = 12;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(78, 7);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(128, 13);
            this.headerText.TabIndex = 11;
            this.headerText.Text = "Consignment Shop demo ";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(644, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorboxList;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button purchaseItem;
        private System.Windows.Forms.Label ItemsListboxLabel;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.Label headerText;
    }
}
