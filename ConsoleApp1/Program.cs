using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Animation;
using System.Threading;
using System.Text.RegularExpressions;
//namespace ConsoleApp1

//{
public enum Animals
{
    Dog,
    Cat,
    Mouse,
    Human,
    Python

}
public delegate void SongDelegate();
class Program
{

    public event Action Songing;
    public Action CustomSong;
    public static Int32 Stop = 0;
    public static Int32 Count = 0;
    private static Process _CurrentProcess = Process.GetCurrentProcess();
    public void OnSong()
    {
        this.Songing?.Invoke();
    }
    [Conditional("RELEASE")]
    public void ConditionTest()
    {
        Console.WriteLine("Conditional test");
    }
    static void Main(string[] args)
    {
        
        List<FrameGenerator> list = new List<FrameGenerator>();

        HashSet<FrameGenerator> set = new HashSet<FrameGenerator>();
        Random r = new Random();
        Int32 count = 100;
        //for (Int32 i = 0; i < 100000000; ++i)
        //{
        //    Int32 data = r.Next(2000);
        //    list.Add(data);
        //    set.Add(data);
        //}
        Int32 time = 1000;
        FrameGenerator init = new FrameGenerator(FPSMode.Limited30);
        Stopwatch watch = new Stopwatch();
        init.Start();

        watch.Start();
        for (Int32 i = 0; i < count; ++i)
        {
            //  Int32 data = r.Next(2000);
            FrameGenerator generator = new FrameGenerator(FPSMode.Unlimited);
            list.Add(generator);
            generator.FrameHappend += Generator_FrameHappend;
            generator.Start();
            //   set.Add(data);
        }
        //foreach (Int32 i in list)
        //{

        //}
        //list.RemoveAll(t=>t>100);
        FrameGenerator g = new FrameGenerator();
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);
       System.Timers.Timer timer = new System.Timers.Timer(time);
        timer.Elapsed += (s,e) =>
         {
             Interlocked.Increment(ref Stop);
            Console.WriteLine("Count :" + Count.ToString() + " FPS:" + (Count*1.0 / (time / 1000)/count).ToString());
             Interlocked.Exchange(ref Count,0);
             //Console.WriteLine(
             //        $"{Round((decimal)((_CurrentProcess.TotalProcessorTime.TotalMilliseconds - _cpuUsage) / _stopWatch.ElapsedMilliseconds) * (decimal)(100f / Environment.ProcessorCount))} % - {Environment.ProcessorCount} Cores");
         };
        timer.Start();
        Console.Read();
        watch.Restart();
        for (Int32 i = 0; i < count; ++i)
        {
            //  Int32 data = r.Next(2000);
            FrameGenerator generator = new FrameGenerator();
            set.Add(generator);
            //   set.Add(data);
        }
        //foreach (Int32 i in set)
        //{

        //}
        //set.RemoveWhere(t=>t>100);
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);
    }
    private float Round(decimal n)
    {
        return (float)Math.Round(n, 2);
    }
    private static void Generator_FrameHappend(FrameGenerator arg1, Object arg2)
    {
      //  if (Stop == 0)
            Interlocked.Increment(ref Count);
    }

    static void DogSong()
    {
        Console.WriteLine("wa wa wa ");
    }
    static void CatSong()
    {
        Console.WriteLine("miao mioo miao !");
    }
}
//}
