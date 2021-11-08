using System;
using System.Text.RegularExpressions;

namespace StartPointCSharpDotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "تست";
            var ww = sample.ValidationPersianAndEnglishAndNumericString();
            int[] arr = { 0, 1, 2, 3, 0, 1 };
            decimal xx = 0.987650M;
            decimal xx1 = 123.987650M;
            Console.WriteLine(xx.ToString("G4")); 
            Console.WriteLine(xx1.ToString("G4")); 


            string result = string.Join(",", arr);
            string outs = @$"delete from sale.onlinesalepaymenttype where id  in ("+result + ")" ;
            Console.WriteLine(arr);
            Console.WriteLine(result);
            Console.WriteLine(outs);

            return;


            var obj = "TV";
            var name = @$"api.common." + obj + @$".PC.name"; 

            //string name;

            //switch (obj)
            //{
            //    case "Book":
            //        name = api.common.Book.Name;
            //        break;

            //    case "Mobile":
            //        name = api.common.Mobile.Name;
            //        break;

            //    case "PC":
            //        name = api.common.PC.Name;
            //        break;
            //}
            bool y = true;
            var yy = y.ToBool();
            var xxxx = Convert.ToBoolean(null);
            var yy1 = y.ToBool1();
            string y2 = "1";
            var yy2 = y2.ToBool();
            var yy21 = y2.ToBool1();
            int f = 1;
            var ff = f.ToBool();
            string d= "true";
            var dd =d.ToBool(); 
            int y3 = 1;
            var yy3 = y3.ToBool1();
            //bool? xy = 1 ;
            //var xyy = xy.ToBool();
            //var xyy1 = xy.ToBool1();


            decimal x = 1125.2115M;
            Console.WriteLine("{0:N0}" , x);
            return; 

            //Utility utility = new Utility();
            //transformer t = utility.Square;
            int[] values = { 1, 2, 3, 4, 5, 6 };

            //Transformer t =Square;
            //utility.Transform(values, t); 

            utility1 util = new utility1();

            //util.Transform(values, t); 
            //foreach (var item in values)
            ////{
            //    Console.WriteLine("values : " +item + "/n"); 
            //}
            //return; 
            //Students students = new Students("asghar", "hoseini");
            Students student = new Students();
            Students student1 = new Students(); 


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
        public static int Square(int x) => x * x;
        public static bool CheckSqlInjection(string str)
        {
            var rex = new Regex(@"^.*(\s|\t|\n|;|'|\S)*(drop)+(\s|\t|\n|\S)+.*$", RegexOptions.IgnoreCase);
            if (rex.IsMatch(str))
                return false;
            return true;
        }

    }
    public static class ValidationPersianEngNum
    {

        public static bool ValidationPersianAndEnglishAndNumericString(this string str)
        {
            str = "_تست/مشتري";
            var str1 = "تست^مشتری_";
            var dd = "[\u0622\u0627\u0628\u062A\u062B\u062C\u062D\u062E\u062F-\u0639\u063A\u0641-\u0648\u0650\u067E\u0686\u0698\u06A9\u06AF\u06BE\u06CC\u0020\u2000-\u200F\u2028-\u202F\u005F\u002D\u06F0-\u06F9\u0030-\u0039]";
            var pattern = @"^[\u0622\u0627\u0628\u062A\u062B\u062C\u062D\u062E\u062F-\u0639\u063A\u0641-\u0648\u0650\u067E\u0686\u0698\u06A9\u06AF\u06BE\u06CC\u0020\u2000-\u200F\u2028-\u202F\u005F\u002D\u06F0-\u06F9\u0030-\u0039\u0061-\u0079\u006A-\u006F\u0041-\u0059\u004A-\u004F]+$";
            var rex = Regex.IsMatch(str ,pattern );
            
            return false;
        }

    }


}
