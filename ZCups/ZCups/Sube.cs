using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCups
{
    abstract class Sube
    {
        
        public Esspresso[] EsspressoType { get; set; }
        public FilteredCoffee[] FilteredCoffeeType { get; set; }
        public Frappuccino[] FrappuccinoType { get; set; }
        public abstract Esspresso[] EsspressoTypes();
        public abstract FilteredCoffee[] FilteredCoffeeTypes();
        public abstract Frappuccino[] FrappuccinoTypes();
    }
    class BursaSube : Sube
    {
        public BursaSube()
        {
            EsspressoType = EsspressoTypes();
            FilteredCoffeeType = FilteredCoffeeTypes();
            FrappuccinoType = FrappuccinoTypes();
        }
        public override Esspresso[] EsspressoTypes()
        {
            return new Esspresso[] { (new Esspresso()), (new Americano()), (new Cappuccino()), (new Caffe()), (new WhiteChocolate()), };
        }

        public override FilteredCoffee[] FilteredCoffeeTypes()
        {
            return new FilteredCoffee[] { (new FilteredCoffee()), (new Brew()), (new Misto()), };
        }

        public override Frappuccino[] FrappuccinoTypes()
        {
            return new Frappuccino[] { (new Frappuccino()), (new VanillaFrap()), (new ChocolateFrap()), (new StrawberryFrap()), };
        }
    }
    class YalovaSube : Sube
    {
        public YalovaSube()
        {
            EsspressoType = EsspressoTypes();
            FilteredCoffeeType = FilteredCoffeeTypes();
            FrappuccinoType = FrappuccinoTypes();
        }
        public override Esspresso[] EsspressoTypes()
        {
            return new Esspresso[] { (new Esspresso()), (new Americano()), (new Cappuccino()), (new Caffe()),  };
        }

        public override FilteredCoffee[] FilteredCoffeeTypes()
        {
            return new FilteredCoffee[] { (new FilteredCoffee()), };
        }

        public override Frappuccino[] FrappuccinoTypes()
        {
            return new Frappuccino[] { (new Frappuccino()), (new VanillaFrap()), (new ChocolateFrap()), (new StrawberryFrap()), };
        }
    }
}
