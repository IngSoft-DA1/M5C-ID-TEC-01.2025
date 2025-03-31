namespace SolucionEjercicio;

public class Person
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }

    public Person()
    {
    }

    public int CalculateAge()
    {
        int age = DateTime.Now.Year - Birthday.Year;

        if (Birthday > DateTime.Now.AddYears(-age))
        {
            age--;
        }

        return age;
    }

    public DayOfWeek GetDayOfWeek()
    {
        return Birthday.DayOfWeek;
    }
}