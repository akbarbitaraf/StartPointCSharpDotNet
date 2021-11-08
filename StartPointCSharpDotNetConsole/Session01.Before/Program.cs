using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Session01.Before
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persons> person = new List<Persons>() { 
            new Persons(){FirstName = "Akbar" , LastName = "Bitaraf"} , 
            new Persons(){FirstName = "Amir" , LastName = "Hoseini"} , 
            new Persons(){FirstName = "Yasna" , LastName = "Mahdavi"}
            };

            var result = person.Where(SelectPersons); // Mewthod Name 
            var result1 = person.Where(delegate (Persons input) // AnonyMous Method
            {
                return input.LastName.Contains("A");
            });
            var result2 = person.Where(input=>input.LastName.Contains("A")); // Lambda Expressions




          
         static bool SelectPersons(Persons input) {

               return input.LastName.Contains("A");  
            } 



            ShowDirectoryWithoutLing(@"C:\windows"); 
            ShowDirectoryWithLing(@"C:\windows");
            Console.ReadLine();
        }

        private static void ShowDirectoryWithLing(string path)
        {
            List<string> s = new List<string>() ;
            s.MyCounts<string>();  
            var allfiles = new DirectoryInfo(path).GetFiles().OrderByDescending(c => c.Length);
            foreach (var item in allfiles)
            {
                Console.WriteLine($"{item.Name} \t {item.Length}");
            }
       
            
        }

        private static void ShowDirectoryWithoutLing(string path)
        {

            DirectoryInfo directory = new DirectoryInfo(path);
            var allfiles = directory.GetFiles();
            Array.Sort(allfiles ,new FileInfoComparer() );
               foreach (var item in allfiles)
            {
                Console.WriteLine($"{item.Name} \t {item.Length}"); 
            }
            Console.WriteLine("*************************************************"); 
 
        }
    }
    public class FileInfoComparer : IComparer<FileInfo>
    {
        int IComparer<FileInfo>.Compare(FileInfo x, FileInfo y)
        {
            if (x.Length > y.Length)
                return -1;
            if (x.Length == y.Length)
                return 0;
            return 1 ;
        }
    }
    public static class MyCount
    {
        public static int MyCounts<T>(this IEnumerable<T> input)
        {
            return input.Count(); 
        }
   

    }
    public  class Persons
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
