using System;
using System.Collections.Generic;
using System.Text;

namespace NutShellEight
{
    public delegate void ProgressBar(int PercentComplete); 
    public class MultiCastDelegate
    {
        public static void HardWork(ProgressBar p)
        {
            for (int i = 0; i <=10; i++)
            {
                p(i * 10);
                System.Threading.Thread.Sleep(100);
            }
        }

    }
}
