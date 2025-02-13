namespace Zoopark;

public class Computer : Thing
{
    public Computer(int number) : base(number, "Computer") { }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Computer (ID: {Number}) - Name {Name}");
    }
}