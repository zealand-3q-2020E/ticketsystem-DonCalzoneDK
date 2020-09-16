using System.Runtime.CompilerServices;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TicketUnitTestProject
{
    [TestClass]
    public class UnitTestCar
    {
        [TestMethod]
        public void PriceTestCar()
        {
            //Arrange
            var car = new Car(); 
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(240,price);
        }

        [TestMethod]
        public void VehicleTypeTestCar()
        {
            //Arrange
            var car = new Car();
            //Act
            string type = car.VehicleType();
            //Assert
            Assert.AreSame("Car",type);
        }
    }

    [TestClass]
    public class UnitTestMotorcycle
    {
        [TestMethod]
        public void PriceTestMotorcycle()
        {
            //Arrange
            var mc = new Motorcycle();
            //Act
            double price = mc.Price();
            //Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod]
        public void VehicleTypeTestMotorcycle()
        {
            //Arrange
            var mc = new Motorcycle();
            //Act
            string type = mc.VehicleType();
            //Assert
            Assert.AreSame("Motorcycle", type);
        }
    }
}
