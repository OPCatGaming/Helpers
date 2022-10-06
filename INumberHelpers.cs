using System;
namespace Helpers
{
    public interface INumberHelpers
    {
        double RoundToNearest(double numToRound, double whatToRoundTo, double roundHigherPcnt);
    }
}
