namespace Domain;

public class Vehicle
{
    private int doorQuantity;
    private string chasisColor;

    public int DoorQuantity
    {
        get => doorQuantity;
        set
        {
            if (value < 2 || value > 5)
            {
                throw new ArgumentException("Door quantity cannot be less than 2 or bigger than 5");
            }
            doorQuantity = value;
        }
    }

    public string ChasisColor
    {
        get => chasisColor;
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Chasis color cannot be null or empty");
            }
            chasisColor = value;
        }
    }

    public Vehicle(int doorQuantity, string chasisColor)
    {
        DoorQuantity = doorQuantity;
        ChasisColor = chasisColor;
    }

    public virtual void TurnOn()
    {
    }
}