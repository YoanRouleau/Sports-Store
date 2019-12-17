using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Store
{
    public class Order
    {

        private int reference;
        private DateTime dateOfOrder;
        private List<Item> orderBasket;
        private DateTime dateOfDelivery;
        private Double price;
        private String firstname;
        private String lastname;
        private String address;
        private String postcode;
        private String city;

        //Ctor for "Retrieve in store" Orders
        public Order(int pReference, DateTime pDateOfOrder, List<Item> pOrderBasket, Double pPrice, 
            String pFirstname, String pLastName)
        {
            this.Reference = pReference;
            this.DateOfOrder = pDateOfOrder;
            this.OrderBasket = pOrderBasket;
            this.Price = pPrice;
            this.Firstname = pFirstname;
            this.Lastname = pLastName;
        }

        //Ctor for "Delivery" Orders
        public Order(int pReference, DateTime pDateOfOrder, DateTime pDateOfDelivery, List<Item> pOrderBasket, Double pPrice,
            String pFirstname, String pLastName, String pAddress, String pPostCode, String pCity)
        {
            this.Reference = pReference;
            this.DateOfOrder = pDateOfOrder;
            this.DateOfDelivery = pDateOfDelivery;
            this.OrderBasket = pOrderBasket;
            this.Price = pPrice;
            this.Firstname = pFirstname;
            this.Lastname = pLastName;
            this.Address = pAddress;
            this.Postcode = pPostCode;
            this.City = pCity;
        }


        public int Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public DateTime DateOfOrder
        {
            get { return dateOfOrder; }
            set { dateOfOrder = value; }
        }

        public List<Item> OrderBasket
        {
            get { return orderBasket; }
            set { orderBasket = value; }
        }

        public DateTime DateOfDelivery
        {
            get { return dateOfDelivery; }
            set { dateOfDelivery = value; }
        }
        
        public Double Price
        {
            get { return price; }
            set { price = value; }
        }

        public String Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public String City
        {
            get { return city; }
            set { city = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
