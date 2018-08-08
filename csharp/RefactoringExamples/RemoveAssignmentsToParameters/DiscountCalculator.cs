namespace RefactoringExamples.RemoveAssignmentsToParameters
{
    public class DiscountCalculator
    {
        public int Discount(int inputVal, int quantity, int yearToDate)
        {
            var result = inputVal;

            if (inputVal > 50) {result -= 2;}
            if (quantity > 100) {result -= 1;}
            if (yearToDate > 10000) {result -= 4;}

            return result;
        }
    }
}