namespace NetSalaryCalculator.Test.Services
{
    using NetSalaryCalculator.Service;
    using Xunit;

    public class TaxServiceTests
    {
        private readonly TaxService taxService;
        public TaxServiceTests()
        {
            this.taxService = new TaxService();
        }

        [Fact]
        public void HaveToPayTaxShouldRetrunTrueWhenGrossInputGreaterThan1000()
        {
            bool result = this.taxService.HaveToPayTax(1001);

            Assert.True(result);
        }

        [Fact]
        public void HaveToPayTaxShouldRetrunFalseWhenGrossInputLessThan1000()
        {
            bool result = this.taxService.HaveToPayTax(999);

            Assert.False(result);
        }

        [Fact]
        public void HaveToPayTaxShouldRetrunTrueWhenGrossInputEqualsTo1000()
        {
            bool result = this.taxService.HaveToPayTax(1000);

            Assert.False(result);
        }

        [Fact]
        public void GetTaxBaseShouldReturn500When1500Given()
        {
            const decimal grossAmount = 1500;
            const decimal expectedTaxBase = 500;

            decimal taxBase = this.taxService.GetTaxBase(grossAmount);

            Assert.Equal(expectedTaxBase, taxBase);
        }

        [Fact]
        public void GetTaxBaseShouldReturn0When1000Given()
        {
            const decimal grossAmount = 1000;
            const decimal expectedTaxBase = 0;

            decimal taxBase = this.taxService.GetTaxBase(grossAmount);

            Assert.Equal(expectedTaxBase, taxBase);
        }

        [Fact]
        public void GetTaxBaseShouldReturn0When999Given()
        {
            const decimal grossAmount = 999;
            const decimal expectedTaxBase = 0;

            decimal taxBase = this.taxService.GetTaxBase(grossAmount);

            Assert.Equal(expectedTaxBase, taxBase);
        }

        [Fact]
        public void GetTaxAmountShouldReturn100When2000Given()
        {
            const decimal grossAmount = 2000;
            const decimal expectedTaxAmount = 100;

            decimal taxAmount = this.taxService.GetTaxAmount(grossAmount);

            Assert.Equal(expectedTaxAmount, taxAmount);
        }

        [Fact]
        public void GetTaxAmountShouldReturn0When1000Given()
        {
            const decimal grossAmount = 1000;
            const decimal expectedTaxAmount = 0;

            decimal taxAmount = this.taxService.GetTaxAmount(grossAmount);

            Assert.Equal(expectedTaxAmount, taxAmount);
        }

        [Fact]
        public void GetTaxAmountShouldReturn0When999Given()
        {
            const decimal grossAmount = 999;
            const decimal expectedTaxAmount = 0;

            decimal taxAmount = this.taxService.GetTaxAmount(grossAmount);

            Assert.Equal(expectedTaxAmount, taxAmount);
        }
    }
}
