using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_7584
{
    class Store
    {
        private List<Bike> Bikes;





        //Facade
        private ForNewBike _NewProvider;
        private ForUsedBike _UsedProvider;

        private Store()
        {
            Bikes = new List<Bike>();

            _NewProvider = new ForNewBike();
            _UsedProvider = new ForUsedBike();
        }








        private static Store _myStore;

        public static Store GetStore()
        {
            //return store
            //if store is null then return new store

            return _myStore ??= new Store();
        }

        public List<Bike> GetAllBikes()
        {
            return Bikes;
        }








        //Factory

        public void AddBike(Bike bike)
        {
            Store str = GetStore();
            str.Bikes.Add(bike);
        }







        //POLIMORPHISM

        public void AddBike(string brand, string model, int price, int year, string rating)
        {
            Store str = GetStore();
            str.Bikes.Add(new NewBike(brand, model, price, year, rating));
        }

        public void AddBike(string brand, string model, Condition condition, int price, int year, string rating)
        {
            Store str = GetStore();
            str.Bikes.Add(new UsedBike(brand, model, condition, price, year, rating));
        }

        public List<Bike> SearchNew(Store str, string selection, string request)
        {
            return _NewProvider.SearchNew(str, selection, request);
        }

        public List<Bike> SearchUsed(Store str, string selection, string request)
        {
            return _UsedProvider.SearchUsed(str, selection, request);

        }

        public void PopulateBikesForTest()
        {
            AddBike(new NewBike("Cannondale", "700M", 1600, 2021, "8"));
            AddBike(new NewBike("Felt", "VR60", 1399, 2021, "7"));
            AddBike(new UsedBike("Detrospec", "Culver Road", Condition.Good, 1000, 2019, "7"));
            AddBike(new UsedBike("Radon", "Scart Light", Condition.Normal, 720, 2017, "5"));

            AddBike("Cube", "Acid 240", 416, 2021, "9");
            AddBike("Specialized", "Allez", Condition.Bad, 299, 2017, "6");
        }

    }
}
