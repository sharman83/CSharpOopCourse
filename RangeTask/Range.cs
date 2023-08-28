using System;

namespace RangeTask
{
    class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return number >= From && number <= To;
        }

        public override string ToString()
        {
            return "(" + From + "; " + To + ")";
        }

        public Range GetIntersection(Range range)
        {
            double intersectionFrom = Math.Max(From, range.From);
            double intersectionTo = Math.Min(To, range.To);

            if (intersectionFrom >= intersectionTo)
            {
                return null;
            }

            return new Range(intersectionFrom, intersectionTo);
        }

        public Range[] GetUnion(Range range)
        {
            if (range.From > To)
            {
                return new Range[] { new Range(From, To), new Range(range.From, range.To) };
            }

            if (range.To < From)
            {
                return new Range[] { new Range(range.From, range.To), new Range(From, To) };
            }

            return new Range[] { new Range(Math.Min(From, range.From), Math.Max(To, range.To)) };
        }

        public Range[] GetDifference(Range range)
        {
            if (From >= range.From && To <= range.To)
            {
                return new Range[0];
            }

            if (From >= range.From && From <= range.To && To > range.To)
            {
                return new Range[] { new Range(range.To, To) };
            }

            if (To >= range.From && To <= range.To && From < range.From)
            {
                return new Range[] { new Range(From, range.From) };
            }

            return new Range[] { new Range(From, range.From), new Range(range.To, To) };
        }
    }
}
