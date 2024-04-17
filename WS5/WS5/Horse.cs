class Horse : Animal
{
    public string color;

    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь ржёт.");
    }

    public override void Eat()
    {
        Console.WriteLine("Лошадь ест сено.");
    }
}