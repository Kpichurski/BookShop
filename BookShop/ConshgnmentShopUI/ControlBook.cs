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
        public static  List<String>Names= new List<String>();
        public int i = 0;
        public ControlBook(int Left,int Top,Item item)
        {

            InitializeComponent();
            NameOfBookLabel.Text = item.Title;
            this.Left = Left;
            this.Top = Top;
            LabelPrice.Text = item.Price.ToString();
            pictureBook.Image = Properties.Resources.acc123;
            IndexofSingleBook.Text = item.Index.ToString();









    }

        private void ButtonAddtoCart_Click(object sender, EventArgs e)
        {


            Names.Add(IndexofSingleBook.Text);

            (Application.OpenForms[0] as ConsignmentShop).dodaj();


        }

        private void ControlBook_Load(object sender, EventArgs e)
        {
            this.Height = 430;
            this.Width = 300;
        }

        private void PanelBook_Paint(object sender, PaintEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.acc123;
            
        }

        private void pictureBook_Click(object sender, EventArgs e)
        {

        }
    }
}
