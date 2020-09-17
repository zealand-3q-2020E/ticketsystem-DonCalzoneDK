using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Class of Motorcycle
    /// </summary>
    public class Motorcycle : Vehicle
    {

        /// <summary>
        /// Simple override method returns Motorcycle price is 125
        /// instead of the default price of vehicle(240)
        /// </summary>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// Simple method returning the string "Motorcycle"
        /// </summary>
        public override string VehicleType()
        {
            return "Motorcycle";
        }

    }
}