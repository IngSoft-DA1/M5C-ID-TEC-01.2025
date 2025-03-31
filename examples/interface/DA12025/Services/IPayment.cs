namespace Services;

public interface IPayment
{
    void ProcessPayment(string cardNumber, string cardBrand);
}