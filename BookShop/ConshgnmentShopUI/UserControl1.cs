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
    public partial class UserControl1 : UserControl
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        public UserControl1()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); ;
            itemListbox.DataSource = itemsBinding;
            itemListbox.DisplayMember = "Display";
            itemListbox.ValueMember = "Display";
            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;
            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";
            vendorsBinding.DataSource = store.Vendors;
            vendorboxList.DataSource = vendorsBinding;
            vendorboxList.DisplayMember = "Display";
            vendorboxList.ValueMember = "Display";



        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });
            store.Items.Add(new Item { Title = "moby dikens", Decription = "aaa", Price = 4.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "harry", Decription = "BB", Price = 5.50M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "tale", Decription = "cc", Price = 6.50M, Owner = store.Vendors[0] });

        }

        private void purchaseItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseIm_Click(object sender, EventArgs e)
        {

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void purchaseItem_Click_1(object sender, EventArgs e)
        {
            Item itemToCart = new Item();
            itemToCart = (Item)itemListbox.SelectedItem;
            shoppingCartData.Add(itemToCart);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click_1(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;

                item.Owner.PaymentDue += (decimal)item.Owner.Commission * (decimal)item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * (decimal)item.Price;
            }
            itemsBinding.DataSource = store.Items.Where<Item>(item => item.Sold == false);
            vendorsBinding.DataSource = store.Vendors;
            shoppingCartData.Clear();

            storeProfitValue.Text = string.Format("{0} $", storeProfit);
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); 

            itemsBinding.ResetBindings(false);
            cartBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            


        }
    }










}
