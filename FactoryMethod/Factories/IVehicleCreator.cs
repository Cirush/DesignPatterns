namespace FactoryMethod;

public interface IVehicleCreator
{
    IVehicle GetVehicle();

    void SomeOperation();
}