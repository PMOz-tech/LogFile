using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace LogFile
{
    class Program
    {
     
        static void Main(string[] args)
        {
            var logFile = "log.txt";
            //File.Create(logFile);

            

            Stack<DateTime> timeDate = new Stack<DateTime>();

            for (int i = 0; i<20; i++)
            {
                timeDate.Push(DateTime.Now);
                Console.WriteLine(timeDate.Peek());
                Thread.Sleep(10000);

            }

            

            Console.WriteLine("- - - - - - - - - ");

            foreach (var milsec in timeDate)
            {
                Console.WriteLine(milsec);
                File.AppendAllLines(logFile, new String[] { milsec.ToString() });
            }
        }
    }
}
