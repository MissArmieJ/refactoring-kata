using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.ExtractClass
{
    public class TelephoneNumber
    {
        private string _areaCode;
        private string _number;

        public string GetAreaCode()
        {
            return _areaCode; 
        }

        public void SetAreaCode(string areaCode)
        {
            _areaCode = areaCode;
        }

        public string GetNumber()
        {
            return _number;
        }

        public void SetNumber(string number)
        {
            _number = number;
        }
    }
}

