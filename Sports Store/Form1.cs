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

    public partial class Form1 : Form
    {
        public static List<Item> stock = new List<Item>();
        public static List<Item> basket = new List<Item>();

        public Form1()
        {
            stock.Add(new Item(1, "Vans Ultrarange - White", 99.99));
            stock.Add(new Item(4, "Nike Air MAX 97", 169.99));
            stock.Add(new Item(167, "Adidas Runfalcon - Yellow/Black", 75.99));
            stock.Add(new Item(168, "Adidas Runfalcon - Orange", 75.99));
            stock.Add(new Item(25, "ASICS Polo club - Grey", 35.99));
            stock.Add(new Item(27, "Yonex short team ym004 - White", 26.90));
            stock.Add(new Item(25, "Kawasaki T-shirt s1128 - Blue/Black", 31.50));
            stock.Add(new Item(26, "Kawasaki T-shirt s1128 - Blue/White", 31.50));
            stock.Add(new Item(337, "Deluxe Hammertone Dumbbell Kit | 35kg", 88.55));
            stock.Add(new Item(337, "Strength Master 8118 Single Station Gym", 199.99));
            stock.Add(new Item(337, "Adidas swimming goggles - Pink", 15.99));

            InitializeComponent();
            dgvItemList.DataSource = stock;


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "test";
            btn.Name = "btnClmAddToBasket";
            btn.Text = "Add to cart";
            btn.UseColumnTextForButtonValue = true;
            dgvItemList.Columns.Add(btn);


        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbBasket.Clear();

            if (e.ColumnIndex == 3)
                basket.Add(new Item(stock[e.RowIndex].Id, stock[e.RowIndex].Name, stock[e.RowIndex].Price));
            if (e.ColumnIndex == 1)
                MessageBox.Show(stock[e.RowIndex].Name);

            foreach(Item ie in basket)
            {
                rtbBasket.Text = rtbBasket.Text 
                                + ie.Name + "\t" + ie.Price+ "\t" + "\n";
            }
            
            
        }

        private void rtbItemList_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
