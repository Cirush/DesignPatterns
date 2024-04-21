namespace Builder;

using Models;
using Builder;

public class Director(IVehicleBuilder builder)
{
    private readonly IVehicleBuilder _builder = builder;

    public IVehicle BuildMinimumCar()
    {
        _builder.BuildBody();
        _builder.BuildEngine();
        _builder.BuildWheels();

        return _builder.GetVehicle();
    }

    public IVehicle BuildFullCar()
    {
        _builder.BuildBody();
        _builder.BuildEngine();
        _builder.BuildWheels();
        _builder.BuildComfortPack();
        _builder.BuildAc();

        return _builder.GetVehicle();
    }
}