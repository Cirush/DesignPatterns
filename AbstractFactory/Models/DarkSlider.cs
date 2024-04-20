namespace AbstractFactory;

public class DarkSlider : ISlider 
{
    public string? Color { get; set; }

    public void Slide()
    {
        Console.WriteLine("Im a DARK ⬛ SLIDER 🎚️ slidiiing!");
    }
}