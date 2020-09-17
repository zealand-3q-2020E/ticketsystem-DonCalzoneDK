using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{

    /// <summary>
    /// Base class Vehicle
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// returns the Price of the car (240)
        /// It's possible to override this method, because it is virtual 
        /// </summary>
        /// <returns>240 dkk</returns>
        public virtual double Price()
        {
            return 240;
        }


        /// <summary>
        /// Abstract method of VehicleType
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();

        /// <summary>
        /// LicensePlate Property for car returns type string
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Date property for car class returns type DateTime
        /// </summary>
        public DateTime Date { get; set; }




    }
}