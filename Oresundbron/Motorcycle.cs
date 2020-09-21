using System;
using System.Collections.Generic;
using System.Text;

namespace Oresundbron
{
    /// <summary>
    /// Motorcycle Class for Oresundbron
    /// </summary>
    public class Motorcycle : ClassLibrary.Motorcycle
    {
        /// <summary>
        /// Motorcycle Constructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="brobizzDiscount"></param>
        /// <param name="date"></param>
        public Motorcycle(string licensePlate, bool brobizzDiscount, DateTime date)
            : base(licensePlate, brobizzDiscount, date) { }
        /// <summary>
        /// Simple override method returns Motorcycle price is 125
        /// instead of the default price of vehicle(240)
        /// </summary>
        public override double Price()
        {
            return 210;
        }

        /// <summary>
        /// Override Method for Motorcycle that will return discounted price if 
        /// BrobizzDiscount is present, if not it will return the price of 410
        /// </summary>
        /// <returns>210 or 73</returns>
        public override double AfterBrobizzDiscount()
        {
            if (BrobizzDiscount)
                return 73;
            return Price();
        }


        /// <summary>
        /// Simple method returning the string "Motorcycle"
        /// </summary>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}