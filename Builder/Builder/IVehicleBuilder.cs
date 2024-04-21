namespace Builder.Builder;

using Models;

public interface IVehicleBuilder
{
    void BuildWheels();
    void BuildBody();
    void BuildEngine();
    void BuildAc();
    void BuildComfortPack();
    IVehicle GetVehicle();
}