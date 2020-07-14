namespace NetSalaryCalculator
{
    using System;
    using NetSalaryCalculator.Service;

    public class Program
    {
        public static void Main(string[] args)
        {
            INetSalaryCalculatorService netSalaryCalculatorService = new NetSalaryCalculatorService(
                new TaxService(),
                new SocialContributionService());

            Console.Write("Please enter amount of gross salary: ");

            decimal grossSalary = decimal.Parse(Console.ReadLine());

            decimal netSalary = netSalaryCalculatorService.CalculateNetSalary(grossSalary);

            Console.WriteLine($"Amount of net salary: {netSalary} IDR");
        }
    }
}
