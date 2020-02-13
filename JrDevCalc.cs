namespace SalaryCalculator
{
    public class JrDevCalc : ISalaryCalculator
    {
        private readonly double _hourlyRate;
        private readonly int _workingHours;

        public JrDevCalc(double hourlyRate, int workingHours)
        {
            _hourlyRate = hourlyRate;
            _workingHours = workingHours;
        }
        public double Calculate()
        {
            return _hourlyRate * _workingHours * 1.5;
        }
    }
}