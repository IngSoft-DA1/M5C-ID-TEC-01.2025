namespace Domain;

public class Proyect
{
    private string name;
    private decimal budget;
    private DateTime startDate;
    private List<Person> staffList;

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

    public decimal Budget
    {
        get { return budget; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Budget cannot be less or equal to zero");
            }

            budget = value;
        }
    }

    public DateTime StartDate
    {
        get { return startDate; }
        set
        {
            if (value < DateTime.Now)
            {
                throw new ArgumentException("Start date cannot be earlier than today");
            }

            startDate = value;
        }
    }

    public List<Person> StaffList
    {
        get { return staffList; }
    }

    public Proyect(string name, decimal budget, DateTime startDate)
    {
        Name = name;
        Budget = budget;
        StartDate = startDate;
        staffList = new List<Person>();
    }

    public void AddContributors(Person person)
    {
        staffList.Add(person);
    }
}