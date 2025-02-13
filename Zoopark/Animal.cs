namespace Zoopark;

public abstract class Animal : IAlive, IInventory
{
    public int Food { get; protected set; }
    public int Number { get; private set; }
    public bool IsHealthy { get;  set; }

    protected Animal(int number, int food)
    {
        Number = number;
        Food = food;
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Animal (ID: {Number}) - Food: {Food}kg/day, Healthy: {IsHealthy}");
    }
}