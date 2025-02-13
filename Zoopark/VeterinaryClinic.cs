using System.Security.Cryptography;

namespace Zoopark;



public class VeterinaryClinic
{
    public bool InspectAnimal(Animal animal)
    {
        Random random = new Random();
        bool isHealthy = random.Next(2) == 1;
        animal.IsHealthy = isHealthy;
        return animal.IsHealthy;
    }
}