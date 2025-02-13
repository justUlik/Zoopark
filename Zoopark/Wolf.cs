namespace Zoopark;

public class Wolf : Predator
{
    public Wolf(int number, int food) : base(number, food) { }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"Wolf (ID: {Number}) - Food: {Food}kg/day, Healthy: {IsHealthy}");
    }
}