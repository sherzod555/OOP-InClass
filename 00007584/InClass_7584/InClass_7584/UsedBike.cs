using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_7584
{
    class UsedBike : Bike
    {
        public UsedBike(string brand, string model, Condition condition, int price, int year, string rating)
        {
            Brand = brand;
            Model = model;
            Condition = condition;
            Price = price;
            Year = year;
            Rating = rating;
        }

        protected override Type Type { get => Type.Used; set { Type = Type.Used; } }

        public override double WithTax()
        {
            //there is no tax for used bikes
            return Price;
        }

    }
}
