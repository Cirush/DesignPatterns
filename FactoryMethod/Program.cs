using FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=======================\t");
        Console.WriteLine("Factory Method POC");
        Console.WriteLine("=======================\t");
        ClientCode(new CarCreator());
        ClientCode(new BikeCreator());
    }

    private static void ClientCode(IVehicleCreator creator) 
    {
        Console.WriteLine("I don't know who is the creator and what is going to build.");
        creator.SomeOperation();
    }
}
