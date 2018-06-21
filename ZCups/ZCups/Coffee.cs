using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCups
{
    abstract class Coffee
    {
        public string CoffeeType { get; set; }
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double Cost();
        public override string ToString()=>  CoffeeType;


    }
    class Esspresso : Coffee
    {
        
        public Esspresso() { Description = "Esspresso"; CoffeeType = Description; }

        public override double Cost() => singleton.Instance.EsspressoCost += 5.0;

        public override string GetDescription() => Description;
       
    }
    class Americano : Esspresso
    {
        public Americano() { CoffeeType = "Americano"; Description = CoffeeType; }
    }
    class Cappuccino : Esspresso
    {
        public Cappuccino() { CoffeeType = "Cappuccino"; Description = CoffeeType; }
    }
    class Caffe : Esspresso
    {
        public Caffe()
        {
            CoffeeType = "Caffe";
            Description = CoffeeType;
        }
        public override string GetDescription() => Description;
        
    }
    class WhiteChocolate : Esspresso
    {
        public WhiteChocolate() { CoffeeType = "White Chocolate"; Description = CoffeeType; }
    }
    class FilteredCoffee : Coffee
    {
        
        public FilteredCoffee() { Description = "Filtered Coffee"; CoffeeType = Description; }
        public override double Cost() => singleton.Instance.FilteredCost += 7.0;
        public override string GetDescription() => Description;
    }
    class Brew : FilteredCoffee
    {
        public Brew() { CoffeeType = "Brew"; Description = CoffeeType; }
    }
    class Misto : FilteredCoffee
    {
        public Misto() { CoffeeType = "Misto"; Description = CoffeeType; }
    }
    class Frappuccino : Coffee
    {
        public Frappuccino() { Description = "Frappuccino"; CoffeeType = Description; }
        public override double Cost() =>singleton.Instance.FrapCost += 6.5;
        public override string GetDescription() => Description;
        
    }
    class  ChocolateFrap : Frappuccino
    {
        public ChocolateFrap() { CoffeeType = "Chocolate Frap"; Description = CoffeeType; }
    }
    class StrawberryFrap : Frappuccino
    {
        public StrawberryFrap() { CoffeeType = "Strawberry Frap"; Description = CoffeeType; }
    }
    class VanillaFrap : Frappuccino
    {
        public VanillaFrap() { CoffeeType = "Vanilla Frap"; Description = CoffeeType; }
    }

}
