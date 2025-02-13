namespace Zoopark;

public class Rabbit : Herbo
{
    public Rabbit(int number, int food, int kindnessLevel)
        : base(number, food, kindnessLevel) { }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Rabbit (ID: {Number}) - Food: {Food}kg/day, Kindness Level: {KindnessLevel}, Healthy: {IsHealthy}");
    }
}