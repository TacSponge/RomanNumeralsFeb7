using System.Collections.Generic;
using System;
using System.Linq;
using System.Transactions;


namespace RomanNumeralsKata
{
    internal class Conversion
    {
        internal string ConvertedSequence { get; private set; } = "";
        private int remainder;

        private List<Numeral> values = new List<Numeral>()
        {
            new Numeral('M',1000,true),
            new Numeral('D',500,false),
            new Numeral('C', 100, true),
            new Numeral('L', 50, false),
            new Numeral('X', 10, true),
            new Numeral('V', 5, false),
            new Numeral('I',1,true)
        };

        private Numeral current;
        private int index;


        internal Conversion(int valueToConvert)
        {
            validateValueRange(valueToConvert);
            
            this.remainder = valueToConvert;
            convert();
        }

        private static void validateValueRange(int valueToConvert)
        {
            if (valueToConvert < 0 || valueToConvert > 9999)
            {
                throw new Exception();
            }
        }

        private void convert()
        {
            foreach (Numeral n in values)
            {
                current = n;
                AddPrefixAndSuffixes();
            }
        }

        private void AddPrefixAndSuffixes()
        {
            
            AddConsecutiveSuffixes();
            DetermineAndAddPrefix();
        }

        private void DetermineAndAddPrefix()
        {
            if (isNotLastPrefix(current))
            {
                Numeral prefix = getPrefix(current);
                if (
                    remainder > 0 &&
                    remainder >= current.value - prefix.value
                )
                {
                    ConvertedSequence += "" + prefix.symbol + current.symbol;
                    remainder -= current.value - prefix.value;
                }
            }
        }

        private bool isNotLastPrefix(Numeral n)
        {
            return n != values.Last();
        }

        private void AddConsecutiveSuffixes()
        {
            while (remainder >= current.value)
            {
                ConvertedSequence += current.symbol;
                remainder -= current.value;
            }
        }

        private Numeral getPrefix(Numeral n)
        {
            Numeral prefix = GetNextSuffix(n);
            while (shouldSkipPrefix(prefix))
            {
                prefix = GetNextSuffix(prefix);
            }

            return prefix;
        }

        private bool shouldSkipPrefix(Numeral n)
        {
            return !n.isValidPrefix;
        }

        private Numeral GetNextSuffix(Numeral n)
        {
            return values[values.IndexOf(n) + 1];
        }
    }
}