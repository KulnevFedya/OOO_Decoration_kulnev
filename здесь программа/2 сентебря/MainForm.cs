using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2_сентебря
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)//поиск
        {

            SqlConnection con = new SqlConnection(Program_Class.connection);
            DataSet dataset = new DataSet();

            SqlCommand profiletext = new SqlCommand();
            profiletext.CommandText = $"Select * FROM Product_catalog where [ ProductName ] like '%{search_textBox.Text}%'";
            profiletext.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
            adapter.Fill(dataset);
            int cnt_rows = 0;
            cnt_rows = dataset.Tables[0].Rows.Count;

            product_GridView.DataSource = dataset.Tables[0];

            if (product_GridView.DataSource != null)
                product_GridView.Columns[0].Visible = false;

            con.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program_Class.crtbtn == false)//скрытие кнопки корзины
            {
                BtnCheckCart.Visible = false;
            }
            else
            {
                BtnCheckCart.Visible = true;
            }

            if (Program_Class.role == 2 || Program_Class.role == 3)//скрытие кнопки для админов
            {
                btnAdminForm.Visible = true;
            }
            else
            {
                btnAdminForm.Visible = false;
            }

            SqlConnection con = new SqlConnection(Program_Class.connection);
            DataSet dataset = new DataSet();

            SqlCommand profiletext = new SqlCommand();
            profiletext.CommandText = $"Select * FROM Product_catalog";//заполнение таблицы продуктами
            profiletext.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
            adapter.Fill(dataset);
            int cnt_rows = 0;
            cnt_rows = dataset.Tables[0].Rows.Count;

            product_GridView.DataSource = dataset.Tables[0];

            if (product_GridView.DataSource != null)//скрываю ненужные столбцы
            {
                product_GridView.Columns[0].Visible = false;
                product_GridView.Columns[2].Visible = false;
                product_GridView.Columns[11].Visible = false;
            }

            con.Close();

            //здесь меняется шапка таблицы
            product_GridView.Columns[1].HeaderText = "Название товара";
            product_GridView.Columns[3].HeaderText = "Цена";
            product_GridView.Columns[4].HeaderText = "Максимальная скидка";
            product_GridView.Columns[5].HeaderText = "Производитель";
            product_GridView.Columns[6].HeaderText = "Поставщик";
            product_GridView.Columns[7].HeaderText = "Категория";
            product_GridView.Columns[8].HeaderText = "Скидка";
            product_GridView.Columns[9].HeaderText = "Количество на складе";
            product_GridView.Columns[10].HeaderText = "Описание";

            //проверка скидки каждого продукта и изменение цвета
            foreach (DataGridViewRow row in product_GridView.Rows)
                if (Convert.ToInt32(row.Cells[8].Value) > 15)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(byte)(127)), ((int)(byte)(255)), ((int)(byte)(0)));
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //переход в корзину
            this.Hide();
            Cart form = new Cart();
            form.Show();
        }

        private void product_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)//это не должно быть здесь вроде
        {
            if (selected_product != 0)
            {
                string product_name = "";
                SqlConnection con = new SqlConnection();

                con.ConnectionString = Program_Class.connection;
                con.Open();
                SqlCommand sqlCommand = new SqlCommand();
                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select Product_name FROM Products where Product_id = {selected_product}";
                profiletext.Connection = con;

                product_name = profiletext.ExecuteScalar().ToString();

                SqlCommand logrequest = new SqlCommand();
                logrequest.Connection = con;
                logrequest.CommandText = $"Select * from Products where Product_id = {selected_product}";
                SqlDataReader sqlDataReader = logrequest.ExecuteReader();

                sqlDataReader.Read();
                int cost = sqlDataReader.GetInt32(3);

                label_cost.Text = "" + cost;
            }
        }
        int selected_product = 0;
        private void product_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != null & e.RowIndex != -1)//при выборе элемента в таблице появлется текст в label и меняется картинка
                {

                    DataGridViewRow productdata = product_GridView.Rows[e.RowIndex];

                    product_name = productdata.Cells[10].Value.ToString();

                    label_description.Text = productdata.Cells[10].Value.ToString();
                    label_Provider.Text = productdata.Cells[6].Value.ToString();
                    label_cost.Text = productdata.Cells[3].Value.ToString();
                    if (productdata.Cells[11].Value.ToString() != "")
                    {
                        String imagename = Program_Class.folder + productdata.Cells[11].Value.ToString();
                        ProductPictureBox.Image = Image.FromFile(imagename);
                    }
                    else
                    {
                        String imagename = Program_Class.folder + "picture.png";//вывод картинки заглушки
                        ProductPictureBox.Image = Image.FromFile(imagename);
                    }
                    discount_label.Text = productdata.Cells[8].Value.ToString() + "%";//вывод скидки в правом окне

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            product_GridView.Sort(product_GridView.Columns[3], ListSortDirection.Ascending);//сортировка по возрастанию цены
        }

        private void button4_Click(object sender, EventArgs e)
        {
            product_GridView.Sort(product_GridView.Columns[3], ListSortDirection.Descending);//сортировка по убыванию цены
        }

        private void product_GridView_SelectionChanged(object sender, EventArgs e)
        {
            //double item = Convert.ToInt32(product_GridView.CurrentRow.Cells[0].Value);
            //label_description.Text = product_GridView.SelectedRows[1].Cells[0].Value.ToString();
            //tbModifyItemName.Text = item.ItemName;
        }

        private void comboBoxdiscount_SelectedIndexChanged(object sender, EventArgs e)//заполнение таблицы при сортировке по скидке
        {
            string DiscountText = comboBoxdiscount.SelectedItem.ToString();
            if (DiscountText == "все диапозоны")
            {
                SqlConnection con = new SqlConnection(Program_Class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM Product_catalog";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);
                int cnt_rows = 0;
                cnt_rows = dataset.Tables[0].Rows.Count;

                product_GridView.DataSource = dataset.Tables[0];
                con.Close();

            }
            else if (DiscountText == "0-9,99%")
            {
                SqlConnection con = new SqlConnection(Program_Class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM Product_catalog where ProductDiscountAmount < 10";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);
                int cnt_rows = 0;
                cnt_rows = dataset.Tables[0].Rows.Count;

                product_GridView.DataSource = dataset.Tables[0];

                con.Close();

            }
            else if (DiscountText == "10-14,99%")
            {

                SqlConnection con = new SqlConnection(Program_Class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM Product_catalog where ProductDiscountAmount >= 10 and ProductDiscountAmount <= 15";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);
                int cnt_rows = 0;
                cnt_rows = dataset.Tables[0].Rows.Count;

                product_GridView.DataSource = dataset.Tables[0];

                con.Close();

            }
            else
            {
                SqlConnection con = new SqlConnection(Program_Class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM Product_catalog where ProductDiscountAmount > 15";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);
                int cnt_rows = 0;
                cnt_rows = dataset.Tables[0].Rows.Count;

                product_GridView.DataSource = dataset.Tables[0];

                con.Close();
            }

            int rowsCount = ((DataTable)this.product_GridView.DataSource).Rows.Count;
            lblElementsAmount.Text = $"{rowsCount} / 30";//вывод количества продуктов в таблице
        }

        private void product_GridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentRow = e.RowIndex;
                int currentColumn = e.ColumnIndex;

                if (currentRow >= 0)
                {
                    product_GridView.Rows[currentRow].Selected = true;
                    Point point = product_GridView.PointToClient(Cursor.Position);
                    contextMenuStrip1.Show(product_GridView, point);//вывод контекстного меню
                }
            }
        }
        int value;

        string product_name;
        private void contextMenuStrip1_Click(object sender, EventArgs e)//добавление товара в корзину
        {
            Program_Class.crtbtn = true;
            BtnCheckCart.Visible = true;//кнопка перехода в корзину становится доступной

            string name = product_GridView.CurrentRow.Cells[1].Value.ToString();
            int cost = (int)product_GridView.CurrentRow.Cells[3].Value;
            int discount = (int)product_GridView.CurrentRow.Cells[8].Value;
            string article = product_GridView.CurrentRow.Cells[0].Value.ToString();
            int amount = 1;

            Order_cart cart = new Order_cart();

            cart.AddProduct(new Product { name = name, cost = cost, discount = discount, article = article, amount = amount });

        }

        private void btnAdminForm_Click(object sender, EventArgs e)
        {
            //переход на форму для админов
            this.Hide();
            form_for_admin form = new form_for_admin();
            form.Show();
        }
    }
}
