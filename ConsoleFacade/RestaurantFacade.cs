using ConsoleFacade.Utils;

namespace ConsoleFacade
{
    internal class RestaurantFacade
    {
        private readonly Restaurant _restaurant;
        private readonly ShippingService _shippingService;
        public RestaurantFacade()
        {
            _restaurant = new Restaurant();
            _shippingService = new ShippingService();
        }
        public void OrderFood(List<Order> orders)
        {
            foreach (var order in orders)
            {
                _restaurant.AddOrderToCart(order);
            }
            _restaurant.CompleteOrders();

            _shippingService.AcceptOrder(orders);
        }
    }
}
