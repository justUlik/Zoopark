namespace Zoopark;

public class Thing : IInventory
{
    public int Number { get; private set; }
    public string Name { get; private set; }

    public Thing(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Thing (ID: {Number}) - Name {Name}");
    }
}