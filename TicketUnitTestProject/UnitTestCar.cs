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
}
