using System;

namespace Geometry
{
    public class CartesianPoint
    {
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public double DistanceFrom(CartesianPoint that)
        {
            return Math.Sqrt(Math.Pow((this.x - that.x) + (this.y - that.y), 2));
        }
    }
}
