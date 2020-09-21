using System;

namespace Oresundbron
{
    /// <summary>
    /// Car class for Oresundbron
    /// </summary>
    public class Car : ClassLibrary.Car
    {
        /// <summary>
        /// Constructor for Car class with licensePlate, brobizzDiscount and date
        /// </summary>
        public Car(string licensePlate, bool brobizzDiscount, DateTime date)
            : base(licensePlate, brobizzDiscount, date)
        {
        }

        /// <summary>
        /// Override price method
        /// </summary>
        /// <returns>410</returns>
        public override double Price()
        {
            return 410;
        }

        /// <summary>
        /// Override Method for car that will return discounted price if Brobizz
        /// discount is present, if not it will return the price of 410
        /// </summary>
        /// <returns>161 or 410</returns>
        public override double AfterBrobizzDiscount()
        {
            if (BrobizzDiscount)
                return 161;
            return Price();
        }

        /// <summary>
        /// Simple method returning the string "Oresund car"
        /// </summary>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}