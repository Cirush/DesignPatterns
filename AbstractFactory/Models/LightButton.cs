namespace AbstractFactory;

public class LightButton : IButton
{
    public string? Color { get; set; }

    public void Click()
    {
        Console.WriteLine("Im a LIGHT 🔦 BUTTON doing CLICK!");
    }
}