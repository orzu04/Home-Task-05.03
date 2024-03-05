namespace Task2;

class DOg : Animal
{
    public DOg(string name) : base(name)
    {
    }

    public override string GetName()
    {
        return Name;
    }

    public override void Eat()
    {
        System.Console.WriteLine($"Eating");
    }
}

