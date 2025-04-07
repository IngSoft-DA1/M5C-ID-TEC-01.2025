namespace Domain.Tests;

[TestClass]
public class VanTests
{
    [TestMethod]
    public void NewVan_WhenConstructorIsNotEmpty_ThenVanIsCreated()
    {
        //arrange
        Vehicle van;
        //act
        van = new Van(2, "Gray");
        //assert
        Assert.IsNotNull(van);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewVan_WhenDoorQuantityIsLessThanTwo_ThenThrowException()
    {
        //arrange
        Vehicle van;
        //act
        van = new Van(1, "Gray");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewVan_WhenDoorQuantityIsMoreThanFive_ThenThrowException()
    {
        //arrange
        Vehicle van;
        //act
        van = new Van(6, "Gray");
    }

    [TestMethod]
    public void NewVan_WhenDoorQuantityIsCorrect_ThenDoorQuantityIsValid()
    {
        //arrange
        Vehicle van;
        //act
        van = new Van(3, "Gray");
        //assert
        Assert.AreEqual(3, van.DoorQuantity);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void NewVan_WhenChasisColorIsEmpty_ThenThrowException()
    {
        //arrange
        Vehicle van;
        //act
        van = new Van(2, "");
    }

    [TestMethod]
    public void NewVan_WhenChasisColorIsNotEmpty_ThenChasisColorIsValid()
    {
        //arrange
        Vehicle van;
        //act
        van = new Van(5, "Gray");
        //assert
        Assert.AreEqual("Gray", van.ChasisColor);
    }

    [TestMethod]
    public void Van_WhenInvokeTurnOn_ThenReturnSuccessfully()
    {
        //arrange
        Vehicle van = new Van(4, "Gray");
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        //act
        van.TurnOn();
        var consoleOutput = stringWriter.ToString().Trim();
        //assert
        Assert.AreEqual("Turning on van with 4 doors and chasis color Gray", consoleOutput);
    }
    
}