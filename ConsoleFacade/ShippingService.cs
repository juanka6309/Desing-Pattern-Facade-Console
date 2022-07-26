using ConsoleFacade.Utils;

namespace ConsoleFacade
{
    public class ShippingService
    {
        private Order _order;
        double total;

        public void AcceptOrder(List<Order> orders)
        {
            Print.PrintHeader();
            foreach (var order in orders)
            {
                _order = order;
                printOrderDetail();
            }
            Print.PrintFooter(OrderTotal(orders));
        }
        public void printOrderDetail()
        {
            _order.ShowOrder();
        }

        public double OrderTotal(List<Order> orders)
        {
            foreach (var order in orders)
            {
                total = total + (order.Price * order.Amount);
            }
            return total;
        }
    }
}
