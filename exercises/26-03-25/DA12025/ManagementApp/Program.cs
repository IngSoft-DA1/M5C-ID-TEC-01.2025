using Domain;

namespace ManagementApp;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create employees and contractors
            Person employee = new Employee("John", 30, 3000, 1000);
            Person contractor = new Contractor("Anna", 25, 1000, 50, 160);

            // Create proyect
            Proyect proyect = new Proyect("Software Proyect", 50000, new DateTime(2025, 08, 01));

            // Add employees and contractors to the proyect
            proyect.AddContributors(employee);
            proyect.AddContributors(contractor);

            // Show salary of both employees and contractors assigned to the proyect
            Console.WriteLine($"Proyect: {proyect.Name}, Budget: ${proyect.Budget}");
            foreach (var person in proyect.StaffList)
            {
                Console.WriteLine($"{person.Name} has a salary of: ${person.CalculateSalary()}");
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"An unexpected error ocurred: {e.Message}");
        }
    }
}