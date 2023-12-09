using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _2_сентебря
{
    public partial class Cart : Form
    {
        private ListBox listBox;

        private Order_cart cart;
        public Cart()
        {
            InitializeComponent();
            cart = new Order_cart();
        }

        private void button1_Click(object sender, EventArgs e)//переход на главную форму
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
        private void UpdateListBox()
        {
            listBoxproduct.Items.Clear();
            foreach (var product in cart.GetProducts())
            {
                listBoxproduct.Items.Add(product);
            }
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            UpdateListBox();

            string Sql = "select PointOfIssue from point_of_issues";
            SqlConnection con = new SqlConnection(Program_Class.connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);//заполнение комбобокса пункатми выдачи
            }

            Order_cart cart = new Order_cart();
            decimal total = cart.CalculateTotal();
            labelSum.Text = $"Общая сумма {total}руб.";

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)//вывод фото
        {
            if (listBox.SelectedIndex != -1)
            {
                Product selectedProduct = (Product)listBox.SelectedItem;
                string article = selectedProduct.article;

                ProductPictureBox.Image = Image.FromFile(Program_Class.folder + article);
            }
        }

        private void button2_Click(object sender, EventArgs e)//оформить заказ
        {
            if (listBoxproduct.Items.Count == 0)
            {
                MessageBox.Show("В корзине ничего нет");
            }
            else
            {

                SqlConnection con = new SqlConnection(Program_Class.connection);
                con.Open();
                SqlCommand logrequest = new SqlCommand();
                logrequest.CommandType = CommandType.StoredProcedure;
                logrequest.CommandText = "AddOrder";
                logrequest.Connection = con;

                var order_date = DateTime.Now;
                var delivery_date = DateTime.Now.AddDays(6);//тут или 3 или 6
                Random randnum = new Random();
                int randomNum1 = randnum.Next(100, 999);//генерируется код

                string Issue_Text = comboBox1.SelectedItem.ToString();
                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select id_PointOfIssue FROM point_of_issues where PointOfIssue = {Issue_Text}";
                profiletext.Connection = con;
                SqlDataReader sqlDataReader = logrequest.ExecuteReader();

                sqlDataReader.Read();
                int point_of_issue = sqlDataReader.GetInt32(0);//запись в переменную id выбранного пункта выдачи

                logrequest.Parameters.AddWithValue("@order_date", order_date);
                logrequest.Parameters.AddWithValue("@delivery_date", delivery_date);
                logrequest.Parameters.AddWithValue("@point_of_issue", point_of_issue);
                logrequest.Parameters.AddWithValue("@client_id", Program_Class.user_id);
                logrequest.Parameters.AddWithValue("@code", randomNum1);
                logrequest.Parameters.AddWithValue("@status", 0);

                logrequest.ExecuteNonQuery();

                cart.PlaceOrder();

                MessageBox.Show($"Заказ оформлен, Код для получения:{randomNum1}");
                UpdateListBox();

            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (listBoxproduct.SelectedIndex >= 0)
            {
                cart.RemoveProduct(listBoxproduct.SelectedIndex);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
