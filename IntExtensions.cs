using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal static class IntExtensions

    {

        public static int Reverse(this int Number) // 12345
        {
            int ReversedNumber = 0, Remainder;

            while (Number != 0)
            {
                Remainder = Number % 10; //1
                ReversedNumber = ReversedNumber * 10 + Remainder; // 540
                Number = Number / 10; // 0
            }

            return ReversedNumber;
        }
        public static long Reverse(this long Number) // 12345
        {
            long ReversedNumber = 0, Remainder;

            while (Number != 0)
            {
                Remainder = Number % 10; //1
                ReversedNumber = ReversedNumber * 10 + Remainder; // 540
                Number = Number / 10; // 0
            }

            return ReversedNumber;
        }

    }
}
