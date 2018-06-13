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
        public abstract void update(object o, double raise);
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
            Esspresso[] esspresso = new Esspresso[] { (new Esspresso()), (new Americano()), (new Cappuccino()), (new Caffe()), (new WhiteChocolate()), };
            foreach (var o in esspresso)
            {
                singleton.Instance.BursaBeveragesTypes[o.ToString()] = true;
            }
            return esspresso;
        }

        public override FilteredCoffee[] FilteredCoffeeTypes()
        {
            FilteredCoffee[] filteredCoffee = new FilteredCoffee[] { (new FilteredCoffee()), (new Brew()), (new Misto()), };
            foreach (var o in filteredCoffee)
            {
                singleton.Instance.BursaBeveragesTypes[o.ToString()] = true;
            }
            return filteredCoffee;
        }

        public override Frappuccino[] FrappuccinoTypes()
        {
            Frappuccino[] frappuccino = new Frappuccino[] { (new Frappuccino()), (new VanillaFrap()), (new ChocolateFrap()), (new StrawberryFrap()), };
            foreach (var o in frappuccino)
            {
                singleton.Instance.BursaBeveragesTypes[o.ToString()] = true;
            }
            return frappuccino;
        }

        public override void update(object o, double raise)
        {
           
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
            Esspresso[] esspresso= new Esspresso[] { (new Esspresso()), (new Americano()), (new Cappuccino()), (new Caffe()),  };
            foreach (var o in esspresso)
            {
                singleton.Instance.YalovaBeveragesTypes[o.ToString()] = true;
             }
            return esspresso;
        }

        public override FilteredCoffee[] FilteredCoffeeTypes()
        {
            FilteredCoffee[] filteredCoffee = new FilteredCoffee[] { (new FilteredCoffee()), };
            foreach (var o in filteredCoffee)
            {
                singleton.Instance.YalovaBeveragesTypes[o.ToString()] = true;
            }
            return filteredCoffee;
        }

        public override Frappuccino[] FrappuccinoTypes()
        {
            Frappuccino[] frappuccino = new Frappuccino[] { (new Frappuccino()), (new VanillaFrap()), (new ChocolateFrap()), (new StrawberryFrap()), };
            foreach (var o in frappuccino)
            {
                singleton.Instance.YalovaBeveragesTypes[o.ToString()] = true;
            }
            return frappuccino;
        }

        public override void update(object o, double raise)
        {
            throw new NotImplementedException();
        }
    }
}
