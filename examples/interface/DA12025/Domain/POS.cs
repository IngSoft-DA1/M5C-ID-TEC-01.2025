using Services;

namespace Domain;

public class POS: IPayment
{
    public int Id { get; set; }

    public POS(int id)
    {
        Id = id;
    }

    public void ProcessPayment(string cardNumber, string cardBrand)
    {
        if (cardNumber.Length == 16 && cardBrand.Equals("Visa"))
        {
            Console.WriteLine($"Processing payment for {cardBrand} card with number {cardNumber}");
        }
        else if (cardNumber.Length == 16 && cardBrand.Equals("Amex"))
        {
            Console.WriteLine($"Processing payment for {cardBrand} card with number {cardNumber}");
        }
        else
        {
            Console.WriteLine($"Cannot process the payment for this card");
        }
    }
}