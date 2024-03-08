using System;

namespace FacadePatternNikola
{
  class Program
  {
    static void Main(string[] args)
    {
      var car = new CarFacade(new Car());
      car.UpaliAuto();
      car.UgasiAuto();
    }
  }
}
