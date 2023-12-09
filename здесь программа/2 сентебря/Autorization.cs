using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2_сентебря
{
    public partial class Entry_window : Form
    {
        public Entry_window()
        {
            InitializeComponent();
        }

        int errors = 0;
        string answer;
        private void login_button_Click(object sender, EventArgs e)//вход после ввод логина и пароля
        {
            if (blockentry == true)
            {
                string login, password;
                login = login_textBox.Text;
                password = password_textBox.Text;
                SqlConnection con = new SqlConnection(Program_Class.connection);
                con.Open();
                SqlCommand logrequest = new SqlCommand();

                logrequest.CommandType = CommandType.StoredProcedure;
                logrequest.CommandText = "checkpassword";
                logrequest.Parameters.AddWithValue("@login", login);
                logrequest.Parameters.AddWithValue("@password", password);
                logrequest.Connection = con;
                SqlDataReader sqlDataReader = logrequest.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    Program_Class.user_id = (int)sqlDataReader.GetDouble(0);
                    Program_Class.role = (int)sqlDataReader.GetDouble(6);

                    this.Hide();
                    MainForm form = new MainForm();
                    form.Show();

                    errors = 0;
                }
                else
                {
                    errors++;
                    MessageBox.Show("Ошибка. Неправильно введён логин или пароль");
                    blockentry = false;
                    Capcha_textbox.Visible = true;
                    pictureBoxCapcha.Visible = true;
                    buttontrycapcha.Visible = true;

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    fillcapcha();
                
                if (errors > 1)
                    {
                        login_button.Enabled = false;
                        timer_for_blocking.Start();
                    }

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("сначала введите капчу");
            }
            
        }
        private void fillcapcha()//заполнение капчи
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            switch (value)
            {
                case 0:
                    answer = "6ne3";
                    break;
                case 1:
                    answer = "e5hb";
                    break;
                case 2:
                    answer = "xdhyn";
                    break;
            }
            pictureBox1.Image = imageList1.Images[value];
        }
        private void button2_Click(object sender, EventArgs e)//переход на главную форму
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void Entry_window_Load(object sender, EventArgs e)
        {
            Capcha_textbox.Visible = false;
            pictureBoxCapcha.Visible = false;
            buttontrycapcha.Visible = false;
            timer_for_blocking.Tick += new EventHandler(timer_for_blocking_Tick);
            timer_for_blocking.Interval = 10000;
        }

        private void timer_for_blocking_Tick(object sender, EventArgs e)
        {
            login_button.Enabled = true;
            timer_for_blocking.Stop();
        }
        bool blockentry = true;
        private void button1_Click(object sender, EventArgs e)
        {
            string txt = Capcha_textbox.Text.Trim();
            while (true)
            {
                if (txt == answer)
                {
                    Capcha_textbox.Visible = false;
                    pictureBoxCapcha.Visible = false;
                    buttontrycapcha.Visible = false;
                    blockentry = true;
                }
                else
                {
                    MessageBox.Show("Неверный ввод");
                    fillcapcha();
         
                }
            }
        }
    }
}