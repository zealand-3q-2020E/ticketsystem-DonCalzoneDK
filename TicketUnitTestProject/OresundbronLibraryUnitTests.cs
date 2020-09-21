using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;

namespace TicketUnitTestProject
{
    [TestClass]
    public class OresundbronLibraryUnitTests
    {

        [TestMethod]
        public void CarTestVehicleType()
        {
            //Arrange
            var car = new Car("1234567", false, DateTime.Now);

            //Act
            string vehicleType = car.VehicleType();

            //Assert
            Assert.AreEqual("Oresund car", vehicleType);
        }

        [TestMethod]
        public void MotorcycleTestVehicleType()
        {
            //Arrange
            var mc = new Motorcycle("1234567", false, DateTime.Now);

            //Act
            string vehicleType = mc.VehicleType();

            //Assert
            Assert.AreEqual("Oresund MC", vehicleType);
        }

        [TestMethod]
        public void CarPriceNoDiscountsTestOresundbron()
        {
            //Arrange
            var car = new Car("1234567", false, DateTime.Now);

            //Act
            double price = car.AfterBrobizzDiscount();

            //Assert
            Assert.AreEqual(410, price);
        }

        [TestMethod]
        public void CarPriceBrobizzDiscountTestOresundbron()
        {
            //Arrange
            var car = new Car("1234567", true, DateTime.Now);

            //Act
            double price = car.AfterBrobizzDiscount();

            //Assert
            Assert.AreEqual(161, price);
        }

        [TestMethod]
        public void MotorcyclePriceNoDiscountsTestOresundbron()
        {
            //Arrange
            var motorcycle = new Motorcycle("1234567", false, DateTime.Now);

            //Act
            double price = motorcycle.AfterBrobizzDiscount();

            //Assert
            Assert.AreEqual(210, price);
        }

        [TestMethod]
        public void MotorcyclePriceBrobizzDiscountTestOresundbron()
        {
            //Arrange
            var motorcycle = new Motorcycle("1234567", true, DateTime.Now);

            //Act
            double price = motorcycle.AfterBrobizzDiscount();

            //Assert
            Assert.AreEqual(73, price);
        }
    }
}