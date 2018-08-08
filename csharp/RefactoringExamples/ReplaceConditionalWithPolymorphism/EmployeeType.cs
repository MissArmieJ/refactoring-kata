using System;

namespace RefactoringExamples.ReplaceConditionalWithPolymorphism
{
    public abstract class EmployeeType
    {
        public abstract int Code { get; }
        public abstract int PayAmount(Employee employee);

        public static EmployeeType TypeFrom(int value)
        {
            switch (value)
            {
                case Engineer:
                    return new Engineer();
                case Salesperson:
                    return new Salesperson();
                case Manager:
                    return new Manager();
                default:
                    throw new Exception("Incorrect Employee Code");
            }
        }

        public const int Engineer = 0;
        public const int Salesperson = 1;
        public const int Manager = 2;
    }

    internal class Engineer : EmployeeType
    {
        public override int Code => Engineer;
        public override int PayAmount(Employee employee)
        {
            return employee.GetMonthlySalary();
        }
    }

    internal class Salesperson : EmployeeType
    {
        public override int Code => Salesperson;
        public override int PayAmount(Employee employee)
        {
            return employee.GetMonthlySalary() + employee.GetCommission();
        }
    }

    internal class Manager : EmployeeType
    {
        public override int Code => Manager;
        public override int PayAmount(Employee employee)
        {
            return employee.GetMonthlySalary() + employee.GetBonus();
        }
    }
}