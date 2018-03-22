namespace ConshgnmentShopUI
{
    partial class ControlBook
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
            this.PanelBook = new System.Windows.Forms.Panel();
            this.NameOfBookLabel = new System.Windows.Forms.Label();
            this.ButtonAddtoCart = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelBook
            // 
            this.PanelBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelBook.Location = new System.Drawing.Point(14, 26);
            this.PanelBook.Name = "PanelBook";
            this.PanelBook.Size = new System.Drawing.Size(144, 174);
            this.PanelBook.TabIndex = 0;
            // 
            // NameOfBookLabel
            // 
            this.NameOfBookLabel.AutoSize = true;
            this.NameOfBookLabel.Location = new System.Drawing.Point(53, 10);
            this.NameOfBookLabel.Name = "NameOfBookLabel";
            this.NameOfBookLabel.Size = new System.Drawing.Size(35, 13);
            this.NameOfBookLabel.TabIndex = 1;
            this.NameOfBookLabel.Text = "label1";
            // 
            // ButtonAddtoCart
            // 
            this.ButtonAddtoCart.Location = new System.Drawing.Point(26, 206);
            this.ButtonAddtoCart.Name = "ButtonAddtoCart";
            this.ButtonAddtoCart.Size = new System.Drawing.Size(121, 35);
            this.ButtonAddtoCart.TabIndex = 2;
            this.ButtonAddtoCart.Text = "Add to Cart";
            this.ButtonAddtoCart.UseVisualStyleBackColor = true;
            this.ButtonAddtoCart.Click += new System.EventHandler(this.ButtonAddtoCart_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceLabel.Location = new System.Drawing.Point(23, 261);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(49, 20);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPrice.Location = new System.Drawing.Point(84, 261);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(54, 20);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "0.00$";
            // 
            // ControlBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ButtonAddtoCart);
            this.Controls.Add(this.NameOfBookLabel);
            this.Controls.Add(this.PanelBook);
            this.Name = "ControlBook";
            this.Size = new System.Drawing.Size(171, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBook;
        private System.Windows.Forms.Label NameOfBookLabel;
        private System.Windows.Forms.Button ButtonAddtoCart;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label LabelPrice;
    }
}
