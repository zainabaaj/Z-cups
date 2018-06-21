using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCups
{
    abstract class Sube
    {

        public List<Esspresso> EsspressoType { get; set; }
        public List<FilteredCoffee> FilteredCoffeeType { get; set; }
        public List<Frappuccino> FrappuccinoType { get; set; }
        public abstract List<Esspresso> EsspressoTypes();
        public abstract List<FilteredCoffee> FilteredCoffeeTypes();
        public abstract List<Frappuccino> FrappuccinoTypes();
        public List<Coffee> RaisedCoffee = new List<Coffee>();
        public abstract void RegisterRaisedCoffee(List<Coffee> coffee);
        public void TemplateMethod(string AddedBeverage,string DeletedBeverage,double raise)
        {
            AddBeverage(AddedBeverage);
            DeleteBeverage(DeletedBeverage);
            update(raise);

        }
        public abstract void AddBeverage(string beverage);
        public abstract void DeleteBeverage(string beverage);
        public void update(double raise)
        {

            foreach (Coffee c in RaisedCoffee)
            {
                if(c.GetType() == typeof(Esspresso))
                {
                    singleton.Instance.EsspressoCost = raise;

                }
                if (c.GetType() == typeof(FilteredCoffee))
                {
                    singleton.Instance.FilteredCost = raise;

                }
                if (c.GetType() == typeof(Frappuccino))
                {
                    singleton.Instance.FrapCost = raise;

                }
                
            }
        }
        
    }
    class BursaSube : Sube
    {
        public BursaSube()
        {
            EsspressoType = EsspressoTypes();
            FilteredCoffeeType = FilteredCoffeeTypes();
            FrappuccinoType = FrappuccinoTypes();
        }
        public override List<Esspresso> EsspressoTypes()
        { 
            List<Esspresso> esspresso = new List<Esspresso>() { (new Esspresso()), (new Americano()), (new Cappuccino()), (new Caffe()), (new WhiteChocolate()), };
            foreach (var o in esspresso)
            {
                singleton.Instance.BursaBeveragesTypes[o.ToString()] = true;
            }
            return esspresso;
        }

        public override List<FilteredCoffee> FilteredCoffeeTypes()
        {
            List<FilteredCoffee> filteredCoffee = new List<FilteredCoffee>() { (new FilteredCoffee()), (new Brew()), (new Misto()), };
            foreach (var o in filteredCoffee)
            {
                singleton.Instance.BursaBeveragesTypes[o.ToString()] = true;
            }
            return filteredCoffee;
        }

        public override List<Frappuccino> FrappuccinoTypes()
        {
            List<Frappuccino> frappuccino = new List<Frappuccino>() { (new Frappuccino()), (new VanillaFrap()), (new ChocolateFrap()), (new StrawberryFrap()), };
            foreach (var o in frappuccino)
            {
                singleton.Instance.BursaBeveragesTypes[o.ToString()] = true;
            }
            return frappuccino;
        }

        public override void AddBeverage(string beverage)
        {
           
                switch (beverage)
                {
                    case "Esspresso":
                        singleton.Instance.BursaBeveragesTypes["Esspresso"] = true;
                        EsspressoType.Add(new Esspresso());
                        break;
                    case "Americano":
                        singleton.Instance.BursaBeveragesTypes["Americano"] = true;
                        EsspressoType.Add(new Americano());
                        break;
                    case "Caffe":
                        singleton.Instance.BursaBeveragesTypes["Caffe"] = true;
                        EsspressoType.Add(new Caffe());
                        break;
                    case "Cappuccino":
                        singleton.Instance.BursaBeveragesTypes["Cappuccino"] = true;
                        EsspressoType.Add(new Cappuccino());
                        break;
                    case "Filtered Coffee":
                        singleton.Instance.BursaBeveragesTypes["Filtered Coffee"] = true;
                        FilteredCoffeeType.Add(new FilteredCoffee());
                        break;
                    case "Misto":
                        singleton.Instance.BursaBeveragesTypes["Misto"] = true;
                        FilteredCoffeeType.Add(new Misto());
                        break;
                    case "Brew":
                        singleton.Instance.BursaBeveragesTypes["Brew"] = true;
                        FilteredCoffeeType.Add(new Brew());
                        break;
                    case "Frappuccino":
                        singleton.Instance.BursaBeveragesTypes["Frappuccino"] = true;
                        FrappuccinoType.Add(new Frappuccino());
                        break;
                    case "Chocolate Frap":
                        singleton.Instance.BursaBeveragesTypes["Chocolate Frap"] = true;
                        FrappuccinoType.Add(new ChocolateFrap());
                        break;
                    case "Strawberry Frap":
                        singleton.Instance.BursaBeveragesTypes["Chocolate Frap"] = true;
                        FrappuccinoType.Add(new StrawberryFrap());
                        break;
                    case "Vanilla Frap":
                        singleton.Instance.BursaBeveragesTypes["Chocolate Frap"] = true;
                        FrappuccinoType.Add(new VanillaFrap());
                        break;

                    default:
                        break;
                }
                
            
            
        }

        public override void DeleteBeverage(string beverage)
        {
            switch (beverage)
            {
                case "Esspresso":
                    singleton.Instance.BursaBeveragesTypes["Esspresso"] = false;
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Esspresso));
                    break;
                case "Americano":
                    singleton.Instance.BursaBeveragesTypes["Americano"] = false;
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Americano));
                    break;
                case "Caffe":
                    singleton.Instance.BursaBeveragesTypes["Caffe"] = false;
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Caffe));
                    break;
                case "Cappuccino":
                    singleton.Instance.BursaBeveragesTypes["Cappuccino"] = false;
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Cappuccino));
                    break;
                case "Filtered Coffee":
                    singleton.Instance.BursaBeveragesTypes["Filtered Coffee"] = false;
                    FilteredCoffeeType.RemoveAll(x => x.GetType() == typeof(FilteredCoffee));
                    break;
                case "Misto":
                    singleton.Instance.BursaBeveragesTypes["Misto"] = false;
                    FilteredCoffeeType.RemoveAll(x => x.GetType() == typeof(Misto));
                    break;
                case "Brew":
                    singleton.Instance.BursaBeveragesTypes["Brew"] = false;
                    FilteredCoffeeType.RemoveAll(x => x.GetType() == typeof(Brew));
                    break;
                case "Frappuccino":
                    singleton.Instance.BursaBeveragesTypes["Frappuccino"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(Frappuccino));
                    break;
                case "Chocolate Frap":
                    singleton.Instance.BursaBeveragesTypes["Chocolate Frap"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(ChocolateFrap));
                    break;
                case "Strawberry Frap":
                    singleton.Instance.BursaBeveragesTypes["Strawberry Frap"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(StrawberryFrap));
                    break;
                case "Vanilla Frap":
                    singleton.Instance.BursaBeveragesTypes["Vanilla Frap"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(VanillaFrap));
                    break;

                default:
                    break;
            }
            
        }

        public override void RegisterRaisedCoffee(List<Coffee> coffee)
        {
            RaisedCoffee.AddRange(coffee);
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
        
        public override List<Esspresso> EsspressoTypes()
        {
            List<Esspresso> esspresso = new List<Esspresso>() { (new Esspresso()), (new Americano()),  };
            foreach (var o in esspresso)
            {
                singleton.Instance.YalovaBeveragesTypes[o.ToString()] = true;
            }
            return esspresso;
        }

        public override List<FilteredCoffee> FilteredCoffeeTypes()
        {
            List<FilteredCoffee> filteredCoffee = new List<FilteredCoffee>() { (new FilteredCoffee()), };
            foreach (var o in filteredCoffee)
            {
                singleton.Instance.YalovaBeveragesTypes[o.ToString()] = true;
            }
            return filteredCoffee;
        }

        public override List<Frappuccino> FrappuccinoTypes()
        {
            List<Frappuccino> frappuccino = new List<Frappuccino>() { (new Frappuccino()), (new ChocolateFrap()), };
            foreach (var o in frappuccino)
            {
                singleton.Instance.YalovaBeveragesTypes[o.ToString()] = true;
            }
            return frappuccino;
        }




        public override void AddBeverage(string beverage)
        {

            switch (beverage)
            {
                case "Esspresso":
                    singleton.Instance.YalovaBeveragesTypes["Esspresso"] = true;
                    EsspressoType.Add(new Esspresso());
                    break;
                case "Americano":
                    singleton.Instance.YalovaBeveragesTypes["Americano"] = true;
                    EsspressoType.Add(new Americano());
                    break;
                case "Caffe":
                    singleton.Instance.YalovaBeveragesTypes["Caffe"] = true;
                    EsspressoType.Add(new Caffe());
                    break;
                case "Cappuccino":
                    singleton.Instance.YalovaBeveragesTypes["Cappuccino"] = true;
                    EsspressoType.Add(new Cappuccino());
                    break;
                case "Filtered Coffee":
                    singleton.Instance.YalovaBeveragesTypes["Filtered Coffee"] = true;
                    FilteredCoffeeType.Add(new FilteredCoffee());
                    break;
                case "Misto":
                    singleton.Instance.YalovaBeveragesTypes["Misto"] = true;
                    FilteredCoffeeType.Add(new Misto());
                    break;
                case "Brew":
                    singleton.Instance.YalovaBeveragesTypes["Brew"] = true;
                    FilteredCoffeeType.Add(new Brew());
                    break;
                case "Frappuccino":
                    singleton.Instance.YalovaBeveragesTypes["Frappuccino"] = true;
                    FrappuccinoType.Add(new Frappuccino());
                    break;
                case "Chocolate Frap":
                    singleton.Instance.YalovaBeveragesTypes["Chocolate Frap"] = true;
                    FrappuccinoType.Add(new ChocolateFrap());
                    break;
                case "Strawberry Frap":
                    singleton.Instance.YalovaBeveragesTypes["Chocolate Frap"] = true;
                    FrappuccinoType.Add(new StrawberryFrap());
                    break;
                case "Vanilla Frap":
                    singleton.Instance.YalovaBeveragesTypes["Chocolate Frap"] = true;
                    FrappuccinoType.Add(new VanillaFrap());
                    break;

                default:
                    break;
            }

        }

        public override void DeleteBeverage(string beverage)
        {
            switch (beverage)
            {
                case "Esspresso":
                    singleton.Instance.YalovaBeveragesTypes["Esspresso"] = false;
                    Esspresso esspresso = new Esspresso();
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Esspresso));
                    break;
                case "Americano":
                    singleton.Instance.YalovaBeveragesTypes["Americano"] = false;
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Americano));
                    break;
                case "Caffe":
                    singleton.Instance.YalovaBeveragesTypes["Caffe"] = false;
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Caffe));
                    break;
                case "Cappuccino":
                    singleton.Instance.YalovaBeveragesTypes["Cappuccino"] = false;
                    EsspressoType.RemoveAll(x => x.GetType() == typeof(Cappuccino));
                    break;
                case "Filtered Coffee":
                    singleton.Instance.YalovaBeveragesTypes["Filtered Coffee"] = false;
                    FilteredCoffeeType.RemoveAll(x => x.GetType() == typeof(FilteredCoffee));
                    break;
                case "Misto":
                    singleton.Instance.YalovaBeveragesTypes["Misto"] = false;
                    FilteredCoffeeType.RemoveAll(x => x.GetType() == typeof(Misto));
                    break;
                case "Brew":
                    singleton.Instance.YalovaBeveragesTypes["Brew"] = false;
                    FilteredCoffeeType.RemoveAll(x => x.GetType() == typeof(Brew));
                    break;
                case "Frappuccino":
                    singleton.Instance.YalovaBeveragesTypes["Frappuccino"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(Frappuccino));
                    break;
                case "Chocolate Frap":
                    singleton.Instance.YalovaBeveragesTypes["Chocolate Frap"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(ChocolateFrap));
                    break;
                case "Strawberry Frap":
                    singleton.Instance.YalovaBeveragesTypes["Strawberry Frap"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(StrawberryFrap));
                    break;
                case "Vanilla Frap":
                    singleton.Instance.YalovaBeveragesTypes["Vanilla Frap"] = false;
                    FrappuccinoType.RemoveAll(x => x.GetType() == typeof(VanillaFrap));
                    break;

                default:
                    break;
            }

        }


        public override void RegisterRaisedCoffee(List<Coffee> coffee)
        {
            RaisedCoffee.AddRange(coffee);
        }
    }
}
