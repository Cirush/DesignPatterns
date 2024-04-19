namespace FactoryMethod;

public class Bike : IVehicle
{
    public void Accelerate()
    {
        throw new NotImplementedException();
    }

    public void Break()
    {
        throw new NotImplementedException();
    }

    public int GetNumberOfWheels()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "A BIKE! 🛵";
    }
}