using System;
using System.Runtime.CompilerServices;
using StoreBaeltTicketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TicketUnitTestProject
{
    [TestClass]
    public class StorebaeltsbroenLibraryUnitTests
    {
        [TestMethod]
        public void CarPriceWeekdayWithNoDiscountsTestStorebaeltsBroen()
        {
            //Arrange
            var car = new Car("1234567", false, new DateTime(2020, 09, 21));

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(240, price);
        }

        [DataTestMethod]
        [DataRow(2020, 09, 21)]
        [DataRow(2020, 09, 22)]
        [DataRow(2020, 09, 23)]
        [DataRow(2020, 09, 24)]
        [DataRow(2020, 09, 25)]
        [DataRow(2020, 10, 05)]
        public void CarPriceWeekdayWithBrobizzDiscountTestStorebaeltsBroen(int year, int month, int day)
        {
            //Arrange
            var car = new Car("1234567", true, new DateTime(year, month, day));

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(240, price, 240 * 0.95);
        }

        [DataTestMethod]
        [DataRow(2020,09, 19)]
        [DataRow(2020, 09, 20)]
        [DataRow(2020, 10, 03)]
        [DataRow(2020, 10, 04)]
        public void CarPriceWeekEndWithNoBrobizzDiscountTestStorebaeltsBroen(int year, int month, int day)
        {
            //Arrange
            var car = new Car("1234567", false, new DateTime(year, month, day));

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(240, price, 240 * 0.80);
        }


        [DataTestMethod]
        [DataRow(2020, 09, 19)]
        [DataRow(2020, 09, 20)]
        [DataRow(2020, 10, 03)]
        [DataRow(2020, 10, 04)]
        public void CarPriceWeekEndWithBrobizzDiscountTestStorebaeltsBroen(int year, int month, int day)
        {
            //Arrange
            var car = new Car("1234567", true, new DateTime(year, month, day));

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(240, price, (240 * 0.80) * 0.95);
        }


    }

}
