using System;

namespace BridgePattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var darkTheme = new DarkTheme();

      var about = new About(darkTheme);
      var careers = new Careers(darkTheme);

      Console.WriteLine(about.GetContent());
      Console.WriteLine(careers.GetContent());
    }
  }
}
