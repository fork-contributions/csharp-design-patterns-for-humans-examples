using System;

namespace DecoratorPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var myCoffee = new SimpleCoffee();
      Console.WriteLine("{0:c}",myCoffee.GetCost()); // $ 5.00
      Console.WriteLine("{0}", myCoffee.GetDescription()); // Simple Coffee

      var milkCoffee = new MilkCoffee(myCoffee);
      Console.WriteLine("{0:c}", milkCoffee.GetCost()); // $ 6.00
      Console.WriteLine("{0}", milkCoffee.GetDescription()); // Simple Coffee, milk
    
      var vanillaCoffee = new VanillaCoffee(whipCoffee);
      Console.WriteLine("{0:c}", vanillaCoffee.GetCost()); // $ 8.00
      Console.WriteLine("{0}", vanillaCoffee.GetDescription()); // Simple Coffee, milk, whip
      Console.ReadLine();
    }
  }
}
