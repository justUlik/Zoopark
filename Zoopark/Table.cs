namespace Zoopark;

public class Table : Thing
{
    public Table(int number) : base(number, "Table") { }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Table (ID: {Number}) - Name {Name}");
    }
}