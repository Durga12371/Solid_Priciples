using System;

public abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public virtual void StartEngine()
    {
        Console.WriteLine($"Starting the engine of {Brand} {Model}.");
    }

    public abstract void Accelerate();
    public abstract void Brake();
}

public class Car : Vehicle
{
    public override void Accelerate()
    {
        Console.WriteLine($"Accelerating the {Brand} {Model}.");
    }

    public override void Brake()
    {
        Console.WriteLine($"Applying brakes to the {Brand} {Model}.");
    }
}

public class Motorcycle : Vehicle
{
    public override void Accelerate()
    {
        Console.WriteLine($"Revving up the engine of {Brand} {Model}.");
    }

    public override void Brake()
    {
        Console.WriteLine($"Using the brakes on {Brand} {Model}.");
    }
}

public class ElectricCar : Car
{
    public int BatteryLevel { get; set; }

    public override void StartEngine()
    {
        Console.WriteLine($"Initializing electric system of {Brand} {Model}.");
    }

    public override void Accelerate()
    {
        Console.WriteLine($"Speeding up the {Brand} {Model} silently.");
    }
}

public class Demo
{
    public static void PerformAcceleration(Vehicle vehicle)
    {
        vehicle.StartEngine();
        vehicle.Accelerate();
    }

    public static void PerformBraking(Vehicle vehicle)
    {
        vehicle.Brake();
    }

    public static void Main(string[] args)
    {
        Vehicle car = new Car { Brand = "Toyota", Model = "Camry" };
        PerformAcceleration(car);
        PerformBraking(car);

        Vehicle motorcycle = new Motorcycle { Brand = "Harley-Davidson", Model = "Sportster" };
        PerformAcceleration(motorcycle);
        PerformBraking(motorcycle);

        Vehicle electricCar = new ElectricCar { Brand = "Tesla", Model = "Model S", BatteryLevel = 80 };
        PerformAcceleration(electricCar);
        PerformBraking(electricCar);
    }
}
