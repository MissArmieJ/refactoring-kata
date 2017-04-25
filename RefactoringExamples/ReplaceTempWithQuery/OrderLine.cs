using System.CodeDom;

namespace RefactoringExamples.ReplaceTempWithQuery
{
    public class OrderLine
    {
        private readonly int _itemPrice;
        private readonly int _quantity;

        public OrderLine(int quantity, int itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double GetPrice()
        {
            return BasePrice() * DiscountFactor();
        }

        private double DiscountFactor()
        {
            return BasePrice() > 1000 ? 0.95 : 0.98;
        }

        private int BasePrice()
        {
            return _quantity*_itemPrice;
        }
    }
}