namespace FactoryMethod;

public interface IVehicle {
    void Start();
    void Accelerate();
    void Break();
    int GetNumberOfWheels();
}