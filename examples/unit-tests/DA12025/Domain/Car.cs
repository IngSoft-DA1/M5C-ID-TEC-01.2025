namespace Domain;

public class Car : Vehicle
{
    public Car(int doorQuantity, string chasisColor) : base(doorQuantity, chasisColor)
    {
    }

    public override void TurnOn()
    {
        Console.WriteLine($"Turning on car with {DoorQuantity} doors and chasis color {ChasisColor}");
    }
}