namespace Domain.Tests;

[TestClass]
public class ProyectTests
{
    [TestMethod]
    public void NewProyect_WhenConstructorIsNotNull_ThenProyectIsCreated()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("Software Migration", 60000, new DateTime(2025, 08, 01));
        //assert
        Assert.IsNotNull(proyect);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewProyect_WhenNameIsEmpty_ThenThrowException()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("", 60000, new DateTime(2025, 08, 01));
    }

    [TestMethod]
    public void NewProyect_WhenNameIsNotEmpty_ThenNameIsValid()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("Upgrade Libraries", 30000, new DateTime(2025, 12, 01));
        //assert
        Assert.AreEqual("Upgrade Libraries", proyect.Name);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewProyect_WhenBudgetIsCeroOrNegative_ThenThrowException()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("Software Upgrade", 0, new DateTime(2025, 09, 01));
    }

    [TestMethod]
    public void NewProyect_WhenBudgetIsPositive_ThenBudgetIsValid()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("Software Upgrade", 25000, new DateTime(2025, 09, 01));
        Assert.AreEqual(25000, proyect.Budget);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewProyect_WhenStartDateIsEarlierThanToday_ThenThrowException()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("Software Upgrade", 15000, new DateTime(2022, 09, 01));
    }

    [TestMethod]
    public void NewProyect_WhenStartDateIsAfterToday_ThenStartDateIsValid()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("Software Upgrade", 15000, new DateTime(2026, 11, 01));
    }

    [TestMethod]
    public void NewProyect_WhenGivenAnEmptyProyect_ThenStaffListIsEmpty()
    {
        //arrange
        Proyect proyect;
        //act
        proyect = new Proyect("Software Upgrade", 25000, new DateTime(2025, 09, 01));
        Assert.AreEqual(0, proyect.StaffList.Count);
    }

    [TestMethod]
    public void NewProyect_WhenAddingContributorsToTheProyect_ThenStaffListIsNotEmpty()
    {
        //arrange
        Proyect proyect = new Proyect("Software Upgrade", 25000, new DateTime(2025, 09, 01));
        Employee employee = new Employee("John", 19, 5000, 3000);
        Contractor contractor = new Contractor("Sophia", 45, 2800, 60, 180);
        //act
        proyect.AddContributors(employee);
        proyect.AddContributors(contractor);
        //assert
        Assert.AreEqual(2, proyect.StaffList.Count);
        Assert.IsTrue(proyect.StaffList.Contains(employee));
        Assert.IsTrue(proyect.StaffList.Contains(contractor));
    }
}