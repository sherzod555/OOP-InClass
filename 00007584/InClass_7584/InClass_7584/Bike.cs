using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_7584
{
    public interface IBike
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        int Price { get; set; }
        Condition Condition { get; set; }
        int Year { get; set; }
    }

    abstract class Bike : IBike
    {
        private int _id;
        public int Id { get => _id; set { _id = value; } }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public Condition Condition { get; set; }
        protected abstract Type Type { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }


        public abstract double WithTax();

        public new Type GetType()
        {
            return Type;
        }
    }

    public enum Condition
    {
        Good,
        Normal,
        Bad
    }

    public enum Type
    {
        New,
        Used
    }
}
