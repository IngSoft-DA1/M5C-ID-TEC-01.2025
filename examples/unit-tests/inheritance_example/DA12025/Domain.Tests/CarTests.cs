namespace Domain.Tests;

[TestClass]
public class CarTests
{
    [TestMethod]
    public void NewCar_WhenConstructorIsNotEmpty_ThenCarIsCreated()
    {
        //arrange
        Vehicle car;
        //act
        car = new Car(2, "Yellow");
        //assert
        Assert.IsNotNull(car);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewCar_WhenDoorQuantityIsLessThanTwo_ThenThrowException()
    {
        //arrange
        Vehicle car;
        //act
        car = new Car(1, "Yellow");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewCar_WhenDoorQuantityIsMoreThanFive_ThenThrowException()
    {
        //arrange
        Vehicle car;
        //act
        car = new Car(6, "Yellow");
    }

    [TestMethod]
    public void NewCar_WhenDoorQuantityIsCorrect_ThenDoorQuantityIsValid()
    {
        //arrange
        Vehicle car;
        //act
        car = new Car(3, "Yellow");
        //assert
        Assert.AreEqual(3, car.DoorQuantity);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewCar_WhenChasisColorIsEmpty_ThenThrowException()
    {
        //arrange
        Vehicle car;
        //act
        car = new Car(2, "");
    }

    [TestMethod]
    public void NewCar_WhenChasisColorIsNotEmpty_ThenChasisColorIsValid()
    {
        //arrange
        Vehicle car;
        //act
        car = new Car(5, "Yellow");
        //assert
        Assert.AreEqual("Yellow", car.ChasisColor);
    }

    [TestMethod]
    public void Car_WhenInvokeTurnOn_ThenReturnSuccessfully()
    {
        //arrange
        Vehicle car = new Car(4, "Yellow");
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        //act
        car.TurnOn();
        //assert
        var consoleOutput = stringWriter.ToString().Trim();
        Assert.AreEqual("Turning on car with 4 doors and chasis color Yellow", consoleOutput);
    }
}