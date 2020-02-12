using SalaryCalculator;

namespace SalaryCalculator
{

    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        protected BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}

public class SeniorDevSalaryCalculator : BaseSalaryCalculator
{
    public SeniorDevSalaryCalculator(DeveloperReport report)
        : base(report)
    {
    }

    public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
}

public class JuniorDevSalaryCalculator : BaseSalaryCalculator
{
    public JuniorDevSalaryCalculator(DeveloperReport developerReport)
        : base(developerReport)
    {
    }

    public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.5;
}