using System;
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
            var car = new Car("1234567", false, DateTime.Now); 
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(240,price);
        }

        [TestMethod]
        public void VehicleTypeTestCar()
        {
            //Arrange
            var car = new Car("1234567", false, DateTime.Now);
            //Act
            string type = car.VehicleType();
            //Assert
            Assert.AreSame("Car",type);
        }

        [TestMethod]
        public void BrobizzDiscountPriceTestCar()
        {
            //Arrange
            var car = new Car("1234567", true, DateTime.Now);
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(240,price, 0.95);
        }

        [TestMethod]
        public void AcceptableLicensePlateLengthOf7TestCar()
        {
            //Arrange
            var car = new Car("1234567", false, DateTime.Now);
            //Act
            string vehicleType = car.VehicleType();
            //Assert
            Assert.AreEqual("Car",vehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnacceptableLicensePlateLengthOf8OrMoreTestCar()
        {
            //Arrange
            var car = new Car("12345678", false, DateTime.Now);
            //Act
            string vehicleType = car.VehicleType();
            //Assert
            Assert.AreEqual("Car", vehicleType);
        }

    }

    [TestClass]
    public class UnitTestMotorcycle
    {
        [TestMethod]
        public void PriceTestMotorcycle()
        {
            //Arrange
            var mc = new Motorcycle("1234567", false, DateTime.Now);
            //Act
            double price = mc.Price();
            //Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod]
        public void VehicleTypeTestMotorcycle()
        {
            //Arrange
            var mc = new Motorcycle("1234567",false, DateTime.Now);
            //Act
            string type = mc.VehicleType();
            //Assert
            Assert.AreSame("Motorcycle", type);
        }

        [TestMethod]
        public void BrobizzDiscountPriceTestMotorcycle()
        {
            //Arrange
            var mc = new Motorcycle("1234567", true, DateTime.Now);
            //Act
            double price = mc.Price();
            //Assert
            Assert.AreEqual(125, price, 0.95);
        }

        [TestMethod]
        public void AcceptableLicensePlateLengthOf7TestMotorcycle()
        {
            //Arrange
            var mc = new Motorcycle("1234567", false, DateTime.Now);
            //Act
            string vehicleType = mc.VehicleType();
            //Assert
            Assert.AreEqual("Motorcycle", vehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnacceptableLicensePlateLengthOf8OrMoreTestMotorcycle()
        {
            //Arrange
            var mc = new Motorcycle("12345678", false, DateTime.Now);
            //Act
            string vehicleType = mc.VehicleType();
            //Assert
            Assert.AreEqual("Motorcycle", vehicleType);
        }

    }

}
