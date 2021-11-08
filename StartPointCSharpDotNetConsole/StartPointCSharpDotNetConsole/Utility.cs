using System;
using System.Collections.Generic;
using System.Text;

namespace StartPointCSharpDotNetConsole
{
    public delegate T transformer<T>(T x);
    
    class Utility
    {



        public void Transform<T>(T[] values , transformer<T> t)
        {

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }


        }

        public  int Square(int x) => x * x;
        

    }
}
