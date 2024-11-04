// See https://aka.ms/new-console-template for more information

interface CarSpecification
{
    public void ShowSpec();
}
interface CarFactory
{
    public Car CreateCar();
    public CarSpecification CreateSpecification();
}
interface Car
{
    public void PrintCar();
}

class NorthAmericaCarFactory : CarFactory
{
    public Car CreateCar()
    {
        return new Sedan();
    }
    public CarSpecification CreateSpecification()
    {
        return new NorthAmericaSpec();
    }
}

class EuropeCarFactory : CarFactory
{
    public Car CreateCar()
    {
        return new HatchBack();
    }
    public CarSpecification CreateSpecification()
    {
        return new EuropeSpec();
    }
}


class HatchBack : Car
{
    public void PrintCar()
    {
        Console.WriteLine("Hatchbackas.");
    }
}

class Sedan : Car
{
    public void PrintCar()
    {
        Console.WriteLine("Sedanas.");
    }
}


class EuropeSpec : CarSpecification
{
    public void ShowSpec()
    {
        Console.WriteLine("Europe Car Specification: Fuel efficiency and emissions compliant with EU standards.");
    }
}
class NorthAmericaSpec : CarSpecification
{
    public void ShowSpec()
    {
        Console.WriteLine("North America Car Specification: Safety features compliant with local regulations.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Kaip man sukurti masinas ir amerikos faktoriaus?
        CarFactory americaFactory = new NorthAmericaCarFactory();
        Car car = americaFactory.CreateCar();
        CarSpecification spec = americaFactory.CreateSpecification();

        car.PrintCar();
        spec.ShowSpec();

        CarFactory europeFactory = new EuropeCarFactory();
        Car europeCar = europeFactory.CreateCar();
        CarSpecification euSpec = europeFactory.CreateSpecification();

        europeCar.PrintCar();
        euSpec.ShowSpec();

    }
}



