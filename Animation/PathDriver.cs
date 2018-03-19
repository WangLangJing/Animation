using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animation
{
    public class PathDriver
    {
        public Double Duration { get; private set; }
        public EasingFunctionHandler Handler { get; private set; }
        

        public PathDriver()
        {

        }
        public PathDriver(Double duration, EasingFunctionHandler handler) : this()
        {
            this.Duration = duration;
            this.Handler = handler ?? KnownEasingFuctionTypes.Linear.GetHandler();
        }

        public PathDriver(Double duration) : this(duration, null)
        {

        }

        public PathDriver(EasingFunctionHandler handler) : this(1000, handler)
        {

        }




        public Vector CalcuatePathFrame(Double time, Path path)
        {
            return this.Handler.Invoke(time, path.Start, path.End, this.Duration);
        }

        public Vector2 CalcuatePathFrame(Double time, Path2 path2)
        {
            return new Vector2(
               this.CalcuatePathFrame(time, path2.X),
               this.CalcuatePathFrame(time, path2.Y));
        }

        public Vector3 CalcuatePathFrame(Double time, Path3 path3)
        {
            return new Vector3(
                  this.CalcuatePathFrame(time, path3.X),
                  this.CalcuatePathFrame(time, path3.Y),
                  this.CalcuatePathFrame(time, path3.Z));
        }
    }
}
