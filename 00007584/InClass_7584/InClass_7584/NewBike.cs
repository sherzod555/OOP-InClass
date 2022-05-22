using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_7584
{
    class NewBike : Bike
    {
        public NewBike(string brand, string model, int price, int year, string rating)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Year = year;
            Rating = rating;
        }
        protected override Type Type { get => Type.New; set { Type = Type.New; } }
        public override double WithTax()
        {
            //let say there is a tax for new bikes. tax is 5%
            return Price * 0.55;
        }

    }
}
