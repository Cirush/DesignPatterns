namespace AbstractFactory;

public class LightModeUserInterfaceFactory : IUserInterfaceAbstractFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }

    public ISlider CreateSlider()
    {
        return new LightSlider();
    }
}