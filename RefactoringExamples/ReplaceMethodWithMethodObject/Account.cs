namespace RefactoringExamples.ReplaceMethodWithMethodObject
{
    public class Account
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            return new Gamma(this, inputVal, quantity, yearToDate).Calculate();
        }

        public int Delta()
        {
            return 20;
        }
    }
}