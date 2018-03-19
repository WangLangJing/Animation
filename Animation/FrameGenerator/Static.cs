using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Animation
{
    public partial class FrameGenerator
    {
        public const Int32 SEC_MS = 1000;
        private static HashSet<FrameGenerator>[] _GeneratorLines = null;
        private static Object _SyncObj = new Object();
        private static Thread _CycleDispatcher = null;
        private static Stopwatch _Watch = null;
        private static Int32 _Count = 0;
        private static Int32 _HasCode = 1;
        private readonly static Int32 _FreeLineIndex = 1;
        private readonly static Int32 _WorkLineIndex = 0;

        public static Int32 Count
        {
            get => _Count;
            set
            {
                Interlocked.Exchange(ref _Count, value);
            }
        }
        private static Int32 GenerateHashCode()
        {
            return Interlocked.Increment(ref _HasCode);
        }
        private static Int32 AddGenerator(FrameGenerator gen)
        {
            lock (_SyncObj)
            {
                var freeLine = GetFreeLine();
                lock (freeLine)
                {
                    if (!freeLine.Contains(gen))
                    {
                        freeLine.Add(gen);
                        return ++Count;
                    }
                    return Count;
                }
            }
        }
        private static Int32 RemoveGenerator(FrameGenerator gen)
        {
            lock (_SyncObj)
            {
                var freeLine = GetFreeLine();
                if (freeLine.Contains(gen))
                {
                    freeLine.Remove(gen);
                    return --Count;
                }
                return Count;
            }
        }
        static FrameGenerator()
        {
            InitDispatcher();
        }
        private static void InitDispatcher()
        {
            _GeneratorLines = new HashSet<FrameGenerator>[2] {
                new HashSet<FrameGenerator>(),
                new HashSet<FrameGenerator>()
            };
            _Watch = new Stopwatch();
            _CycleDispatcher = new Thread(CycleDispatch);
            _Watch.Start();
            _CycleDispatcher.Start();

        }
        private static void SyncWorkLine()
        {
            lock (_SyncObj)
            {
                var freeLine = _GeneratorLines[_FreeLineIndex];
                var workLine = _GeneratorLines[_WorkLineIndex];

                foreach (FrameGenerator gen in freeLine)
                {
                    if (gen.Started && !workLine.Contains(gen))
                    {
                        workLine.Add(gen);
                    }
                    if (!gen.Started && workLine.Contains(gen))
                    {
                        workLine.Remove(gen);
                    }
                }
                var workLinecopy = workLine.ToArray();
                foreach (FrameGenerator gen in workLinecopy)
                {
                    if (!freeLine.Contains(gen))
                    {
                        workLine.Remove(gen);
                    }
                }

            }
        }
        private static HashSet<FrameGenerator> GetFreeLine()
        {
            return _GeneratorLines[_FreeLineIndex];
        }
        private static HashSet<FrameGenerator> GetWorkLine()
        {
            return _GeneratorLines[_WorkLineIndex];
        }
        private static Double GetTime()
        {
            //  return DateTime.Now.Ticks / 10000;
            return _Watch.ElapsedMilliseconds;
        }
        private static void CycleDispatch()
        {
            while (true)
            {
                Boolean sleep = true;
                var generators = GetWorkLine();
                if (generators.Count > 0) sleep = false;
                if (!sleep)
                {
                    var currentTime_ms = GetTime();
                    foreach (FrameGenerator gen in generators)
                    {
                        try
                        {
                            if (gen.Started)
                            {
                                gen.Tick(currentTime_ms);
                            }
                        }
                        catch { }

                    }
                }

                Thread.Sleep(sleep ? 30 : 1);
                SyncWorkLine();
            }
        }



    }
}
