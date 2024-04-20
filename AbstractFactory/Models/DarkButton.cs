namespace AbstractFactory;

public class DarkButton : IButton
{
    public string? Color { get; set; }

    public void Click()
    {
        Console.WriteLine("Im a DARK 🕶️ BUTTON doing CLICK!");
    }
}