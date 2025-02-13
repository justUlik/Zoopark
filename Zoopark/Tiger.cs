namespace Zoopark;

public class Tiger : Predator
{
    public Tiger(int number, int food) : base(number, food) { }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Tiger (ID: {Number}) - Food: {Food}kg/day, Healthy: {IsHealthy}");
    }
}
