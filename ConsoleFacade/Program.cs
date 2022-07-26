using ConsoleFacade;
var facade = new RestaurantFacade();

var order = new List<Order>()
{
    new Order(){ Name = "Pizza vegetariana", Price = 20.0,Amount=1, User = "Juan carlos"},
    new Order(){ Name = "Pizza Hawaiana", Price = 52.0,Amount=1, User = "Juan carlos" },
    new Order(){ Name = "Chicken with rice", Price = 20.0,Amount=1, User = "Juan carlos" },
    new Order() { Name = "Chicken with corn", Price = 52.0,Amount=1, User = "Juan carlos" },
    new Order() { Name = "Pizza Carnivora", Price = 20.0,Amount=1, User = "Juan carlos" },
    new Order(){ Name = "Sushi", Price = 52.0,Amount=1, User = "Juan carlos" }
};

facade.OrderFood(order);

Console.ReadLine();
