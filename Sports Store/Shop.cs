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

    public partial class Shop : Form
    {
        public static List<Item> stock = new List<Item>();
        public static List<Item> filteredStock = new List<Item>();
        public static List<Item> basket = new List<Item>();
        public static double totalPrice = 0;

        ItemList myBasket;

        public Shop()
        {
            stock.Add(new Item(1, "Vans Ultrarange - White", 99.99, "Foot Wear"));
            stock.Add(new Item(4, "Nike Air MAX 97", 169.99, "Foot Wear"));
            stock.Add(new Item(167, "Adidas Runfalcon - Yellow/Black", 75.99, "Foot Wear"));
            stock.Add(new Item(168, "Adidas Runfalcon - Orange", 75.99, "Foot Wear"));
            stock.Add(new Item(25, "ASICS Polo club - Grey", 35.99, "Sports Clothing"));
            stock.Add(new Item(27, "Yonex short team ym004 - White", 26.90, "Sports Clothing"));
            stock.Add(new Item(25, "Kawasaki T-shirt s1128 - Blue/Black", 31.50, "Sports Clothing"));
            stock.Add(new Item(26, "Kawasaki T-shirt s1128 - Blue/White", 31.50, "Sports Clothing"));
            stock.Add(new Item(337, "Deluxe Hammertone Dumbbell Kit | 35kg", 88.55, "Gym Equipment"));
            stock.Add(new Item(337, "Strength Master 8118 Single Station Gym", 199.99, "Gym Equipment"));
            stock.Add(new Item(337, "Adidas swimming goggles - Pink", 15.99, "Accessories"));

            myBasket = new ItemList();

            InitializeComponent();

            //Fill the Item list DataGridView with all available items
            dgvItemList.DataSource = stock;

            

            //Add a button column to the Item list DataGridView stuffed with a "ADD TO CART" button
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = " ";
            btn.Name = "btnClmAddToBasket";
            btn.Text = "Add to cart";
            btn.UseColumnTextForButtonValue = true;
            dgvItemList.Columns.Add(btn);

            //Add a button column to the Basket DataGridView stuffed with a "REMOVE" button
            DataGridViewButtonColumn supprBtn = new DataGridViewButtonColumn();
            supprBtn.HeaderText = " ";
            supprBtn.Name = "btnClmAddToBasket";
            supprBtn.Text = "Remove";
            supprBtn.UseColumnTextForButtonValue = true;
            dgvBasket.Columns.Add(supprBtn);

        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //rtbBasket.Clear();

            //Handles ADD-TO-CART action for the UNfiltered item list
            if(filteredStock.Count == 0)
            {
                //If "ADD TO CART" button clicked -> getting the object and adding it to basket
                if (e.ColumnIndex == 3) {

                    //Create new basket item from clicked item in the dgv
                    myBasket.basketToCheckout.Add(new Item(stock[e.RowIndex].Id, stock[e.RowIndex].Name,
                                            stock[e.RowIndex].Price, stock[e.RowIndex].Category));

                    //Duplicate basket into the transition collection
                    basket = myBasket.basketToCheckout;

                    //Increment order's total price with the added item's price
                    totalPrice += stock[e.RowIndex].Price;

                    //Refresh basket
                    dgvBasket.DataSource = null;
                    dgvBasket.DataSource = basket;
                }    
                    

                if (e.ColumnIndex == 1)     //If description clicked -> Show object's details
                    MessageBox.Show(stock[e.RowIndex].Name);
            }

            //Handles ADD-TO-CART action for the filtered item list
            else
            {
                if (e.ColumnIndex == 3)
                {
                    myBasket.basketToCheckout.Add(new Item(filteredStock[e.RowIndex].Id, filteredStock[e.RowIndex].Name,
                                            filteredStock[e.RowIndex].Price, filteredStock[e.RowIndex].Category));

                    basket = myBasket.basketToCheckout;
                    totalPrice += filteredStock[e.RowIndex].Price;

                    dgvBasket.DataSource = null;
                    dgvBasket.DataSource = basket;
                }     
                    

                if (e.ColumnIndex == 1)
                    MessageBox.Show(filteredStock[e.RowIndex].Name);
            }

            txtAmount.Text = "Total: " + Math.Round(totalPrice, 2).ToString() + "€";
        }

        private void cbFilterByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the filtration category
            string filter = cbFilterByCategory.Text;

            //If category matches -> display a new arraylist composed of filtered items
            if (filter != "All")
            {
                foreach (Item ie in stock)
                {
                    if (ie.Category == filter)
                        filteredStock.Add(ie);
                }
                dgvItemList.DataSource = filteredStock;
            }
            
            //... Or displays all the items (= unfiltered research)
            else
            {
                filteredStock.Clear();  //reset the filtered stock list
                dgvItemList.DataSource = stock;
            }
        }


        private void btnClearBasket_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to empty your current Basket ?";
            DialogResult button = MessageBox.Show(message, "Confirm",
                MessageBoxButtons.OKCancel);

            if (button == DialogResult.OK)
            {
                //Empty the basket arraylist                
                basket.Clear();

                //Refresh Basket's datagridview
                dgvBasket.DataSource = null;
                dgvBasket.DataSource = basket;
                
                //Reset price display
                txtAmount.Text = "Total: ";
                
                //Reset order amount
                totalPrice = 0;     
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut toCheckOut = new CheckOut(myBasket);
            toCheckOut.ShowDialog();
        }

        private void dgvBasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string message = "Remove this item from the basket?";
                DialogResult button = MessageBox.Show(message, "Confirm",
                    MessageBoxButtons.OKCancel);

                if (button == DialogResult.OK)
                {
                    //Create a temporary object for the deleted item
                    Item ri = new Item(basket[e.RowIndex].Id, basket[e.RowIndex].Name,
                                            basket[e.RowIndex].Price, basket[e.RowIndex].Category);

                    //Remove clicked item from basket
                    basket.RemoveAt(e.RowIndex);

                    //Update Price
                    totalPrice -= ri.Price;

                    //Refresh Basket's datagridview
                    dgvBasket.DataSource = null;
                    dgvBasket.DataSource = basket;
                    dgvBasket.Refresh();

                    //Update Price display
                    txtAmount.Text = "Total: " + Math.Round(totalPrice, 2).ToString() + "€";
                }
            }
        }



        //USELESS
        private void rtbItemList_TextChanged(object sender, EventArgs e)
        {


        }

        //USELESSs
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
