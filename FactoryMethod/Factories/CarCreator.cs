namespace FactoryMethod;

public class CarCreator : VehicleCreator
{
    public override IVehicle GetVehicle()
    {
        return new Car();
    }
}