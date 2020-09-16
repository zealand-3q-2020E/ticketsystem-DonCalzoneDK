using System;

namespace ClassLibrary
{
    /// <summary>
    /// Class of Car
    /// </summary>
    public class Car
    {
        /// <summary>
        /// LicensePlate Property for car returns type string
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Date property for car class returns type DateTime
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Simple method returns cars price is 240
        /// </summary>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// Simple method returning the string "Car"
        /// </summary>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
