namespace DependencyInjectionDemo.Logic;

public class BetterDemoLogic : IDemoLogic
{
    public int Value1 { private set; get; }
    public int Value2 { private set; get; }
    public BetterDemoLogic()
    {
        Value1 = 25;
        Value2 = 50;
    }
}
