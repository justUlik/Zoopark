namespace Zoopark;

public class Monkey : Herbo
{
    public Monkey(int number, int food, int kindnessLevel)
        : base(number, food, kindnessLevel) { }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Monkey (ID: {Number}) - Food: {Food}kg/day, Kindness Level: {KindnessLevel}, Healthy: {IsHealthy}");
    }
}