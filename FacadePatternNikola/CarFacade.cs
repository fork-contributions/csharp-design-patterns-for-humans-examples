class CarFacade
{
  private readonly Car car;

  public CarFacade(Car car)
  {
        this.car = car;
  }

  public void UpaliAuto()
  {
    car.SpustiRucnu();
    car.OkreniKljuc();
  }

  public void UgasiAuto()
  {
    car.IzbaciIzBrzine();
    car.OkreniKljuc();
  }
}