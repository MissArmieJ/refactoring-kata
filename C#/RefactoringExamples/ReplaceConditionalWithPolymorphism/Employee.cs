using System;

namespace RefactoringExamples.ReplaceConditionalWithPolymorphism
{
    public class Employee
    {
        private EmployeeType _employeeType;
        private readonly int _monthlySalary;
        private readonly int _commission;
        private readonly int _bonus;

        public Employee(int type)
        {
            _employeeType = EmployeeType.TypeFrom(type);
            _monthlySalary = 100;
            _commission = 10;
            _bonus = 20;
        }

        public int GetTypeCode()
        {
            return _employeeType.Code;
        }

        public void SetType(int code)
        {
            _employeeType = EmployeeType.TypeFrom(code);
        }

        public int GetMonthlySalary()
        {
            return _monthlySalary;
        }

        public int GetCommission()
        {
            return _commission;
        }

        public int GetBonus()
        {
            return _bonus;
        }

        public int PayAmount()
        {
            return _employeeType.PayAmount(this);
        }
    }
}