namespace NetSalaryCalculator.Test.Services
{
    using Xunit;
    using NetSalaryCalculator.Service;

    public class NetSalaryCalculatorTests
    {
        private readonly NetSalaryCalculatorService netSalaryCalculatorService;
        public NetSalaryCalculatorTests()
        {
            this.netSalaryCalculatorService = new NetSalaryCalculatorService
            (
                new TaxService(),
                new SocialContributionService()
            );
        }

        [Fact]
        public void GetAllTaxesShouldReturn0When999Given()
        {
            const decimal grossSalary = 999;
            const decimal expectedTaxesAmount = 0;

            decimal allTaxes = this.netSalaryCalculatorService.GetAllTaxes(grossSalary);

            Assert.Equal(expectedTaxesAmount, allTaxes);
        }

        [Fact]
        public void GetAllTaxesShouldReturn250When2000Given()
        {
            const decimal grossSalary = 2000;
            const decimal expectedTaxesAmount = 250;

            decimal allTaxes = this.netSalaryCalculatorService.GetAllTaxes(grossSalary);

            Assert.Equal(expectedTaxesAmount, allTaxes);
        }

        [Fact]
        public void GetAllTaxesShouldReturn600When4000Given()
        {
            const decimal grossSalary = 4000;
            const decimal expectedTaxesAmount = 600;

            decimal allTaxes = this.netSalaryCalculatorService.GetAllTaxes(grossSalary);

            Assert.Equal(expectedTaxesAmount, allTaxes);
        }

        [Fact]
        public void CalculateNetSalaryShouldReturn3400When4000Given()
        {
            const decimal grossSalary = 4000;
            const decimal expectedNetSalary = 3400;

            decimal netSalary = this.netSalaryCalculatorService.CalculateNetSalary(grossSalary);

            Assert.Equal(expectedNetSalary, netSalary);
        }

        [Fact]
        public void CalculateNetSalaryShouldReturn1000When1000Given()
        {
            const decimal grossSalary = 1000;
            const decimal expectedNetSalary = 1000;

            decimal netSalary = this.netSalaryCalculatorService.CalculateNetSalary(grossSalary);

            Assert.Equal(expectedNetSalary, netSalary);
        }

        [Fact]
        public void CalculateNetSalaryShouldReturn1750When2000Given()
        {
            const decimal grossSalary = 2000;
            const decimal expectedNetSalary = 1750;

            decimal netSalary = this.netSalaryCalculatorService.CalculateNetSalary(grossSalary);

            Assert.Equal(expectedNetSalary, netSalary);
        }
    }
}
