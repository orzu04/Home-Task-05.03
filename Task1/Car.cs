namespace Task1;

public class Car : IVehicle
{
     public int Benzine;


    public Car(int benzin)
    {
    Benzine = benzin;

    }
    public void Drive()
    {
      if(Benzine>0)
      {
        System.Console.WriteLine($"Drive");
      }
      else
      System.Console.WriteLine($"Not drive");
    }

    public bool Refule(int benz)
    {
          var refule = Benzine+benz;
          if(refule>Benzine)
          {
            return true;
          }
       return false;
    }
}
