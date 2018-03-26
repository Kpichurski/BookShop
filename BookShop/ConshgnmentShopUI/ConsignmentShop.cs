using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConshgnmentShopUI
{
    public partial class ConsignmentShop : Form
    {

        public ConsignmentShop()
        {
            InitializeComponent();




        }
        public void dodaj()
        {
            labelcount.Text = ControlBook.Names.Count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            books1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ShoppingCartControl daa = new ShoppingCartControl();
            shoppingCartControl1.Controls.Add(daa);
            shoppingCartControl1.BringToFront();
            daa.BringToFront();
        }
        public void odswiez()
        {
            ShoppingCartControl daa = new ShoppingCartControl();
            shoppingCartControl1.Controls.Add(daa);
            shoppingCartControl1.BringToFront();
            daa.BringToFront();
        }
    }
}
