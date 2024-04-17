class Animal
{
    public string food;
    public string location;

    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное издает звук.");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Животное ест.");
    }

    public void Sleep()
    {
        Console.WriteLine("Животное спит.");
    }
}