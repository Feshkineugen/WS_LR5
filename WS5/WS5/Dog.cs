class Dog : Animal
{
    public string breed;

    public override void MakeNoise()
    {
        Console.WriteLine("Собака гавкает.");
    }

    public override void Eat()
    {
        Console.WriteLine("Собака ест мясо .");
    }
}