using System;

namespace Session_08
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(double x) : this(x, 0, 0) { }
        public Point3D(double x, double y) : this(x, y, 0) { }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return "Point Coordinates: (" + X + ", " + Y + ", " + Z + ")";
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;
            if (p1 is null || p2 is null)
                return false;
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public int CompareTo(Point3D other)
        {
            if (other is null)
                return 1;

            int xComparison = X.CompareTo(other.X);
            if (xComparison != 0)
                return xComparison;

            return Y.CompareTo(other.Y);
        }

        
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}