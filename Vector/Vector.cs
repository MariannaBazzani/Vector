using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
        public override string ToString()
        {
            return string.Format($"{0}, {1}", X, Y);
        }
        public static Vector Parse(string str)
        {
            string[] componenti = str.Split(',');
            return new Vector(double.Parse(componenti[0]), double.Parse(componenti[1]));
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static double operator *(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
        public static Vector operator *(Vector v1, double a)
        {
            return new Vector(v1.X * a, v1.Y * a);
        }
        public static Vector operator *(double a, Vector v1)
        {
            return new Vector(v1.X * a, v1.Y * a);
        }
        public static Vector operator /(Vector v1, double a)
        {
            return new Vector(v1.X / a, v1.Y / a);
        }
        public static Vector operator -(Vector v1)
        {
            return new Vector(-v1.X, -v1.Y);
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj))
                return false;
            if(ReferenceEquals(this, obj)) 
                return true;
            if(obj.GetType() != this.GetType()) 
                return false;
            return Equals((Vector)obj);
        }
        public static bool operator ==(Vector v1, Vector v2)
        {
            return Equals(v1, v2);
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !Equals(v1, v2);
        }

        public Vector Versore()
        {
            return this / Modulo();
        }
    }
}
