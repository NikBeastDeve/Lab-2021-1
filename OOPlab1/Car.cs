using System;
namespace OOPlab1
{
    public class Car
    {
        public string Make;
        public string Model;
        public decimal Value;
        public string Color;

        public Car()
        {
        }

        public override bool Equals(object obj)
        {
            var otherCar = obj as Car;
            if (otherCar == null)
            {
                return false;
            }
            return this.Make == otherCar.Make && this.Model == otherCar.Model;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override string ToString()
        {
            return this.Make + " " + this.Model;
        }
    }
}
