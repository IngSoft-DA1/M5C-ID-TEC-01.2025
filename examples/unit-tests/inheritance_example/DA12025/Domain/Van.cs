namespace Domain;

public class Van: Vehicle
{
    public Van(int doorQuantity, string chasisColor) : base(doorQuantity, chasisColor)
    {
    }
    
    public override void TurnOn()
    {
        Console.WriteLine($"Turning on van with {DoorQuantity} doors and chasis color {ChasisColor}");
    }
}