namespace Domain;

public abstract class Person
{
    private string name;
    private int age;
    private decimal baseSalary;

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }

            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
            {
                throw new ArgumentException("Age must be at least 18");
            }

            age = value;
        }
    }

    public decimal BaseSalary
    {
        get { return baseSalary; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Base salary cannot be zero or negative");
            }

            baseSalary = value;
        }
    }

    public Person(string name, int age, decimal baseSalary)
    {
        Name = name;
        Age = age;
        BaseSalary = baseSalary;
    }

    public abstract decimal CalculateSalary();
}