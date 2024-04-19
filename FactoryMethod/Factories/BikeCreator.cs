namespace FactoryMethod;

public class BikeCreator : VehicleCreator
{
    public override IVehicle GetVehicle()
    {
        return new Bike();
    }
}