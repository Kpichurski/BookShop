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
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
    
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); ;
            itemListbox.DataSource = itemsBinding;
            itemListbox.DisplayMember ="Display";
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
            store.Vendors.Add(new Vendor {FirstName="Bill",LastName="Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones"});
            store.Items.Add(new Item { Title = "moby dikens", Decription = "aaa", Price = 4.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "harry", Decription = "BB", Price = 5.50M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "tale", Decription = "cc", Price = 6.50M, Owner = store.Vendors[0] });

        }

        private void purchaseItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseIm_Click(object sender, EventArgs e)
        {
            Item selectedItem =(Item) itemListbox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission
                    * item.Price;
                storeProfit += (decimal)(1-item.Owner.Commission )* item.Price;
                    
            }
            shoppingCartData.Clear();
                        itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); ;

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            cartBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            storeProfitValue.Text = string.Format("{0} ",storeProfit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
