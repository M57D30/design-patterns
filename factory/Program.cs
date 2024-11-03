

using System.Data;

abstract class Vehicle
{
    public abstract void PrintVehicle();
}

class FourWheeler : Vehicle
{
    public override void PrintVehicle()
    {
        Console.WriteLine("i am four wheeler.");
    }
}

class TwoWheeeler : Vehicle
{
    public override void PrintVehicle()
    {
        Console.WriteLine("i am two wheeler.");
    }
}

interface IVehicleFactory
{
    public Vehicle CreateVehicle();
}

class TwoWheeelerFactory : IVehicleFactory
{
    public Vehicle CreateVehicle()
    {
        return new TwoWheeeler();
    }
}

class FourWheelerFactory : IVehicleFactory
{
    public Vehicle CreateVehicle()
    {
        return new FourWheeler();
    }
}



class Client
{
    private readonly Vehicle _vehicle;

    public Client(IVehicleFactory factory)
    {
        _vehicle = factory.CreateVehicle();
    }

    public Vehicle GetVehicle()
    {
        return _vehicle;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IVehicleFactory twoWheeler = new TwoWheeelerFactory();
        Client client = new Client(twoWheeler);
        Vehicle vehicle = client.GetVehicle();
        vehicle.PrintVehicle();


        IVehicleFactory fourWheeler = new FourWheelerFactory();
        Client client1 = new Client(fourWheeler);
        Vehicle vehicleFourWheels = client.GetVehicle();
        vehicleFourWheels.PrintVehicle();

    }

}




