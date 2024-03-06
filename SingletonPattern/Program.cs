using System;

namespace SingletonPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      President Montenegro = President.getInstance();
      President Serbia = President.getInstance();

      Console.WriteLine((Montenegro==Serbia).ToString());
      Console.ReadLine();
    }
  }
}
