using System.Collections.Generic;

namespace SalaryCalculator
{
    public class Bookkeeping
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public Bookkeeping(IEnumerable<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in _developerReports)
            {
                totalSalaries += devReport.CalculateSalary();
            }

            return totalSalaries;
        }

    }

}