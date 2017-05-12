namespace RefactoringExamples.ReplaceTypeCodeWithClass
{
    public class BloodGroup
    {
        public static BloodGroup O = new BloodGroup(0);
        public static BloodGroup A = new BloodGroup(1);
        public static BloodGroup B = new BloodGroup(2);
        // ReSharper disable once InconsistentNaming
        public static BloodGroup AB = new BloodGroup(3);

        private static readonly BloodGroup[] Values = {O, A, B, AB};

        private readonly int _code;

        public BloodGroup(int code)
        {
            _code = code;
        }

        public int GetCode()
        {
            return _code;
        }

        public static BloodGroup GetBy(int code)
        {
            return Values[code];
        }
    }
}