namespace AbstractFactory;

public interface IButton
{
    string? Color { get; set; }

    void Click();
}