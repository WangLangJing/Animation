using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animation
{
    public class Path
    {
        public Vector Start { get; private set; }
        public Vector End { get; private set; }

        public Path(Vector start, Vector end) 
        {
            this.Start = start;
            this.End = end;
        }
    }

    public class Path2
    {
        public Path X { get; set; }
        public Path Y { get; set; }
    }
    public class Path3
    {
        public Path X { get; set; }
        public Path Y { get; set; }
        public Path Z { get; set; }
    }
}
