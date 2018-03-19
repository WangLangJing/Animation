using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Animation
{
    public struct Vector
    {
        public static readonly Vector Empty = new Vector(Double.MaxValue); 

        public Double Value { get; private set; }

        public Vector(Double val)
        {
            this.Value = val;
        }


       
        public static implicit operator Int64(Vector v)
        {
            return (Int64)v.Value;
        }

        public static implicit operator Vector(Int64 val)
        {
            return new Vector(val);
        }


        public static implicit operator Double(Vector v)
        {
            return v.Value;
        }

        public static implicit operator Vector(Double val)
        {
            return new Vector(val);
        }

        public static implicit operator Single(Vector v)
        {
            return (Single)v.Value;
        }

        public static implicit operator Vector(Single val)
        {
            return new Vector(val);
        }


        public static implicit operator Int32(Vector v)
        {
            return (Int32)v.Value;
        }

        public static implicit operator Vector(Int32 val)
        {
            return new Vector(val);
        }
        public static Boolean operator ==(Vector v1,Vector v2)
        {
            return v1.Value == v2.Value;
        }
        public static Boolean operator !=(Vector v1, Vector v2)
        {
            return v1.Value != v2.Value;
        }
    }

    public struct Vector2
    {
        public Vector X { get; private set; }
        public Vector Y { get; private set; }

        public Vector2(Vector x, Vector y)
        {
            this.Y = y;
            this.X = x;
        }


        public static implicit operator Point(Vector2 v2)
        {
            return new Point(v2.X, v2.Y);
        }
        public static implicit operator Vector2(Point p)
        {
            return new Vector2(p.Y, p.Y);
        }

        public static implicit operator Size(Vector2 v2)
        {
            return new Size(v2.X, v2.Y);
        }
        public static implicit operator Vector2(Size s)
        {
            return new Vector2(s.Width, s.Height);
        }
    }
    public struct Vector3
    {
        public Vector X { get; private set; }
        public Vector Y { get; private set; }
        public Vector Z { get; private set; }

        public Vector3(Vector x, Vector y, Vector z)
        {
            this.Y = y;
            this.X = x;
            this.Z = z;
        }


        public static implicit operator Color(Vector3 v3)
        {
            return Color.FromArgb(v3.X, v3.Y, v3.Z);
        }
        public static implicit operator Vector3(Color c)
        {
            return new Vector3(c.R, c.G, c.B);
        }
    }
}
