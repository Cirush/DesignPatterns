namespace FactoryMethod;

// This could be also an interface but with the abstract class we could have some business logic even here.
public abstract class VehicleCreator : IVehicleCreator
{
    public abstract IVehicle GetVehicle();

    public void SomeOperation()
    {
        var vehicle = GetVehicle();

        Console.WriteLine($"\tPerforming some operation and created {vehicle}");
    }
}
