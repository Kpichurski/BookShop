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
            this.PanelFront = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.books1 = new ConshgnmentShopUI.Books();
            this.shoppingCartControl1 = new ConshgnmentShopUI.ShoppingCartControl();
            this.labelcount = new System.Windows.Forms.Label();
            this.PanelFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFront
            // 
            this.PanelFront.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelFront.Controls.Add(this.labelcount);
            this.PanelFront.Controls.Add(this.button5);
            this.PanelFront.Controls.Add(this.button4);
            this.PanelFront.Controls.Add(this.button3);
            this.PanelFront.Controls.Add(this.button2);
            this.PanelFront.Controls.Add(this.button1);
            this.PanelFront.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelFront.Location = new System.Drawing.Point(0, 0);
            this.PanelFront.Name = "PanelFront";
            this.PanelFront.Size = new System.Drawing.Size(200, 638);
            this.PanelFront.TabIndex = 15;
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // books1
            // 
            this.books1.AutoScroll = true;
            this.books1.Location = new System.Drawing.Point(196, 0);
            this.books1.Name = "books1";
            this.books1.Size = new System.Drawing.Size(939, 638);
            this.books1.TabIndex = 2;
            // 
            // shoppingCartControl1
            // 
            this.shoppingCartControl1.AutoScroll = true;
            this.shoppingCartControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shoppingCartControl1.Location = new System.Drawing.Point(196, 0);
            this.shoppingCartControl1.Name = "shoppingCartControl1";
            this.shoppingCartControl1.Size = new System.Drawing.Size(930, 638);
            this.shoppingCartControl1.TabIndex = 17;
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(129, 255);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(18, 20);
            this.labelcount.TabIndex = 18;
            this.labelcount.Text = "0";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 638);
            this.Controls.Add(this.PanelFront);
            this.Controls.Add(this.books1);
            this.Controls.Add(this.shoppingCartControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.PanelFront.ResumeLayout(false);
            this.PanelFront.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFront;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Books books1;
        private ShoppingCartControl shoppingCartControl1;
        private System.Windows.Forms.Label labelcount;
    }
}

