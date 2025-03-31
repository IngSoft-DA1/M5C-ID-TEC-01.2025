namespace Domain;

public class Vehicle
{
    public int DoorQuantity { get; set; }
    public string ChasisColor { get; set; }

    public Vehicle(int doorQuantity, string chasisColor)
    {
        DoorQuantity = doorQuantity;
        ChasisColor = chasisColor;
    }

    public virtual void TurnOn()
    {
    }
}