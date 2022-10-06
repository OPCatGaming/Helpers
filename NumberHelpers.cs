using System;
namespace Helpers
{
    public class NumberHelpers : INumberHelpers
    {
        public double RoundToNearest(double numToRound, double whatToRoundTo, double roundHigherPcnt = 50.0)
        {
            double remainder = numToRound % whatToRoundTo;
            if (remainder >= whatToRoundTo * (roundHigherPcnt / 100))
                return (numToRound - remainder) + whatToRoundTo;
            else
                return numToRound - remainder;
        }
    }
}
