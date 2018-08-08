using System;
using NSubstitute.Exceptions;

namespace RefactoringExamples.ReplaceTypeCodeWithStateStrategy
{
    public class Employee
    {
        private EmployeeType _employeeType;

        private readonly int _monthlySalary;
        private readonly int _commission;
        private readonly int _bonus;

        public Employee(EmployeeType employeeType)
        {
            _employeeType = employeeType;
            _monthlySalary = 100;
            _commission = 10;
            _bonus = 20;
        }

        public int GetTypeCode()
        {
            return _employeeType.GetTypeCode();
        }

        public void SetTypeBy(int code)
        {
            _employeeType = EmployeeType.GetTypeBy(code);
        }

       public int PayAmount()
        {
            switch (GetTypeCode())
            {
                case EmployeeType.Engineer:
                    return _monthlySalary;
                case EmployeeType.Salesperson:
                    return _monthlySalary + _commission;
                case EmployeeType.Manager:
                    return _monthlySalary + _bonus;
                default:
                    throw new Exception("Incorrect Employee");
            }
        }
    }
}