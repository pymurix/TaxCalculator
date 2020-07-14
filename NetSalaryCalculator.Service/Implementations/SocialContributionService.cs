namespace NetSalaryCalculator.Service
{
    public class SocialContributionService : ISocialContributionService
    {
        const decimal SocialContributionAmountPercentage = 0.15m;
        const int SocialContributionLimit = 3000;

        public decimal GetSocialContributionAmount(decimal grossAmount)
        {
            decimal socialContributionBase = this.GetSocialContributionBase(grossAmount);

            return socialContributionBase * SocialContributionAmountPercentage;
        }

        // Internal for testing
        internal decimal GetSocialContributionBase(decimal grossAmount)
        {
            if (grossAmount > SocialContributionLimit)
            {
                return SocialContributionLimit - TaxService.AmountThatsNotTaxable;
            }

            decimal socialContributionBase = grossAmount - TaxService.AmountThatsNotTaxable;
            
            if (socialContributionBase < 0)
            {
                return 0;
            }

            return socialContributionBase;
        }
    }
}
