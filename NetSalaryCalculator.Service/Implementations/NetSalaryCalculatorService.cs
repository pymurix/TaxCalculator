namespace NetSalaryCalculator.Service
{
    public class NetSalaryCalculatorService : INetSalaryCalculatorService
    {
        private readonly ITaxService taxService;
        private readonly ISocialContributionService socialContributionService;

        public NetSalaryCalculatorService(ITaxService taxService,
            ISocialContributionService socialContributionService)
        {
            this.taxService = taxService;
            this.socialContributionService = socialContributionService;
        }

        public decimal CalculateNetSalary(decimal grossAmount)
        {
            if (!this.taxService.HaveToPayTax(grossAmount))
            {
                return grossAmount;
            }

            decimal allTaxes = this.GetAllTaxes(grossAmount);

            return grossAmount - allTaxes;
        }

        // Internal for testing 
        internal decimal GetAllTaxes(decimal grossAmount)
        {
            decimal taxAmount = this.taxService.GetTaxAmount(grossAmount);
            decimal socialContributionAmount =
                this.socialContributionService.GetSocialContributionAmount(grossAmount);

            return taxAmount + socialContributionAmount;
        }
    }
}
