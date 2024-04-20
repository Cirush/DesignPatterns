namespace AbstractFactory;

public interface IUserInterfaceAbstractFactory
{
    IButton CreateButton();
    ISlider CreateSlider();
}