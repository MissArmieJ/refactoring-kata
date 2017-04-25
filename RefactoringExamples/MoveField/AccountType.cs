namespace RefactoringExamples.MoveField
{
    public class AccountType
    {
        private double _interestRate;

        public void SetInterestRate(double interestRate)
        {
            _interestRate = interestRate;
        }

        public double GetInterestRate()
        {
            return _interestRate;
        }
    }
}