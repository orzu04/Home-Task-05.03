namespace Task2;

public abstract class Animal
{

  public string Name;

  public Animal(string name)
  {
   
   Name = name;

  }

  public void  SetName (string name)
  {
    Name = name;
  }


  public virtual string GetName()
  {
    return Name;
  }

  public virtual void  Eat()
  {

  }


}
