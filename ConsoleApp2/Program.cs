using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single test = 16777228;
            //Console.WriteLine(test.ToString("R"));
            //test++;
            //Console.WriteLine(test.ToString("R"));
            //test++;
            //Console.WriteLine(test.ToString("R"));
            //test++;
            //Console.WriteLine(test.ToString("R"));
            //return;
            Int32 count = 16777226;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Int32 integer = 0;
          
            for (Int32 i = 1; i < count; ++i)
            {
               // Int64 test = DateTime.Now.Ticks / 10000;
            //   Int64 test = watch.ElapsedMilliseconds;
                //integer = integer + i;
                //integer = integer - i;
                //integer = integer * i;
                //integer = integer / i;
            }
            watch.Stop();
            Console.WriteLine("Integer:" + watch.ElapsedMilliseconds.ToString());

            return;
            watch.Restart();
            Double doubleNum = 0;
            for (Double i = 1; i < count; ++i)
            {
                doubleNum = doubleNum + i;
                doubleNum = doubleNum - i;
                doubleNum = doubleNum * i;
                doubleNum = doubleNum / i;
            }
            watch.Stop();
            Console.WriteLine("Double:" + watch.ElapsedMilliseconds.ToString());
            watch.Restart();
            Single floatNum = 0;

            Int32 index = 0;
            for (Single i = 16777216; i < 16777224;i+=2)
            {
                index++;
                floatNum = floatNum + i;
                floatNum = floatNum - i;
            }
            watch.Stop();
            Console.WriteLine("Index:"+ index.ToString());
            Console.WriteLine("Single:" + watch.ElapsedMilliseconds.ToString());

         
        }
    }
}
