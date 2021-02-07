using System;
using System.Collections.Generic;
using System.Text;


namespace RomanNumeralsKata
{
    internal class RomanNumeralConverter
    {
        internal static string convertInt(int naturalNumber)
        {
            Conversion conversion = new Conversion(naturalNumber);
            return conversion.ConvertedSequence;
        }
    }
}
