namespace NetSalaryCalculator.Test.Services
{
    using Xunit;
    using NetSalaryCalculator.Service;

    public class SocialContributionServiceTests
    {
        private readonly SocialContributionService socialContributionService;
        public SocialContributionServiceTests()
        {
            this.socialContributionService = new SocialContributionService();
        }

        [Fact]
        public void GetSocialContributionBaseShouldReturn2000When3001Given()
        {
            const decimal grossAmount = 3001;
            const decimal expectedSocialContributionBase = 2000;

            decimal socialCobtributionBase =
                this.socialContributionService.GetSocialContributionBase(grossAmount);

            Assert.Equal(expectedSocialContributionBase, socialCobtributionBase);
        }

        [Fact]
        public void GetSocialContributionBaseShouldReturn1500When2500Given()
        {
            const decimal grossAmount = 2500;
            const decimal expectedSocialContributionBase = 1500;

            decimal socialCobtributionBase =
                this.socialContributionService.GetSocialContributionBase(grossAmount);

            Assert.Equal(expectedSocialContributionBase, socialCobtributionBase);
        }

        [Fact]
        public void GetSocialContributionBaseShouldReturn0When999Given()
        {
            const decimal grossAmount = 999;
            const decimal expectedSocialContributionBase = 0;

            decimal socialCobtributionBase =
                this.socialContributionService.GetSocialContributionBase(grossAmount);

            Assert.Equal(expectedSocialContributionBase, socialCobtributionBase);
        }

        [Fact]
        public void GetSocialContributionAmountShouldReturn150When2000Given()
        {
            const decimal grossAmount = 2000;
            const decimal expectedSocialContributionAmount = 150;

            decimal socialContributionAmount =
                this.socialContributionService.GetSocialContributionAmount(grossAmount);

            Assert.Equal(expectedSocialContributionAmount, socialContributionAmount);
        }

        [Fact]
        public void GetSocialContributionAmountShouldReturn0When1000Given()
        {
            const decimal grossAmount = 1000;
            const decimal expectedSocialContributionAmount = 0;

            decimal socialContributionAmount =
                this.socialContributionService.GetSocialContributionAmount(grossAmount);

            Assert.Equal(expectedSocialContributionAmount, socialContributionAmount);
        }

        [Fact]
        public void GetSocialContributionAmountShouldReturn300When4000Given()
        {
            const decimal grossAmount = 4000;
            const decimal expectedSocialContributionAmount = 300;

            decimal socialContributionAmount =
                this.socialContributionService.GetSocialContributionAmount(grossAmount);

            Assert.Equal(expectedSocialContributionAmount, socialContributionAmount);
        }
    }
}
