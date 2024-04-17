class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.food = "мясо";
        dog.location = "будка";
        dog.breed = "такса";

        Cat cat = new Cat();
        cat.food = "молоко";
        cat.location = "квартира";
        cat.livesLeft = 7;

        Horse horse = new Horse();
        horse.food = "сено";
        horse.location = "пастбище";
        horse.color = "чёрный";

        Veterinarian vet = new Veterinarian();
        vet.TreatAnimal(dog);
        vet.TreatAnimal(cat);
        vet.TreatAnimal(horse);
    }
}