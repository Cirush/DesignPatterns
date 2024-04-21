namespace Builder.Models;

public interface IVehicle
{
    void Add(String part);

    String ListParts();
}