using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCups
{
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
    class Milk : Decorator
    {
        public Milk(Coffee coffee) : base(coffee)
        {
            Description = "Latte";
        }
        public override double Cost() => coffee.Cost() + 0.75;
        public override string GetDescription() => $"{coffee.Description} {Description} ";

    }
    class Ice : Decorator
    {
        public Ice(Coffee coffee) : base(coffee)
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
        public override string GetDescription() => $" {Description} {coffee.Description} ";

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
