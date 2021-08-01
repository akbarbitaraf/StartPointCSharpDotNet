using System;
using System.Text.RegularExpressions;

namespace StartPointCSharpDotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //RegexType = RegexType.ComplicatedPassWord, 
            //    RegexTitle = "کلمه عبور پیچیده", 
            //    RegexDefaultStr = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$" ,
            //    RegexDescription = " شکل صحیح کلمه عبور شامل اعداد و حروف کوچک وبزرگ و حداقل یک کاراکتر خاص  می باشد.  طول رشته بین 8 تا 15 کاراکتر می باشد"
            Console.WriteLine("Hello World!");
            string poo = "drop ";
            string poo1 = ";drop table";
            string poo2 = "exec('drop table dbo.test11')";
            string poo3 = "nodrop";
            string poo4 = " dropno";
            string poo5 = "hellodrop";
            string poo6 = "helloDrop";
            string poo7 = "DropDrop";
            string poo8 = " Drop ";
            string poo9 = " drop ";
            string poo10 = " drop     ";
            string poo11 = @"drop 
                        table";

            string poo12 = "select drop  top 1 * from wm.saleinvoice";
            string poo13 = "'drop ";


            Console.WriteLine(CheckSqlInjection(poo));
            Console.WriteLine(CheckSqlInjection(poo1));
            Console.WriteLine(CheckSqlInjection(poo2));
            Console.WriteLine(CheckSqlInjection(poo3));
            Console.WriteLine(CheckSqlInjection(poo4));
            Console.WriteLine(CheckSqlInjection(poo5));
            Console.WriteLine(CheckSqlInjection(poo6));
            Console.WriteLine(CheckSqlInjection(poo7));
            Console.WriteLine(CheckSqlInjection(poo8));
            Console.WriteLine(CheckSqlInjection(poo9));
            Console.WriteLine(CheckSqlInjection(poo10));
            Console.WriteLine(CheckSqlInjection(poo11));
            Console.WriteLine(CheckSqlInjection(poo12));
            Console.WriteLine(CheckSqlInjection(poo13));
            //string str= "create table test1(id int )drop5 table test1";
            Console.ReadLine();
        }
        public static bool CheckSqlInjection(string str)
        {
            var rex = new Regex(@"^.*(\s|\t|\n|;|'|\S)*(drop)+(\s|\t|\n|\S)+.*$", RegexOptions.IgnoreCase);
            if (rex.IsMatch(str))
                return false;
            return true;
        }

    }
}
