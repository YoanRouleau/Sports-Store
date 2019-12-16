using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Store
{
    public class Item
    {

        private int id;
        private String name;
        private Double price;
        private String category;


        public Item(int pId, String pName, Double pPrice, String pCategory)
        {
            this.Id = pId;
            this.Name = pName;
            this.Price = pPrice;
            this.Category = pCategory;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Double Price
        {
            get { return price; }
            set { price = value; }
        }

        public String Category
        {
            get { return category; }
            set { category = value; }
        }


    }
}
