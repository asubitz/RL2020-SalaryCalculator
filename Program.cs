using System;
using System.Collections.Generic;

namespace SalaryCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            var devReports = new List<DeveloperReport>
            {
                new DeveloperReport
                    {Id = 1, Name = "Dev1",  DevSalaryCalculator = new SrDevCalc(30.5, 160)},
                new DeveloperReport
                    {Id = 2, Name = "Dev2", DevSalaryCalculator = new JrDevCalc(20, 120)},
                new DeveloperReport
                    {Id = 3, Name = "Dev3", DevSalaryCalculator = new SrDevCalc(32, 180)},
                new DeveloperReport
                    {Id = 3, Name = "Dev4", DevSalaryCalculator = new DevCalc(25, 180)}
            };

            var bookkeeping = new Bookkeeping(devReports);
            Console.WriteLine($"Sum of all the developer salaries is {bookkeeping.CalculateTotalSalaries()} dollars");
        }

    }
}