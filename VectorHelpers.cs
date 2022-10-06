using System;
namespace Helpers
{
    public class VectorHelpers : IVectorHelpers
    {
        public double DistanceBetween(Position p1, Position p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2) + Math.Pow(p1.z - p2.z, 2));
        }
        public string DirectionOfVector(Position p1, Position p2)
        {
            return "No";
        }
    }
}
