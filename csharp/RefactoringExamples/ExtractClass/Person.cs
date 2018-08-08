namespace RefactoringExamples.ExtractClass
{
    public class Person
    {
        private readonly string _name;

        private readonly TelephoneNumber _officeTelephone = new TelephoneNumber();

        public Person(string name, string officeAreaCode, string officeNumber)
        {
            _name = name;
            SetOfficeAreaCode(officeAreaCode);
            SetOfficeNumber(officeNumber);
        }

        public string GetName() { return _name; }

        public string GetTelephoneNumber()
        {
            return "(" + GetOfficeAreaCode() + ") " + GetOfficeNumber();
        } 

        private void SetOfficeNumber(string officeNumber)
        {
            _officeTelephone.SetNumber(officeNumber);
        }

        private string GetOfficeNumber()
        {
            return _officeTelephone.GetNumber();
        }

        private void SetOfficeAreaCode(string officeAreaCode)
        {
            _officeTelephone.SetAreaCode(officeAreaCode);
        }

        string GetOfficeAreaCode()
        {
            return _officeTelephone.GetAreaCode();
        }
    }
}