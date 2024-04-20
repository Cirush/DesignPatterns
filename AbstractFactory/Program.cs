
using AbstractFactory;

public class Program
{
    public static void Main() 
    {
        var lightFactory = new LightModeUserInterfaceFactory();
        var darkFactory = new DarkModeUserInterfaceFactory();

        ClientCode(lightFactory);
        ClientCode(darkFactory);
    }

    private static void ClientCode(IUserInterfaceAbstractFactory factory)
    {
        var button = factory.CreateButton();
        var slider = factory.CreateSlider();

        button.Click();
        slider.Slide();
    }
}