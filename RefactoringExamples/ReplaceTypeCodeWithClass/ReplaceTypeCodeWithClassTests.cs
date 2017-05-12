using System.Collections.Generic;
using NUnit.Framework;

namespace RefactoringExamples.ReplaceTypeCodeWithClass
{
    [TestFixture]
    public class ReplaceTypeCodeWithClassTests
    {
        private readonly IEnumerable<BloodGroup> _testCases = new List<BloodGroup>
        {
            BloodGroup.O,
            BloodGroup.A,
            BloodGroup.B,
            BloodGroup.AB
        };

        [TestCaseSource(nameof(_testCases))]
        public void A_person_has_a_blood_group(BloodGroup bloodGroup)
        {
            var person = new Person(bloodGroup);

            Assert.That(person.GetBloodGroup(), Is.EqualTo(bloodGroup));
        }

        [TestCaseSource(nameof(_testCases))]
        public void A_persons_blood_group_can_be_amended(BloodGroup bloodGroup)
        {
            var person = new Person(BloodGroup.O);
            Assert.That(person.GetBloodGroup(), Is.EqualTo(BloodGroup.O));

            person.SetBloodGroup(bloodGroup);

            Assert.That(person.GetBloodGroup(), Is.EqualTo(bloodGroup));
        }

        [TestCaseSource(nameof(_testCases))]
        public void A_persons_blood_groups_code_can_be_obtained(BloodGroup bloodGroup)
        {
            var person = new Person(bloodGroup);
            
            Assert.That(person.GetBloodGroupCode(), Is.EqualTo(bloodGroup.GetCode()));
        }
    }
}