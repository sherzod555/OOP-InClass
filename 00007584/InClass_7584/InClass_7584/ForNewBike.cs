using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_7584
{
    class ForNewBike
    {

        public List<Bike> SearchNew(Store str, string selection, string request)
        {
            List<Bike> result = new List<Bike>();

            foreach (Bike bike in str.GetAllBikes())
            {
                if (bike.GetType() == Type.New)
                {
                    if (selection == "1" && bike.Brand.ToLower().Contains(request.ToLower()))
                    {
                        result.Add(bike);
                    }
                    else if (selection == "2" && bike.Model.ToLower().Contains(request.ToLower()))
                    {
                        result.Add(bike);
                    }
                    else if (selection == "3" && bike.Price.ToString() == request)
                    {
                        result.Add(bike);
                    }
                }
            }

            return result;
        }

    }
}
