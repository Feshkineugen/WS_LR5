class Veterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Животное ест {animal.food} и находится в локации {animal.location}.");
    }
}