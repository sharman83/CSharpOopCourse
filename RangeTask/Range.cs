using System;

namespace RangeTask
{
    class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            this.From = from;
            this.To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public Range GetIntersection(Range anotherRange)
        {
            double intersectionFrom = Math.Max(From, anotherRange.From);
            double intersectionTo = Math.Min(To, anotherRange.To);

            if (intersectionFrom >= intersectionTo)
            {
                return null;
            }

            return new Range(intersectionFrom, intersectionTo);
        }

        public Range[] GetUnion(Range anotherRange)
        {
            double unionFrom = Math.Min(From, anotherRange.From);
            double unionTo = Math.Max(To, anotherRange.To);

            if (anotherRange.From > To)
            {
                return new Range[] { new Range(From, To), new Range(anotherRange.From, anotherRange.To) };
            }

            if (anotherRange.To < From)
            {
                return new Range[] { new Range(anotherRange.From, anotherRange.To), new Range(From, To) };
            }

            return new Range[] { new Range(unionFrom, unionTo) };
        }

        public Range[] GetDifference(Range anotherRange)
        {
            if (From >= anotherRange.From && To <= anotherRange.To)
            {
                return new Range[0];
            }

            if (From >= anotherRange.From && From <= anotherRange.To && To > anotherRange.To)
            {
                return new Range[] { new Range(anotherRange.To, To) };
            }

            if (To >= anotherRange.From && To <= anotherRange.To && From < anotherRange.From)
            {
                return new Range[] { new Range(From, anotherRange.From) };
            }

            return new Range[] { new Range(From, anotherRange.From), new Range(anotherRange.To, To) };
        }
    }
}
