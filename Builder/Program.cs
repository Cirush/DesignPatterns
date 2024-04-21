// See https://aka.ms/new-console-template for more information
using Builder;
using Builder.Builder;

var director = new Director(new VehicleBuilder());

Console.WriteLine("\n\n==========================");
Console.WriteLine("Builder POC");
Console.WriteLine("==========================\n\n");

Console.WriteLine($"Building a basic car, {director.BuildMinimumCar().ListParts()}");
Console.WriteLine($"Building a full car, {director.BuildFullCar().ListParts()}");