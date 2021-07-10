using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Text;

namespace ClassLibrary
{

    /// <summary>
    /// Base class Vehicle
    /// </summary>
    public abstract class Vehicle
    {

        private string _licensePlate;


        /// <summary>
        /// Date property for car class returns type DateTime
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// default properties for BrobizzDiscount
        /// </summary>
        public bool BrobizzDiscount { get; set; }


        /// <summary>
        /// Protected Vehicle Constructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="brobizzDiscount"></param>
        /// <param name="date"></param>
        protected Vehicle(string licensePlate, bool brobizzDiscount, DateTime date)
        {
            LicensePlate = licensePlate;
            BrobizzDiscount = brobizzDiscount;
            Date = date;
        }

        /// <summary>
        /// Default constructor that assigns default values to all its properties
        /// </summary>
        protected Vehicle()
        {
            LicensePlate = default;
            BrobizzDiscount = default;
            Date = default;
        }

        /// <summary>
        /// returns the Price of the car (240)
        /// It's possible to override this method, because it is virtual
        /// set it to the price of car because there will more likely
        /// be more cars than motorcycles crossing the bridge
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
        /// LicensePlate Property for car returns type string and will throw an error if
        /// the length is over of the license plate is over 7 characters long
        /// </summary>
        public string LicensePlate
        {
            get { return this._licensePlate;}
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License Plate Exceeded The Maximum Length of 7");
                    this._licensePlate = value;
                }

            }
        }

        /// <summary>
        /// Returns the discounted price for people using Brobizz
        /// </summary>
        /// <returns>5% discount on ticket price</returns>
        public virtual double AfterBrobizzDiscount()
        {
            if (BrobizzDiscount)
                return Price() * 0.95;
            return Price();
        }

    }
}