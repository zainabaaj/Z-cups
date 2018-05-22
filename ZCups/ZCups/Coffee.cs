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

        public override double Cost() => 5.0;

        public override string GetDescription() => Description;
       
    }
    class Americano : Esspresso
    {
        public Americano() { CoffeeType = "Americano"; }
    }
    class Cappuccino : Esspresso
    {
        public Cappuccino() { CoffeeType = "Cappuccino"; }
    }
    class Caffe : Esspresso
    {
        public Caffe() { CoffeeType = "Caffe"; }
    }
    class WhiteChocolate : Esspresso
    {
        public WhiteChocolate() { CoffeeType = "White Chocolate"; }
    }
    class FilteredCoffee : Coffee
    {
        
        public FilteredCoffee() { Description = "Filtered Coffee"; CoffeeType = Description; }
        public override double Cost() => 7.0;
        public override string GetDescription() => Description;
    }
    class Brew : FilteredCoffee
    {
        public Brew() { CoffeeType = "Brew"; }
    }
    class Misto : FilteredCoffee
    {
        public Misto() { CoffeeType = "Misto"; }
    }
    class Frappuccino : Coffee
    {
        public Frappuccino() { Description = "Frappuccino"; CoffeeType = Description; }
        public override double Cost() => 6.5;
        public override string GetDescription() => Description;
        
    }
    class  ChocolateFrap : Frappuccino
    {
        public ChocolateFrap() { CoffeeType = "Chocolate Frap"; }
    }
    class StrawberryFrap : Frappuccino
    {
        public StrawberryFrap() { CoffeeType = "Chocolate Frap"; }
    }
    class VanillaFrap : Frappuccino
    {
        public VanillaFrap() { CoffeeType = "Chocolate Frap"; }
    }
    abstract class Decorator : Coffee
    {
        protected Coffee coffee;
        public Decorator(Coffee coffee)
        {
            this.coffee = coffee;
        }
        public override double Cost() => coffee.Cost();
        public override string GetDescription() => Description;
        

    }
    class Milk: Decorator
    {
        public Milk(Coffee coffee) : base (coffee)
        {
            Description = "latte";
        }
        public override double Cost() => coffee.Cost() + 0.75;
        public override string GetDescription() => $"{coffee.Description} {Description} ";
        
    }
    class Ice : Decorator
    {
        public Ice(Coffee coffee): base(coffee)
        {
            Description = "Iced";
        }
        public override double Cost() => coffee.Cost() + 0.5;
        public override string GetDescription() => $"{Description} {coffee.Description} ";

    }
    class Mocha : Decorator
    {
        public Mocha(Coffee coffee) : base(coffee)
        {
            Description = "Mocha";
        }
        public override double Cost() => coffee.Cost() + 1.25;
        public override string GetDescription() => $"{coffee.Description} {Description} ";

    }
    class Caramel : Decorator
    {
        public Caramel(Coffee coffee) : base(coffee)
        {
            Description = "Caramel";
        }
        public override double Cost() => coffee.Cost() + 0.25;
        public override string GetDescription() => $"{Description} {coffee.Description} ";
    }
}
