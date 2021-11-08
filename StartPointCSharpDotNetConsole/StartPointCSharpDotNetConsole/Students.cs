using System;
using System.Collections.Generic;
using System.Text;

namespace StartPointCSharpDotNetConsole
{
    public class Stack<T>
    {

        int position;
        T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop(T obj) => data[--position];

        public void Swap<T> (ref T a , ref T b)
        {


        }
         

    }
    class Students
    {
        public const string City = "Mashhad";
        public readonly string Province;
        public static readonly string FullName;
        private string name = "akbar"; 
        private string family = "bitaraf";
        private decimal currentPrice; 
        public decimal currentPriceP
        {

            get {
                return currentPrice;
            }
            set
            {

                currentPrice = value;
            }
        }
        static Students()
        {
            Console.WriteLine("Static constructor first"); 
            //Province = "Khorasan";
            

        }
        public Students(string name)
        {
            this.name = name;

        }
        public Students(string name ,string family): this(name) {

            this.family = family;
            Console.WriteLine("NAME:\n" + this.name + "family:\n"+ this.family); 
        }

        public Students()
        {
        }
    }
}
