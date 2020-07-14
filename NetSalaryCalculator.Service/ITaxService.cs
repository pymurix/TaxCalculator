namespace NetSalaryCalculator.Service
{
    public interface ITaxService
    {
        public bool HaveToPayTax(decimal grossAmount);

        public decimal GetTaxAmount(decimal grossAmount);
    }
}
