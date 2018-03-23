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
            this.LabelPrice = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ButtonAddtoCart = new System.Windows.Forms.Button();
            this.NameOfBookLabel = new System.Windows.Forms.Label();
            this.PanelBook = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPrice.Location = new System.Drawing.Point(64, 241);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(54, 20);
            this.LabelPrice.TabIndex = 18;
            this.LabelPrice.Text = "0.00$";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceLabel.Location = new System.Drawing.Point(3, 241);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(49, 20);
            this.PriceLabel.TabIndex = 17;
            this.PriceLabel.Text = "Price";
            // 
            // ButtonAddtoCart
            // 
            this.ButtonAddtoCart.Location = new System.Drawing.Point(15, 203);
            this.ButtonAddtoCart.Name = "ButtonAddtoCart";
            this.ButtonAddtoCart.Size = new System.Drawing.Size(121, 35);
            this.ButtonAddtoCart.TabIndex = 16;
            this.ButtonAddtoCart.Text = "Add to Cart";
            this.ButtonAddtoCart.UseVisualStyleBackColor = true;
            this.ButtonAddtoCart.Click += new System.EventHandler(this.ButtonAddtoCart_Click_1);
            // 
            // NameOfBookLabel
            // 
            this.NameOfBookLabel.AutoSize = true;
            this.NameOfBookLabel.Location = new System.Drawing.Point(42, 7);
            this.NameOfBookLabel.Name = "NameOfBookLabel";
            this.NameOfBookLabel.Size = new System.Drawing.Size(35, 13);
            this.NameOfBookLabel.TabIndex = 15;
            this.NameOfBookLabel.Text = "label1";
            // 
            // PanelBook
            // 
            this.PanelBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelBook.Location = new System.Drawing.Point(3, 23);
            this.PanelBook.Name = "PanelBook";
            this.PanelBook.Size = new System.Drawing.Size(144, 174);
            this.PanelBook.TabIndex = 14;
            this.PanelBook.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBook_Paint);
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
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ControlBook";
            this.Size = new System.Drawing.Size(152, 271);
            this.Load += new System.EventHandler(this.ControlBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button ButtonAddtoCart;
        private System.Windows.Forms.Label NameOfBookLabel;
        private System.Windows.Forms.Panel PanelBook;
    }
}
