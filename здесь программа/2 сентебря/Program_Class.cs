using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_сентебря
{
    internal class Program_Class
    {
        //public static string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=kulnev_isp401;Data Source=MEPHI3-MSSQL"; мифи
        public static string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=kulnev_isp401;Data Source=WIN-6O75T8J3087\MSSQLSERVER1";//дом
        public static int user_id = 0;
        public static int role = 0;
        public static string folder = "E:\\4 курс\\Вариант 4\\здесь программа\\2 сентебря\\photo\\";
        //public static Dictionary<string, int> products_in_basket = new Dictionary<string, int>();//словарь для продуктов в корзине. Он не используется
        public static bool crtbtn = false;
}
}
