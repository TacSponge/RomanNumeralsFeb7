namespace RomanNumeralsKata
{
    internal class Numeral
    {
        internal readonly char symbol;
        internal readonly int value;
        internal readonly bool isValidPrefix;

        internal Numeral(char symbol, int value, bool isValidPrefix)
        {
            this.symbol = symbol;
            this.value = value;
            this.isValidPrefix = isValidPrefix;
        }
    }
}