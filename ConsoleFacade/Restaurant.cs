using System;

namespace ConsoleFacade
{
    public class Restaurant
    {
        private readonly List<Order> _cart;
        public Restaurant()
        {
            _cart = new List<Order>();
        }
        public void AddOrderToCart(Order order)
        {
            _cart.Add(order);
        }
        public void CompleteOrders()
        {
            Console.WriteLine("Orders completed...");
        }
    }
}
