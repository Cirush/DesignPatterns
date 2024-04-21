using Builder.Models;

namespace Builder.Builder;

public class VehicleBuilder : IVehicleBuilder
{

    private IVehicle _vehicle = new Vehicle();

    public VehicleBuilder()
    {
        Reset();
    }

    public void Reset() 
    {
        _vehicle = new Vehicle();
    }

    public void BuildAc()
    {
        _vehicle.Add("AC ❄️") ;
    }

    public void BuildBody()
    {
        _vehicle.Add("BODY 🚗");
    }

    public void BuildComfortPack()
    {
        _vehicle.Add("COMFORT PACK 💸");
    }

    public void BuildEngine()
    {
        _vehicle.Add("ENGINE 🚀");
    }

    public void BuildWheels()
    {
        _vehicle.Add("WHEELS 🛞");
    }

    public IVehicle GetVehicle()
    {
        var vehicle = _vehicle;

        Reset();
        
        return vehicle;
    }
}