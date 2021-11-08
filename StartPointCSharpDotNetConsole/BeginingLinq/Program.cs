using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace BeginingLinq
{
    class Program
    {


        static void Main(string[] args)
        {
      List<Persons> persons = new List<Persons>() {
            new Persons(){FirstName ="Akbar " ,LastName = "Bitaraf"  } , 
            new Persons(){FirstName = "Asghar" , LastName = "Mahdavi" } , 
            new Persons(){FirstName  = "Naser" , LastName = "Sadr" } ,
            new Persons(){FirstName  = "Mahdi" , LastName = "Namadi" },
            new Persons(){FirstName  = "Reza" , LastName = "Davoodi" },
            new Persons(){FirstName  = "Mohsen" , LastName = "Khori" },
            new Persons(){FirstName  = "Pouya" , LastName = "Samadi" }
           };
            // select Linq 
            // 1   - projection 2 - mapping 3- Transfering
            var resultselect = persons.Select(c => c.FirstName); 
            foreach (var item in resultselect)
            {
                Console.WriteLine(item); 
            }

            List<PersonFromExcel> personFromExcels = new List<PersonFromExcel>();
            string pathToEcellFile = $@"G:\ProjectMyself\StartPointCSharpDotNet\LinqfileData.xlsx";

            ConnectionExcel connectionExcel = new ConnectionExcel(pathToEcellFile);
            //var files = File.ReadAllLines(@$"G:\ProjectMyself\StartPointCSharpDotNet\LinqfileData.xlsx").Select(c =>
            //{
            //    var temp = c.Split(',');
            //  return  new PersonFromExcel {
            //        FirstName = temp[0],
            //        LastName = temp[1],
            //        NationalID =long.Parse( temp[2])  

            //};

            //});
            //foreach (var item in files)
            //{

            //}
            var personFromExcels1 = connectionExcel.Connections.Worksheet<PersonFromExcel>("Sheet1");
            var family = personFromExcels1.Select(x => x.LastName);
            foreach (var item in family)
            {
                Console.WriteLine(item); 
            }

            //var xx = from a in connectionExcel.Connections.Worksheet<PersonFromExcel>("Sheet1")
            //             select a;
          

            var result = persons.where2(c => c.LastName.Contains("d"));
            foreach (var item in result)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName } ");
            }
            Console.WriteLine("-------------------------------------------"); 
            var result1 = persons.Where(c => c.LastName.Contains("d"));
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName } "); 

            }
        }
    }
}
