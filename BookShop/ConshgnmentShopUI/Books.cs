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
    public partial class Books : UserControl
    {
        public Store store = new Store();
       
     
        public Books()
        {
            InitializeComponent();

            SetupData();
           
            int varX=0, varY=0,sum=0;
            foreach (Item Item in store.Items)
            {
                if (sum <= 2)
                {
                    Controls.Add(new ControlBook(varX,varY,Item));
                    varX += 130;
                    sum++;
                }
              if (sum == 3)
                {
                    varY += 180;
                    varX = 0;
                    sum = 0;
                }
            }
           


            



        }

        public  void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });
            store.Items.Add(new Item { Title = "moby dikens", Decription = "aaa", Price = 4.50M, Owner = store.Vendors[0] , Index = 0 });
            store.Items.Add(new Item { Title = "harry", Decription = "BB", Price = 5.50M, Owner = store.Vendors[0], Index = 1 });
            store.Items.Add(new Item { Title = "tale", Decription = "cc", Price = 6.50M, Owner = store.Vendors[0], Index = 2 });
            store.Items.Add(new Item { Title = "moby dikens", Decription = "aaa", Price = 4.50M, Owner = store.Vendors[0], Index = 3 });
            store.Items.Add(new Item { Title = "harry", Decription = "BB", Price = 5.50M, Owner = store.Vendors[1], Index = 4 });
            store.Items.Add(new Item { Title = "tale", Decription = "cc", Price = 6.50M, Owner = store.Vendors[0], Index = 5 });

        }
        public void SetupData1(Store store1)
        {
            store1.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store1.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });
            store1.Items.Add(new Item { Title = "moby dikens", Decription = "aaa", Price = 4.50M, Owner = store.Vendors[0] });
            store1.Items.Add(new Item { Title = "harry", Decription = "BB", Price = 5.50M, Owner = store.Vendors[1] });
            store1.Items.Add(new Item { Title = "tale", Decription = "cc", Price = 6.50M, Owner = store.Vendors[0] });
            store1.Items.Add(new Item { Title = "moby dikens", Decription = "aaa", Price = 4.50M, Owner = store.Vendors[0] });
            store1.Items.Add(new Item { Title = "harry", Decription = "BB", Price = 5.50M, Owner = store.Vendors[1] });
            store1.Items.Add(new Item { Title = "tale", Decription = "cc", Price = 6.50M, Owner = store.Vendors[0] });

        }
    }
}
