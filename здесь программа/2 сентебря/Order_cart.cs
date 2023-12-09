using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2_сентебря
{
    class Product
    {
        public string name { get; set; }
        public int cost { get; set; }
        public int discount { get; set; }
        public string article { get; set; }
        public int amount { get; set; }
    }
     class Order_cart
    {
        private List<Product> products;
        public Order_cart()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                products.RemoveAt(index);
            }
        }
        public decimal CalculateTotal()//возвращает сумму
        {
            decimal total = 0;

            foreach (var product in products)
            {
                total += product.cost;
            }

            return total;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public void PlaceOrder()//формирование заказа
        {
            decimal total = CalculateTotal();

            SqlConnection con1 = new SqlConnection(Program_Class.connection);
            con1.Open();

            Product product2 = new Product();
            string productarticle = product2.article;
            int productamount = product2.amount;

           /* DataTable productsTable = new DataTable();
            productsTable.Columns.Add("ProductArticle", typeof(string));
            productsTable.Columns.Add("ProductAmount", typeof(int));

            foreach (var product in GetProducts())
            {
                productsTable.Rows.Add(product.article, product.amount);
            }
           */
            using (SqlCommand logrequest = new SqlCommand("AddOrder1", con1))
                {
                logrequest.CommandType = CommandType.StoredProcedure;

                logrequest.Parameters.AddWithValue("@Article_number", productarticle);//здесь возможно productsTable у меня не получилось с ним
                logrequest.Parameters.AddWithValue("@Order_amount", productamount);
                logrequest.ExecuteNonQuery();
                }
            products.Clear();
            con1.Close();
        }

          
        }
    }
    

