class Cat : Animal
{
    public int livesLeft;

    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяукает.");
    }

    public override void Eat()
    {
        Console.WriteLine("Кошка ест рыбу.");
    }
}