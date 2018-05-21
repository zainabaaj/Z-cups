using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCups
{
    abstract class Coffee
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double Cost();
            

    }
    class Esspresso : Coffee
    {
        public Esspresso() { Description = "Esspresso";}

        public override double Cost() => 5.0;

        public override string GetDescription() => Description;
       
    }
    class FilteredCoffee : Coffee
    {
        public FilteredCoffee() { Description = "Filtered Coffee"; }
        public override double Cost() => 7.0;
        public override string GetDescription() => Description;
    }
    class Frappuccino : Coffee
    {
        public Frappuccino() { Description = "Frappoccino"; }
        public override double Cost() => 6.5;
        public override string GetDescription() => Description;
        
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
        public override string GetDescription() => $"{coffee.Description} {Description}";
        
    }
    class Ice : Decorator
    {
        public Ice(Coffee coffee): base(coffee)
        {
            Description = "Iced";
        }
        public override double Cost() => coffee.Cost() + 0.5;
        public override string GetDescription() => $"{Description} {coffee.Description}";

    }
    class Mocha : Decorator
    {
        public Mocha(Coffee coffee) : base(coffee)
        {
            Description = "Mocha";
        }
        public override double Cost() => coffee.Cost() + 1.25;
        public override string GetDescription() => $"{coffee.Description} {Description}";

    }
}
