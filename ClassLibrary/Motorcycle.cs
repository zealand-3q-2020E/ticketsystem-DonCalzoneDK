using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Class of Motorcycle
    /// </summary>
    public class Motorcycle
    {
        /// <summary>
        /// LicensePlate Property for Motorcycle returns type string
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Date property for Motorcycle class returns type DateTime
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Simple method returns Motorcycle price is 125
        /// </summary>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// Simple method returning the string "Motorcycle"
        /// </summary>
        public string VehicleType()
        {
            return "Motorcycle";
        }
    }
}
