namespace RefactoringExamples.MoveField
{
    public class Account
    {
        private readonly AccountType _type;

        public Account(AccountType type, double interestRate)
        {
            _type = type;
            SetInterestRate(interestRate);
        }

        private void SetInterestRate(double interestRate)
        {
            _type.SetInterestRate(interestRate);
        }

        public double InterestForAmount_Days(double amount, int days)
        {
            return GetInterestRate() * amount * days / 365;
        }

        private double GetInterestRate()
        {
            return _type.GetInterestRate();
        }
    }
}