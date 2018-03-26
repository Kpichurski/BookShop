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

    public partial class SingleBookShopping : UserControl
    {
        public SingleBookShopping(Item item, int Left, int Top)
        {
            InitializeComponent();
            label1.Text = item.Title;
            this.Left = Left;
            this.Top = Top;
            Priceofbook.Text = item.Price.ToString();
            IndexBok.Text = item.Index.ToString();

           









        }

        private void SingleBookShopping_Load(object sender, EventArgs e)
        {
            this.Height = 90;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
           
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            ControlBook.Names.Remove(IndexBok.Text);


            (Application.OpenForms[0] as ConsignmentShop).odswiez();
            (Application.OpenForms[0] as ConsignmentShop).dodaj();


            













        }
    }
}
