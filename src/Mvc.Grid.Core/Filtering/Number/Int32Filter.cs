using System;

namespace NonFactors.Mvc.Grid
{
    public class Int32Filter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            long number;
            if (long.TryParse(Value, out number))
                return number;

            return null;
        }
    }
}
