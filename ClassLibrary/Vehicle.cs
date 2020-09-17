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
                    throw new ArgumentOutOfRangeException("License Plate Exceeded The Maximum Length of 7");
                }

                this._licensePlate = value;
            }
        }

        /// <summary>
        /// Date property for car class returns type DateTime
        /// </summary>
        public DateTime _date { get; set; }

        

    }
}