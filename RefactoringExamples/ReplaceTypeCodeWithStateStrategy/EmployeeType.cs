using NSubstitute.Exceptions;

namespace RefactoringExamples.ReplaceTypeCodeWithStateStrategy
{
    public abstract class EmployeeType
    {
        public abstract int GetTypeCode();

        public const int Engineer = 0;
        public const int Salesperson = 1;
        public const int Manager = 2;

        public static EmployeeType GetTypeBy(int code)
        {
            switch (code)
            {
                case Engineer:
                    return new Engineer();
                case Salesperson:
                    return new Salesman();
                case Manager:
                    return new Manager();
                default:
                    throw new ArgumentNotFoundException("Incorrect Employee Code");
            }
        }
    }

    public class Engineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Engineer;
        }
    }

    public class Salesman : EmployeeType {
        public override int GetTypeCode()
        {
            return Salesperson;
        }
    }

    public class Manager : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Manager;
        }
    }
}
