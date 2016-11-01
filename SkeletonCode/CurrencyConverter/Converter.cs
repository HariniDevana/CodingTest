using System;

namespace SkeletonCode.CurrencyConverter
{
    public class Converter
    {
        private const string Usd = "USD";
        private const string Gbp = "GBP";
        private const decimal GbpToUsd = 1.25m;

        // Function is used to convert the amount from once currency to another.
        // At present only GBP to USD and vice versa conversion is supported.
        public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
        {
            // If either of the input currencies is null or emtpy, then return ArgumentException
            if ((string.IsNullOrEmpty(inputCurrency)) || (string.IsNullOrEmpty(outputCurrency)))
            {
                throw new ArgumentException("Given currencies should be valid");
            }
            else if (inputCurrency.Equals(Gbp) && outputCurrency.Equals(Usd))
            {
                // GBP to USD conversion
                amount = GbpToUsd * amount;
            }
            else if (inputCurrency.Equals(Usd) && outputCurrency.Equals(Gbp))
            {
                 // USD to GBP conversion
                amount = (1 / GbpToUsd) * amount;
            }
            else
            {
                // not supported currency conversion
                throw new NotSupportedException("Coversion not allowed between given currencies");
            }
            
            return amount;
        }

    }
}

