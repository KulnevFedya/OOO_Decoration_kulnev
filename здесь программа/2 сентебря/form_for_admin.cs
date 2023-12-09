using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_сентебря
{
    public partial class form_for_admin : Form
    {
        public form_for_admin()
        {
            InitializeComponent();
        }

        private void form_for_admin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program_Class.connection);
            DataSet dataset = new DataSet();

            SqlCommand profiletext = new SqlCommand();
            profiletext.CommandText = $"Select * FROM Orders_amount";
            profiletext.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
            adapter.Fill(dataset);
            int cnt_rows = 0;
            cnt_rows = dataset.Tables[0].Rows.Count;

            product_GridView.DataSource = dataset.Tables[0];

            if (product_GridView.DataSource != null)
            {
                product_GridView.Columns[0].Visible = false;
            }

            con.Close();
            product_GridView.Columns[1].HeaderText = "Дата заказа";
            product_GridView.Columns[2].HeaderText = "Дата доставки";
            product_GridView.Columns[3].HeaderText = "Пункт выдачи";
            product_GridView.Columns[4].HeaderText = "Id клиента";
            product_GridView.Columns[5].HeaderText = "Код";
            product_GridView.Columns[6].HeaderText = "Статус заказа";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void btnSortplus_Click(object sender, EventArgs e)
        {
            product_GridView.Sort(product_GridView.Columns[3], ListSortDirection.Ascending);//сортировка по возрастанию цены
        }

        private void btnSortminus_Click(object sender, EventArgs e)
        {
            product_GridView.Sort(product_GridView.Columns[3], ListSortDirection.Descending);//сортировка по убыванию цены
        }
    }
}
