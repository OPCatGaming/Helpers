using System;
namespace Helpers
{
    public interface IVectorHelpers
    {
        double DistanceBetween(Position p1, Position p2);
        string DirectionOfVector(Position p1, Position p2);
    }
}
