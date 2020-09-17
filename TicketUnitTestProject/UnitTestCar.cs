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

        //[TestMethod]
        //public void LicensePlateLengthTestMotorcycle()
        //{
        //    //Arrange
        //    var lp = new Motorcycle();
        //    //Act
            
        //    //Assert
        //    Assert.ThrowsException<Exception>(() => lp.LicensePlate.Length.CompareTo("123456677534"),
        //        "License Plate Exceeded The Maximum Length of 7");
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void TestCarLicensePlateLengthOver7()
        //{
        //    //Arrange
        //    Motorcycle mc = new Motorcycle();

        //    //Act
            
        //    //Assert
        //    Assert.Fail("License Plate Exceeded The Maximum Length of 7");
        //}

    }

}
