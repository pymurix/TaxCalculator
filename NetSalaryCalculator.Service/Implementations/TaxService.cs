namespace NetSalaryCalculator.Service
{
    public class TaxService : ITaxService
    {
        public const int AmountThatsNotTaxable = 1000;
        const decimal TaxAmountPercentage = 0.1m;

        public bool HaveToPayTax(decimal grossAmount)
        {
            return grossAmount > AmountThatsNotTaxable;
        }

        public decimal GetTaxAmount(decimal grossAmount)
        {
            decimal taxBase = this.GetTaxBase(grossAmount);

            return taxBase * TaxAmountPercentage;
        }

        // Internal for testing
        internal decimal GetTaxBase(decimal grossAmount)
        {
            decimal taxBase = grossAmount - AmountThatsNotTaxable;

            if (taxBase < 0)
            {
                return 0;
            }

            return taxBase;
        }
    }
}
