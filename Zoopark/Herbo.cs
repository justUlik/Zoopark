namespace Zoopark;

public abstract class Herbo : Animal
{
    public int KindnessLevel { get; private set; }
    
    protected Herbo(int number, int food, int kindnessLevel)
        : base(number, food)
    {
        KindnessLevel = kindnessLevel;
    }
}