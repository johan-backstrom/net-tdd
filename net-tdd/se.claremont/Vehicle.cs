using System;

namespace net_tdd.se.claremont
{
    public class Vehicle
    {
        public string make { get; set; }
        public int yearOfManufacturing { get; set; }
        public int newPrice { get; set; }
        private Condition condition;
        public string licencePlate { get; set; }

        public Vehicle(String make, int yearOfManufacturing, int newPrice, Condition condition)
        {
            this.make = make;
            this.condition = condition;
            this.newPrice = newPrice;
            this.yearOfManufacturing = yearOfManufacturing;
        }

        public enum Condition
        {
            mint,
            used,
            crap
        }

        public Condition getCondition()
        {
            return condition;
        }

        public Vehicle setCondition(Condition condition)
        {
            this.condition = condition;
            return this;
        }
    }
}
