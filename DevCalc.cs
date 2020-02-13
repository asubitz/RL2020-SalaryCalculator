namespace SalaryCalculator
{
    public class DevCalc : ISalaryCalculator
    {
        private readonly double _hourlyRate;
        private readonly int _workingHours;

        public DevCalc(double hourlyRate, int workingHours)
        {
            _hourlyRate = hourlyRate;
            _workingHours = workingHours;
        }
        public double Calculate()
        {
            return _hourlyRate * _workingHours;
        }
    }
}
