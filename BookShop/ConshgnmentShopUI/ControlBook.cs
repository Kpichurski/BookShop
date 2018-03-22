using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;
namespace ConshgnmentShopUI
{
    public partial class ControlBook : UserControl
    {
        public ControlBook(int Left,int Top,Item item)
        {
            InitializeComponent();
            NameOfBookLabel.Text = item.Title;
            this.Left = Left;
            this.Top = Top;
            LabelPrice.Text = item.Price.ToString();
        
            
         



        }

        private void ButtonAddtoCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NameOfBookLabel.Text);
        }
    }
}
