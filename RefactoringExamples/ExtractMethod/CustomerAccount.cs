using System.Collections.Generic;

namespace RefactoringExamples.ExtractMethod
{
    public class CustomerAccount
    {
        private readonly IOutput _output;
        private readonly IEnumerable<Order> _orders;
        private readonly string _name;

        public CustomerAccount(IOutput output, IEnumerable<Order> orders, string name)
        {
            _output = output;
            _orders = orders;
            _name = name;
        }

        public void PrintOwing()
        {
            PrintBanner();

            var outstanding = CalculateOutstanding();

            PrintDetails(outstanding);
        }

        private double CalculateOutstanding()
        {
            var outstanding = 0.0;
            foreach (var order in _orders)
            {
                outstanding += order.Amount;
            }
            return outstanding;
        }

        private void PrintDetails(double outstanding)
        {
            _output.WriteLine("name:" + _name);
            _output.WriteLine("amount:" + outstanding);
        }

        private void PrintBanner()
        {
            _output.WriteLine("*************************");
            _output.WriteLine("***** Customer Owes *****");
            _output.WriteLine("*************************");
        }
    }
}