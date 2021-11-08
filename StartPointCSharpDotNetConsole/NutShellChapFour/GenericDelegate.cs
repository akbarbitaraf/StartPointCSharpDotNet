using System;
using System.Collections.Generic;
using System.Text;

namespace NutShellChapFour
{
    public delegate T Transfom<T>(T arg);

    public delegate void Bigger(int x);
    public class GenericDelegate
    {
        private decimal x = 21.7M;
        private int numbers;
        public int Numbers
        {
            get { return numbers; }
            set
            {
                if (value  >10) BiggerNumber(value);
                numbers = value;

            }
        }
        public event Bigger BiggerNumber;

       
        public static void Transformer<T>(T[] values, Func<T,T> t)
        {
           
           

            for (int i = 0; i < 10; i++)
            {

                values[i] = t(values[i]);
            }
        }
    }
}
