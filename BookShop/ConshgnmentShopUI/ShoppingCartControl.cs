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
    public partial class ShoppingCartControl : UserControl
    {
        
        

        public ShoppingCartControl()
        {
            
            InitializeComponent();
            
            int wspX=0, wspY=0;
            Books books=new Books();





            for (int i = 0; i < ControlBook.Names.Count; i++)
            {
                SingleBookShopping kont = new SingleBookShopping(books.store.Items[Int32.Parse(ControlBook.Names[i])], 0, wspY);
                Controls.Add(kont);
                
                wspY += 50;
            }




            














        }
      
    }
}
