using System.Collections.Generic;

namespace SalaryCalculator
{
    public class Bookkeeping
    {
        private readonly IEnumerable<DeveloperReport> developerReports;

        public Bookkeeping(IEnumerable<DeveloperReport> developerReports)
        {
            this.developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in developerReports)
            {
                totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }

            return totalSalaries;
        }

        #region 1st req

        //public double CalculateTotalSalaries()
        //{
        //    double totalSalaries = 0D;

        //    foreach (var devReport in developerReports)
        //    {
        //        if (devReport.Level == "Senior developer")
        //        {
        //            totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
        //        }
        //        else
        //        {
        //            totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
        //        }
        //    }

        //    return totalSalaries;
        //}

        #endregion

    }

    #region 2 req

    //public class Bookkeeping
    //{
    //    private readonly IEnumerable<BaseSalaryCalculator> developerCalculation;

    //    public Bookkeeping(IEnumerable<BaseSalaryCalculator> developerCalculation)
    //    {
    //        this.developerCalculation = developerCalculation;
    //    }

    //    public double CalculateTotalSalaries()
    //    {
    //        double totalSalaries = 0D;

    //        foreach (var devCalc in developerCalculation)
    //        {
    //            totalSalaries += devCalc.CalculateSalary();
    //        }

    //        return totalSalaries;
    //    }
    //}


    #endregion


}