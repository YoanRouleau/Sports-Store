using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Store
{
    public partial class CheckOut : Form
    {

        // Disable X Button -------------------------------------------
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        // ------------------------------------------------------------


        ItemList myBasket;

        public CheckOut(ItemList basket)
        {
            InitializeComponent();
            myBasket = basket;

            Double totalAmount = 0;
            int itemCounter = 0;

            foreach (Item ie in myBasket.basketToCheckout)
            {
                rtbCheckOutBasket.Text += ie.Name.ToString() + "\t" + ie.Price + "€" + "\n";
                totalAmount += ie.Price;
                itemCounter++;
            }

            txtItemCount.Text += itemCounter + " Items";
            txtTotalAmount.Text += totalAmount + "€";

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
