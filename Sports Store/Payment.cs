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
    public partial class Payment : Form
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


        public Payment(Order order)
        {
            InitializeComponent();

            txtThankYou.Text = "Thanks for your order " + order.Firstname + " " + order.Lastname + "!\n";

            if (order.DateOfDelivery == new DateTime(0001, 01, 01)){
                txtDetails.Text = "Please come and collect your order in our shop from Tomorrow (our staff will need 1 day to prepare your order)";
                txtAddress.Text = "Sport 2000 \n01500 - Amberieu en Bugey";
            }
            else{
                txtDetails.Text = "You will receive your order on the " + order.DateOfDelivery.ToShortDateString() + " at the address you specified previously.";
                txtAddress.Text = order.Address + "\n" + order.Postcode + " - " + order.City;
            }

                

            txtTotal.Text += order.Price + "€";
            

            foreach(Item ie in order.OrderBasket)
            {
                rtbItemList.Text += ie.Name + "\t" + ie.Price + "€\n";
            }

        }




        //USELESS
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
