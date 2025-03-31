using Domain;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        POS pos = new POS(346538983);
        pos.ProcessPayment("1234567887654321", "Visa");
        pos.ProcessPayment("5678956432765432", "Amex");
        pos.ProcessPayment("9876342123456786", "MasterCard");
    }
}