namespace Domain;

public class Contractor : Person
{
    private decimal hourlyRate;
    private int workedHours;

    public decimal HourlyRate
    {
        get { return hourlyRate; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("hourly rate cannot be less than 0");
            }

            hourlyRate = value;
        }
    }

    public int WorkedHours
    {
        get { return workedHours; }
        set
        {
            workedHours = value;
        }
    }

    public Contractor(string name, int age, decimal baseSalary, decimal hourlyRate, int workedHours) : base(name, age,
        baseSalary)
    {
        HourlyRate = hourlyRate;
        WorkedHours = workedHours;
    }

    public override decimal CalculateSalary()
    {
        return hourlyRate * workedHours;
    }
}