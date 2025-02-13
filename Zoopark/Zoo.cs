namespace Zoopark;

public class Zoo
{
    private readonly List<Animal> animals = new();
    private readonly List<IInventory> inventory = new();
    private readonly VeterinaryClinic clinic;
    
    public Zoo(VeterinaryClinic clinic)
    {
        this.clinic = clinic;
    }

    public void AddAnimal(Animal animal)
    {
        if (clinic.InspectAnimal(animal))
        {
            animals.Add(animal);
            inventory.Add(animal);
            Console.WriteLine($"Animal {animal.GetType().Name} accepted to the zoo.");
        }
        else
        {
            Console.WriteLine($"Oops! Animal {animal.GetType().Name} is ill and could not be accepted to the zoo.");
        }
    }
    
    public void AddThing(Thing thing)
    {
        inventory.Add(thing);
    }
    
    public void PrintFoodReport()
    {
        int totalFood = animals.Sum(a => a.Food);
        int animalAmount = animals.Count();
        Console.WriteLine($"Overall food amount per day: {totalFood} kilos for {animalAmount} animals in zoo.");
    }
    
    public void PrintContactZooAnimals()
    {
        var contactAnimals = animals.OfType<Herbo>().Where(h => h.KindnessLevel > 5);
        Console.WriteLine("Animals that can go to petting zoo:");
        foreach (var animal in contactAnimals)
        {
            animal.DisplayInfo();
        }
    }
    
    public void PrintInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in inventory)
        {
            item.DisplayInfo();
        }
    }
}