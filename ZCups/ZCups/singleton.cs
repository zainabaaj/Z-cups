using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCups
{
    class singleton
    {
        public List<int> Id { get; set; }
        public double TotalPrice = .0;
        public List<double> Price { get; set; }
        public Dictionary<string, string> YalovaAdmins;
        public Dictionary<string, string> BursaAdmins;
        public Dictionary<string , bool> YalovaBeveragesTypes;
        public Dictionary<string, bool> BursaBeveragesTypes;

        private static singleton _instance;
        public static singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new singleton();
                    // once the insatce is created all the intial object will be creates with it 
                    _instance.CreateInstance();

                }

                return _instance;
            }
        }

        private void CreateInstance()
        {
            Id = new List<int>();
            Price = new List<double>();
            YalovaAdmins = new Dictionary<string, string>();
            BursaAdmins = new Dictionary<string, string>();
            YalovaAdmins.Add("zeyna", "123");
            YalovaAdmins.Add("irfan", "1234");
            BursaAdmins.Add("Ahmad", "123");
            BursaAdmins.Add("helena", "1234");
            YalovaBeveragesTypes = new Dictionary<string, bool>();
            BursaBeveragesTypes = new Dictionary<string, bool>();
            YalovaBeveragesTypes.Add("Esspresso", false);
            YalovaBeveragesTypes.Add("Americano", false);
            YalovaBeveragesTypes.Add("Cappuccino", false);
            YalovaBeveragesTypes.Add("Caffe", false);
            YalovaBeveragesTypes.Add("White Chocolate", false);
            YalovaBeveragesTypes.Add("Filtered Coffee", false);
            YalovaBeveragesTypes.Add("Brew", false);
            YalovaBeveragesTypes.Add("Misto", false);
            YalovaBeveragesTypes.Add("Frappuccino", false);
            YalovaBeveragesTypes.Add("Chocolate Frap", false);
            YalovaBeveragesTypes.Add("Strawberry Frap", false);
            YalovaBeveragesTypes.Add("Vanilla Frap", false);

            //bursa beverages
            BursaBeveragesTypes.Add("Esspresso", false);
            BursaBeveragesTypes.Add("Americano", false);
            BursaBeveragesTypes.Add("Cappuccino", false);
            BursaBeveragesTypes.Add("Caffe", false);
            BursaBeveragesTypes.Add("White Chocolate", false);
            BursaBeveragesTypes.Add("Filtered Coffee", false);
            BursaBeveragesTypes.Add("Brew", false);
            BursaBeveragesTypes.Add("Misto", false);
            BursaBeveragesTypes.Add("Frappuccino", false);
            BursaBeveragesTypes.Add("Chocolate Frap", false);
            BursaBeveragesTypes.Add("Strawberry Frap", false);
            BursaBeveragesTypes.Add("Vanilla Frap", false);









        }
    }
}
