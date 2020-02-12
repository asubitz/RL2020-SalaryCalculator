using System;
using System.Collections.Generic;

namespace SalaryCalculator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var devReports = new List<DeveloperReport>
            {
                new DeveloperReport
                    {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160},
                new DeveloperReport
                    {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150},
                new DeveloperReport
                    {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180}
            };

            var bookkeeping = new Bookkeeping(devReports);
            Console.WriteLine($"Sum of all the developer salaries is {bookkeeping.CalculateTotalSalaries()} dollars");
        }

        #region 2 req

        //private static void Main(string[] args)
        //{
        //    var devCalculations = new List<BaseSalaryCalculator>
        //    {
        //        new SeniorDevSalaryCalculator(new DeveloperReport
        //            {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160}),
        //        new JuniorDevSalaryCalculator(new DeveloperReport
        //            {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150}),
        //        new SeniorDevSalaryCalculator(new DeveloperReport
        //            {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180})
        //    };

        //    var bookkeeping = new Bookkeeping(devCalculations);
        //    Console.WriteLine($"Sum of all the developer salaries is {bookkeeping.CalculateTotalSalaries()} dollars");
        //}

        #endregion

    }
}

