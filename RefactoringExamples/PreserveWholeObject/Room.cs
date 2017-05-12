namespace RefactoringExamples.PreserveWholeObject
{
    public class Room
    {
        private readonly TempRange _daysTempRange;

        public Room(TempRange daysTempRange)
        {
            _daysTempRange = daysTempRange;
        }

        public bool WithinPlan(HeatingPlan heatingPlan)
        {
            return heatingPlan.WithinRange(_daysTempRange);
        }
    }
}