namespace NetSalaryCalculator.Service
{
    public interface ISocialContributionService
    {
        public decimal GetSocialContributionAmount(decimal grossAmount);
    }
}
