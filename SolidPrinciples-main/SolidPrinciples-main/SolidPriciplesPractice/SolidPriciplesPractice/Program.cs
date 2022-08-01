// See https://aka.ms/new-console-template for more information
using SolidPriciplesPractice;

public static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Car simulator App");
        IManufacturer manufacturer = new Tata();
        CarSimulator simlator = new CarSimulator(manufacturer);
        simlator.Execute();
    }
}
public class CarSimulator
{
    IManufacturer _manufaturer;
    public CarSimulator(IManufacturer manufaturer)
    {
        _manufaturer = manufaturer;
    }
    public void Execute()
    {
        _manufaturer.GetCarAccesories();
        _manufaturer.GetCarType();
        _manufaturer.GetCarSpeed();
        _manufaturer.GetCarPrice();
        _manufaturer.GetCarSDisplay();
    }
}