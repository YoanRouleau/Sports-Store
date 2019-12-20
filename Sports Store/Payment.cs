using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Store
{

    public partial class Payment : Form
    {
        public static String receiptName;

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


        public Payment(Order order)
        {
            InitializeComponent();

            txtThankYou.Text = "Thanks for your order " + order.Firstname + " " + order.Lastname + "!\n";

            //If order IS NOT an order to DELIVER
            if (order.DateOfDelivery == new DateTime(0001, 01, 01)){
                txtDetails.Text = "Please come and collect your order in our shop from Tomorrow (our staff will need 1 day to prepare your order)";
                txtAddress.Text = "Sport 2000 \n01500 - Amberieu en Bugey";
            }
            else{
                txtDetails.Text = "You will receive your order on the " + order.DateOfDelivery.ToShortDateString() + " at the address you specified previously.";
                txtAddress.Text = order.Address + "\n" + order.Postcode + " - " + order.City;
            }

                
            //Display the total price
            txtTotal.Text += order.Price + "€";

            //List all the item ordered in the RichTextBox
            foreach(Item ie in order.OrderBasket)
            {
                rtbItemList.Text += ie.Name + "\t" + ie.Price + "€\n";
            }

            receiptName = order.Reference + "_" + order.Firstname + "_" + order.Lastname;

            //All the part below is about creating the txt receipt
            using (StreamWriter writer = File.CreateText(@".\Orders\" + receiptName + ".txt"))
            {
                try
                {
                    writer.WriteLine("----------- SPORT 2000: ORDER RECEIPT -----------");
                    writer.WriteLine("Order n°"+ order.Reference + "        Date of order: " + order.DateOfOrder);
                    writer.WriteLine("Buyer: " + order.Firstname + " " + order.Lastname);
                    writer.WriteLine("Payment method:  Credit Card");
                    writer.WriteLine("Order Price:  " + order.Price + "€");
                    writer.WriteLine("-------------------------------------------------");

                    //If order IS NOT an order to DELIVER
                    if (order.DateOfDelivery == new DateTime(0001, 01, 01))
                    {
                        writer.WriteLine("Address: Sport 2000");
                        writer.WriteLine("City : Ambérieu-en-Bugey     Postcode: 01500" + "\n");
                    }
                    else
                    {
                        writer.WriteLine("Date of Delivery: " + order.DateOfDelivery.ToShortDateString());
                        writer.WriteLine("Address: " + order.Address);
                        writer.WriteLine("City : " + order.City + "    Postcode: " + order.Postcode + "\n");
                    }

                    writer.WriteLine("--------------- ORDER COMPOSITION ---------------\n");

                    foreach (Item ie in order.OrderBasket)
                    {
                        writer.WriteLine("- " + ie.Name + " || Price: " + ie.Price + "€");
                    }


                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "IOException");
                }

                writer.Close();
            }

        }

        private void btnOpenReceipt_Click(object sender, EventArgs e)
        {
            //Open the freshly generated receipt
            Process.Start(@".\Orders\" + receiptName + ".txt");
        }

        //Allow to close the PAYMENT and CHECKOUT window in order to only display the main interface
        private void btnClose_Click(object sender, EventArgs e)
        {
            Payment obj = (Payment)Application.OpenForms["Payment"];
            obj.Close();

            CheckOut obj2 = (CheckOut)Application.OpenForms["CheckOut"];
            obj2.Close();
        }




        //USELESS
        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
