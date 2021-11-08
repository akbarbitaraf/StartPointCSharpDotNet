using System;
using System.Collections.Generic;
using System.Text;

namespace StartPointCSharpDotNetConsole
{
    public interface Iutility
    {
        public void Transform(int x); 

    }
    public delegate int Transformer(int x);
    class utility1        
    {
        //public void Transform(int[] values , Transformer t )
        //{
        //    for (int i = 0; i < values.Length; i++)
        //    {

        //        values[i] = t(values[i]);
        //    }

        //}
        //public void TransformAll(int[] values , Iutility t)
        //{
        //    for (int i = 0; i < values.Length; i++)
        //    {

        //        values[i] = t.Transform(values[i]);
        //    }

        //}
    }
}
