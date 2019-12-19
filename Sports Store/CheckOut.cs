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

        public static Double totalAmount;

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

            totalAmount = 0;
            int itemCounter = 0;

            foreach (Item ie in myBasket.basketToCheckout)
            {
                rtbCheckOutBasket.Text += ie.Name.ToString() + "\n";
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


        private void rbtnHomeDelivery_CheckedChanged(object sender, EventArgs e)
        {
            gbHomeDelivery.Visible = true;
            gbInShop.Visible = false;
        }

        private void rbtnInShopDelivery_CheckedChanged(object sender, EventArgs e)
        {
            gbInShop.Visible = true;
            gbHomeDelivery.Visible = false;
        }
       

        private void btnPayInShop_Click(object sender, EventArgs e)
        {

            if (txtFirstNameInShop.Text != "" && txtLastNameInShop.Text != "")
            {
                Order ord = new Order(new Random().Next(10000, 99999), DateTime.Today, myBasket.basketToCheckout,
                myBasket.basketToCheckout.Sum(Item => Item.Price), txtFirstNameInShop.Text, txtLastNameInShop.Text);

                MessageBox.Show("Since there's no way of simulating a payment system, we're just going to imagine that the customer's " +
                    "payment has been accepted. :)");

                Payment toPayment = new Payment(ord);
                toPayment.ShowDialog();
            }
            else
                MessageBox.Show("You must fill every fields to order.");
            
        }


        private void btnPayDelivery_Click(object sender, EventArgs e)
        {
            if(txtFirstNameDelivery.Text != "" && txtLastNameDelivery.Text != "" && txtAddressDelivery.Text != "" && txtCityDelivery.Text != "" && txtPCDelivery.Text != "")
            {
                //MessageBox.Show(totalAmount.ToString());
                if (totalAmount > 500.00)
                    MessageBox.Show("In order to get your order delivered, it must be less than 500€.");
                else
                { 
                    Order ord = new Order(new Random().Next(10000, 99999), DateTime.Today, dtpDeliveryDate.Value, myBasket.basketToCheckout,
                    myBasket.basketToCheckout.Sum(Item => Item.Price), txtFirstNameDelivery.Text, txtLastNameDelivery.Text,
                    txtAddressDelivery.Text, txtPCDelivery.Text, txtCityDelivery.Text);

                    MessageBox.Show("Since there's no way of simulating a payment system, we're just going to imagine that the customer's " +
                    "payment has been accepted. :)");

                    Payment toPayment = new Payment(ord);
                    toPayment.ShowDialog();
                }
            }
            else
                MessageBox.Show("You must fill every fields to order.");
        }
        
        //USELESS
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //USELESS
        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
