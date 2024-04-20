namespace AbstractFactory;

public class LightSlider : ISlider 
{
    public string? Color { get; set; }
    
    public void Slide()
    {
        Console.WriteLine("Im a LIGHT ⬜ SLIDER 🎚️ slidiiing!");
    }
}