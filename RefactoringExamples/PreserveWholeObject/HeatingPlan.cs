namespace RefactoringExamples.PreserveWholeObject
{
    public class HeatingPlan
    {
        private readonly TempRange _range;

        public HeatingPlan(TempRange range)
        {
            _range = range;
        }

        public bool WithinRange(TempRange roomRange)
        {
            return roomRange.GetLow() >= _range.GetLow() 
                && roomRange.GetHigh() <= _range.GetHigh();
        }
    }
}