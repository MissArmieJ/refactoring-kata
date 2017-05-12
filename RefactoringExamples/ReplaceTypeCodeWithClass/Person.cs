using System.Collections.Generic;

namespace RefactoringExamples.ReplaceTypeCodeWithClass
{
    public class Person
    {
        private BloodGroup _bloodGroup;

        public Person(BloodGroup bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }

        public void SetBloodGroup(BloodGroup bloodGroup)
        {
            _bloodGroup = bloodGroup;   
        }

        public BloodGroup GetBloodGroup()
        {
            return _bloodGroup;
        }

        public int GetBloodGroupCode()
        {
            return _bloodGroup.GetCode();
        }
    }
}