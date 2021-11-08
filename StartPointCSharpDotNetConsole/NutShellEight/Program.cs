using System;

namespace NutShellEight
{
    public delegate int Transformer(int x); 

    class Program
    {
        static void Main(string[] args)
        {
            ProgressBar progressBar = WriteProgressBarToConsole;
            progressBar += WriteProgressBarToFile;
            MultiCastDelegate.HardWork(progressBar); 
            Console.WriteLine("Hello World!");
        }

        public static void WriteProgressBarToConsole(int percentComplete) => Console.WriteLine(percentComplete);
        public static void WriteProgressBarToFile(int percentComplete) => System.IO.File.WriteAllText("progresss.txt", percentComplete.ToString());
        public int sums(int x, int y)
        {
            return x * y;
        }
        public static int sumlamb(int x, int y) =>x*y; 

        public static int  Square(int x)
        {
            return x * x;
        }
    }
}
