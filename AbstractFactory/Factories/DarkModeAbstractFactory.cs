namespace AbstractFactory;

public class DarkModeUserInterfaceFactory : IUserInterfaceAbstractFactory
{
    public IButton CreateButton()
    {
        return new DarkButton();
    }

    public ISlider CreateSlider()
    {
        return new DarkSlider();
    }
}