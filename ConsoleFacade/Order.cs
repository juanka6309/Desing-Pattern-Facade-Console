using ConsoleFacade.Utils;

namespace ConsoleFacade
{
    public class Order
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string User { get; set; }
        public int Amount { get; set; }

        public void ShowOrder()
        {
            Print.PrintRow(Name, Amount.ToString(), Price.ToString("0.00"));
            Print.PrintLine();
        }
    }
}
