using System;
using System.Collections.Generic;
public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}


public class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Людина рухається.");
    }
}

public class Car : Vehicle
{
    public Car()
    {
        Speed = 100;
        Capacity = 5;
    }

    public override void Move()
    {
        Console.WriteLine("Автомобіль рухається.");
    }
}

public class Bus : Vehicle
{
    public Bus()
    {
        Speed = 60;
        Capacity = 30;
    }

    public override void Move()
    {
        Console.WriteLine("Автобус рухається.");
    }
}

public class Train : Vehicle
{
    public Train()
    {
        Speed = 120;
        Capacity = 200;
    }

    public override void Move()
    {
        Console.WriteLine("Поїзд рухається.");
    }
}
public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public Route(string start, string end)
    {
        StartPoint = start;
        EndPoint = end;
    }
}
public class TransportNetwork
{
    public List<Vehicle> Vehicles { get; set; }

    public TransportNetwork()
    {
        Vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }

    public void ControlMovement(Route route)
    {
        foreach (var vehicle in Vehicles)
        {
            Console.WriteLine($"Починаємо рух з {route.StartPoint} до {route.EndPoint} за допомогою {vehicle.GetType().Name}");
            vehicle.Move();
            Console.WriteLine($"Досягли {route.EndPoint}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        TransportNetwork transportNetwork = new
