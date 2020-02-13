namespace SalaryCalculator
{
    public class DeveloperReport
    {
        public int Id { private get; set; }

        public string Name { private get; set; }

        public ISalaryCalculator DevSalaryCalculator { private get; set; }

        public double CalculateSalary()
        {
            return DevSalaryCalculator.Calculate();
        }
    }
}