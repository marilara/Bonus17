using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bonus_17
{
    class UsedCar : Car
    {
        protected double mileage;

        public UsedCar()
        {

        }

        public double Mileage { get { return mileage; } }

        public UsedCar(string make, string model, int year, double price, double mileage) : base (model, make, year, price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.mileage = mileage;
        }

        public override string ToString()
        {

            return $"{Make,-10} {Model,-10} {Year,-10} {Price.ToString("C", CultureInfo.CurrentCulture),-10} (used) {Mileage.ToString("N"), -10} miles";
        }
    }
}
