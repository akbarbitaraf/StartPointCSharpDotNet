using System;
using System.Collections;
using System.Collections.Generic;


namespace NutShellChapFour
{

    public class Enumerators : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    public class Enemerables : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        public static IEnumerable<int> Fibs(int fibCount)
        {

            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }

        }

        static void Main(string[] args)
        {

            foreach (int fib in Fibs(6))
            {
                Console.WriteLine(fib +  "");
            } 
            try
            {
                int j = 0;
                var kk = 10 / j;
                Console.Write("OK");
            }
            catch (Exception ex) when (ex.Message == "")
            {

                throw;
            }
            catch
            {

                throw new Exception();
            }

            Action[] a = new Action[3];
            for (int i = 0; i < 3; i++)
            {
                int j = i;
                a[i] = () => Console.WriteLine(j);
            }
            foreach (Action aa in a)
            {
                aa();
            }

            Transformer sql = x => x * x;
            Func<int, int> sql1 = x => x * x;

            Stock s = new Stock("TH");
            s.PriceChanged += S_PriceChanged;
            s.Price = 12.20M;
            s.Price = 14.20M; 
            s.Price = 17.20M; 
            s.Price = 27.02M;
            int x = sql(3);
            int x1 = sql1(4);


        Console.WriteLine("Hello World!");
            GenericDelegate t = new GenericDelegate();
            t.BiggerNumber += new Bigger(ShowNum);
            for (int i = 9; i < 100; i++)
            {
                t.Numbers = i; 
            }
            
        }
    

        private static void S_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            var senders = sender.GetType();
            if ( e.LastPrice != 0 && (e.NewPrice -e.LastPrice)/e.LastPrice > 0.1M )
            {
                Console.WriteLine("Change is Bigger 10 % ");
            }
        }

        public static void ShowNum(int x)
        {
            Console.WriteLine($@"this is number bigger from 10 : {x}");
        }
    }
}
