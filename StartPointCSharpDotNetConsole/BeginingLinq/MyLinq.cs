using System;
using System.Collections.Generic;
using System.Text;
namespace BeginingLinq
{
    public static class MyLinq
    {
        public static IEnumerable<T> where2<T>(  this IEnumerable<T> input, Func<T, bool> func)
        {
            //List<T> list = new List<T>();

            foreach (var item in input)
            {
                if (func(item)) yield return item;
                    //list.Add(item); 
            }
            //return list; 

        }

    }
}
