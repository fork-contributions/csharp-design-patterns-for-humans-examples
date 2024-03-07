using System;
using System.Text;

namespace BuilderPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var burger = new BurgerBuilder(4).AddCheese()
                                      .AddPepperoni()
                                      .AddLettuce()
                                      .AddTomato()
                                      .Build();
    }
  }
}
