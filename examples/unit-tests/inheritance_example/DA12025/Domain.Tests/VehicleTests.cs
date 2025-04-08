namespace Domain.Tests;

[TestClass]
public class VehicleTests
{
    [TestMethod]
    public void NewVehicle_WhenConstructorIsNotEmpty_ThenVehicleIsCreated()
    {
        //arrange
        Vehicle vehicle;
        //act
        vehicle = new Vehicle(2, "Green");
        //assert
        Assert.IsNotNull(vehicle);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewVehicle_WhenDoorQuantityIsLessThanTwo_ThenThrowException()
    {
        //arrange
        Vehicle vehicle;
        //act
        vehicle = new Vehicle(1, "Green");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewVehicle_WhenDoorQuantityIsMoreThanFive_ThenThrowException()
    {
        //arrange
        Vehicle vehicle;
        //act
        vehicle = new Vehicle(6, "Green");
    }

    [TestMethod]
    public void NewVehicle_WhenDoorQuantityIsCorrect_ThenDoorQuantityIsValid()
    {
        //arrange
        Vehicle vehicle;
        //act
        vehicle = new Vehicle(3, "Green");
        //assert
        Assert.AreEqual(3, vehicle.DoorQuantity);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewVehicle_WhenChasisColorIsNullOrEmpty_ThenThrowException()
    {
        //arrange
        Vehicle vehicle;
        //act
        vehicle = new Vehicle(2, "");
    }

    [TestMethod]
    public void NewVehicle_WhenChasisColorIsNotEmpty_ThenChasisColorIsValid()
    {
        //arrange
        Vehicle vehicle;
        //act
        vehicle = new Vehicle(5, "Blue");
        //assert
        Assert.AreEqual("Blue", vehicle.ChasisColor);
    }

    [TestMethod]
    public void Vehicle_WhenInvokeTurnOn_ThenReturnSuccessfully()
    {
        //arrange
        Vehicle vehicle = new Vehicle(3, "Green");
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        //act
        vehicle.TurnOn();
        //assert
        string consoleOutput = stringWriter.ToString().Trim();
        Assert.AreEqual("", consoleOutput);
    }
}