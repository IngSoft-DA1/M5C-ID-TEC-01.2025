namespace Domain;

public class Employee : Person
{
    private decimal anualBond;

    public decimal AnualBond
    {
        get { return anualBond; }
        set
        {
            anualBond = value;
        }
    }

    public Employee(string name, int age, decimal baseSalary, decimal anualBond) : base(name, age, baseSalary)
    {
        AnualBond = anualBond;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + AnualBond;
    }
}