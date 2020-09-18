using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Class of Car
    /// </summary>
    public class Car : Vehicle
    {


        /// <summary>
        /// Empty Constructor for class car 
        /// </summary>
        public Car(string licensePlate, bool brobizzDiscount, DateTime date) 
            : base(licensePlate, brobizzDiscount, date) { }


        /// <summary>
        /// Simple method returning the string "Car"
        /// </summary>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}