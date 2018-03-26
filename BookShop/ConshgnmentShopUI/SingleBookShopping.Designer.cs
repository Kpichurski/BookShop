namespace ConshgnmentShopUI
{
    partial class SingleBookShopping
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
            this.label1 = new System.Windows.Forms.Label();
            this.Priceofbook = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Remove = new System.Windows.Forms.Button();
            this.IndexBok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Priceofbook
            // 
            this.Priceofbook.AutoSize = true;
            this.Priceofbook.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priceofbook.Location = new System.Drawing.Point(231, 23);
            this.Priceofbook.Name = "Priceofbook";
            this.Priceofbook.Size = new System.Drawing.Size(60, 24);
            this.Priceofbook.TabIndex = 1;
            this.Priceofbook.Text = "Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(440, 23);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // IndexBok
            // 
            this.IndexBok.AutoSize = true;
            this.IndexBok.Location = new System.Drawing.Point(364, 48);
            this.IndexBok.Name = "IndexBok";
            this.IndexBok.Size = new System.Drawing.Size(35, 13);
            this.IndexBok.TabIndex = 4;
            this.IndexBok.Text = "label2";
            this.IndexBok.Visible = false;
            // 
            // SingleBookShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.IndexBok);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Priceofbook);
            this.Controls.Add(this.label1);
            this.Name = "SingleBookShopping";
            this.Size = new System.Drawing.Size(597, 64);
            this.Load += new System.EventHandler(this.SingleBookShopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Priceofbook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label IndexBok;
    }
}
