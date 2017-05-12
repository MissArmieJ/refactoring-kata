namespace RefactoringExamples.PreserveWholeObject
{
    public class TempRange
    {
        private readonly int _low;
        private readonly int _high;

        public TempRange(int high, int low)
        {
            _low = low;
            _high = high;
        }

        public int GetLow()
        {
            return _low;
        }

        public int GetHigh()
        {
            return _high;
        }
    }
}