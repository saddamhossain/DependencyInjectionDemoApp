namespace DependencyInjectionDemo.Logic;

public class DemoLogic : IDemoLogic
{
    public int Value1 { private set; get; }
    public int Value2 { private set; get; }
    public DemoLogic()
    {
        Value1 = Random.Shared.Next(1, 1001);
        Value2 = Random.Shared.Next(1, 1001);
    }
}
