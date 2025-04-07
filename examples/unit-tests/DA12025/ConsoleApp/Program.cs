using Domain;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Vehicle car = new Car(4, "Green");
        Vehicle van = new Van(5, "Red");
        
        vehicles.Add(car);
        vehicles.Add(van);

        foreach (Vehicle v in vehicles)
        {
            v.TurnOn();
        }
    }
}